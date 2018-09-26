using Datalayer.Interfaces;
using Entities;

namespace Datalayer.Factory
{
    public static class DataFactory
    {
        public static IDataComponents<IGrade> GetGrades ()
        {
            return new GradesData();
        }
        public static IDataComponents<IStudent> GetStudent()
        {
            return new StudentsData();
        }
        public static IDataComponents<ISubjectClass> GetSubjects()
        {
            return new SubjectData();
        }
        public static IDataComponents<ITeacher> GetTeacher()
        {
            return new TeachersData();
        }
    }
}
