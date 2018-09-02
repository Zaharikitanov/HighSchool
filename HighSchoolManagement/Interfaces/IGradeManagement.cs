namespace HighSchoolManagement.Interfaces
{
    public interface IGradesManagement
    {
        double ClassAverageGrade(int subjectClassId);

        double ClassHighestGrade(int subjectClassId);

        double StudentAverageGrade(int subjectClassId, int studentId);

        double StudentHighestGrade(int subjectClassId, int studentId);
    }
}
