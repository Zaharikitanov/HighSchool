namespace Entities
{
    public class SubjectClass : ISubjectClass
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public SubjectClass (int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
