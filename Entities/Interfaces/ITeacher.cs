namespace Entities
{
    public interface ITeacher
    {
        int Id { get; set; }
        string Name { get; set; }
        int SubjectClassId { get; set; }
    }
}