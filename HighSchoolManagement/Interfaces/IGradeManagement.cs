using HighSchoolManagement.Enums;

namespace HighSchoolManagement.Interfaces
{
    public interface IGradesManagement
    {
        string PersonalToClassGradeComparer(int subjectClassId, int studentId, GradeType gradeType);
    }
}
