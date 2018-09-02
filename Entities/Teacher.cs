namespace Entities
{
    public class Teacher : ITeacher
    {
        public int Id { get; set; }

        public int SubjectClassId { get; set; }

        public string Name { get; set; }

        public Teacher (int id, string name, int subjectClassId)
        {
            Id = id;
            Name = name;
            SubjectClassId = subjectClassId;
        }
    }
}
