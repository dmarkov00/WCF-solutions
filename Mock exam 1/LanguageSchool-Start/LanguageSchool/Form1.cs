using System.Windows.Forms;
using LanguageSchool.SchoolServiceReference;
using System.ServiceModel;
using System;

namespace LanguageSchool
{
    public partial class Form1 : Form, ISchoolCallback
    {

        public Form1()
        {
            InitializeComponent();
            context = new InstanceContext(this);
            proxy = new SchoolClient(context);
            proxy.SubscribeEvent();
        }
        private SchoolClient proxy;
        InstanceContext context;

        private void showNotification(string notification)
        {
            lbNotifications.Items.Add(notification);
        }

        private void btnNrCourses_Click(object sender, System.EventArgs e)
        {
            int nrOfCourses = proxy.GetNumberOfCourses();
            showNotification("Number of courses is " + nrOfCourses);
        }

        private void btnTeacher_Click(object sender, System.EventArgs e)
        {
            string teacherName = proxy.GetTeacherName(tbCourseName.Text);

            showNotification("Teacher of course " + tbCourseName.Text + " is " + teacherName);
        }

        private void btnCoursesList_Click(object sender, System.EventArgs e)
        {
            lbName.Items.Clear();
            lbCapacity.Items.Clear();
            var courseList = proxy.GetCourseList();
            foreach (var course in courseList)
            {
                lbName.Items.Add(course.Name);
                lbCapacity.Items.Add(course.Capacity);
            }
        }

        private void btnSignIn_Click(object sender, System.EventArgs e)
        {
            string courseName = lbName.SelectedItem.ToString();
            if (proxy.SignInForCourse(courseName))
            {
                showNotification("You succesfully signed in for course " + courseName);
            }
            else
            {
                showNotification("Course " + courseName + " is full");
            }
        }

        public void OnCourseFull(string courseName)
        {
            showNotification("The course " + courseName + " is full");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            proxy.UnsubscribeEvent();
        }
    }
}
