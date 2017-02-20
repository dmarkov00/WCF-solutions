using System.ServiceModel;

namespace SchoolService
{
    public interface ISchoolEvents
    {
        [OperationContract(IsOneWay = true)]
        void OnCourseFull(string courseName);

    }
}
