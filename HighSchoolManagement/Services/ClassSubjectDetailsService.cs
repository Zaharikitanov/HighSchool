using Datalayer.Interfaces;
using Entities;

namespace HighSchoolManagement.Services
{
    public class ClassSubjectDetailsService : IClassSubjectDetailsService
    {
        IDataComponents<ISubjectClass> _subjectsData;

        public ClassSubjectDetailsService(IDataComponents<ISubjectClass> subjectsData)
        {
            _subjectsData = subjectsData;
        }

        public int GetClassSubjectById(string name)
        {
            var subjectId = _subjectsData.RetrieveObjects().Find(x => x.Name == name);
            return subjectId.Id;
        }

        public string GetClassSubjectName(int subjectId)
        {
            var subjectName = _subjectsData.RetrieveObjects().Find(x => x.Id == subjectId);
            return subjectName.Name;
        }
    }
}
