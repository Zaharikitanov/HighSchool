namespace Entities
{
    public class Grade : IGrade
    {
        public int StudentId { get; set; }

        public int ClassId { get; set; }

        public int StudentGrade { get; set; }

        public Grade(int studentId, int classId, int studentGrade)
        {
            StudentId = studentId;
            ClassId = classId;
            StudentGrade = studentGrade;
        }
    }
}
