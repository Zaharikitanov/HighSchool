namespace Entities.Factory
{
    public static class EntityFactory
    {
        public static IGrade CreateGrade (int studentId, int classId, int studentGrade)
        {
            return new Grade(studentId, classId, studentGrade);
        }

        public static IStudent CreateStudent(int id, string name)
        {
            return new Student(id, name);
        }

        public static ISubjectClass CreateSubjectClass(int id, string text)
        {
            return new SubjectClass(id, text);
        }

        public static ITeacher CreateTeacher(int id, string name, int subjectClassId)
        {
            return new Teacher(id, name, subjectClassId);
        }
    }
}
