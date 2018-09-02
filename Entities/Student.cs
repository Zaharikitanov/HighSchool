namespace Entities
{
    public class Student : IStudent
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
