using System.Collections.Generic;
using System.ServiceModel;

namespace SchoolService
{
    [ServiceContract(Namespace = "SchoolService", CallbackContract = typeof(ISchoolEvents))]

    public interface ISchool
    {
        [OperationContract]
        int GetNumberOfCourses();
        [OperationContract]

        string GetTeacherName(string courseName);
        [OperationContract]
        List<Course> GetCourseList();
        [OperationContract]
        bool SignInForCourse(string courseName);
        [OperationContract]
        void SubscribeEvent();

        [OperationContract]
        void UnsubscribeEvent();
    }
}
