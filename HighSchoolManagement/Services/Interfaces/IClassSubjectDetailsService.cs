namespace HighSchoolManagement.Services
{
    public interface IClassSubjectDetailsService
    {
        int GetClassSubjectById(string name);
        string GetClassSubjectName(int subjectId);
    }
}