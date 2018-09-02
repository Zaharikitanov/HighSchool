namespace HighSchoolManagement.Services
{
    public interface IStudentDetailsService
    {
        int GetStudentId(string name);
        string GetStudentName(int studentId);
    }
}