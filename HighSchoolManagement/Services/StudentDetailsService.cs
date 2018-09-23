using Datalayer.Interfaces;
using Entities;

namespace HighSchoolManagement.Services
{
    public class StudentDetailsService : IStudentDetailsService
    {
        IDataComponents<IStudent> _studentsData;

        public StudentDetailsService(IDataComponents<IStudent> studentsData)
        {
            _studentsData = studentsData;
        }

        public int GetStudentId(string name)
        {
            var studentId = _studentsData.RetrieveObjects().Find(x => x.Name == name);
            return studentId.Id;
        }

        public string GetStudentName(int studentId)
        {
            var studentName = _studentsData.RetrieveObjects().Find(x => x.Id == studentId);
            return studentName.Name;
        }
    }
}
