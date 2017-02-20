using System.Runtime.Serialization;

namespace SchoolService
{
    [DataContract]
    public class Course
    {
        public Course(string name, int capacity, int nrOfParticipants,string teacherName)
        {
            Name = name;
            Capacity = capacity;
            NrOfParticipants = nrOfParticipants;
            TeacherName = teacherName;
        }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Capacity { get; set; }
        public int NrOfParticipants { get; set; }
        public string TeacherName { get; set; }



    }
}
