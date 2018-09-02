namespace HighSchoolManagement.Interfaces
{
    public interface IGradesManagement
    {
        double ClassAverageGrade(int subjectClassId);

        double ClassHighestGrade(int subjectClassId);
    }
}
