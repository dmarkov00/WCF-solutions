using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace SchoolService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class CSchool : ISchool
    {
        public CSchool()
        {
            courseList = new List<Course>();
            courseList.Add(new Course("English", 5, 0, "Mr. Anderson"));
            courseList.Add(new Course("Spanish", 6, 0, "Mr. Anderson"));
            courseList.Add(new Course("Dutch", 3, 0, "Mr. Van"));
            courseList.Add(new Course("German", 3, 0, "Mr. Anderson"));
        }
        List<Course> courseList;
        // delegate for the event
        private Action<string> CourseFull = delegate { };

        public int GetNumberOfCourses()
        {
            return courseList.Count;
        }

        public string GetTeacherName(string courseName)
        {
            foreach (Course course in courseList)
            {
                if (course.Name == courseName)
                {
                    return course.TeacherName;
                }
            }
            return "No such course";
        }

        public List<Course> GetCourseList()
        {
            return courseList;
        }

        public bool SignInForCourse(string courseName)
        {
            foreach (Course course in courseList)
            {
                if (course.Name == courseName)
                {
                    if (course.Capacity > course.NrOfParticipants)
                    {
                        course.NrOfParticipants++;
                        if (course.NrOfParticipants == course.Capacity)
                        {
                            // We do that because we get deadlock on the current client, it should be called on all the others
                            // Instance of the current client
                            ISchoolEvents clientCallback = OperationContext.Current.GetCallbackChannel<ISchoolEvents>();
                            // We remove it to prevent dealock
                            CourseFull -= clientCallback.OnCourseFull;
                            // Add the new full course
                            CourseFull(course.Name);
                            // Add the current cliet back 
                            CourseFull += clientCallback.OnCourseFull;

                        }
                            
                        return true;
                    }

                }
            }
            return false;
        }

        public void SubscribeEvent()
        {
            ISchoolEvents clientCallback = OperationContext.Current.GetCallbackChannel<ISchoolEvents>();
            CourseFull += clientCallback.OnCourseFull;
        }

        public void UnsubscribeEvent()
        {
            ISchoolEvents clientCallback = OperationContext.Current.GetCallbackChannel<ISchoolEvents>();
            CourseFull -= clientCallback.OnCourseFull;
        }
    }
}