using Datalayer.Factory;
using HighSchoolManagement.Interfaces;
using HighSchoolManagement.Services;

namespace HighSchoolManagement.Factories
{
    public static class ManagementFactory
    {
        public static IStudentDetailsService StudentDetailsService ()
        {
            return new StudentDetailsService(DataFactory.GetStudent());
        }

        public static IClassSubjectDetailsService ClassSubjectDetailsService()
        {
            return new ClassSubjectDetailsService(DataFactory.GetSubjects());
        }

        public static IGradesManagement GradesManagement()
        {
            return new GradesManagement(DataFactory.GetGrades());
        }

        public static IStudentsManagement StudentsManagement()
        {
            return new StudentsManagement();
        }

    }
}
