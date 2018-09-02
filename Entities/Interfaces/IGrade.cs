namespace Entities
{
    public interface IGrade
    {
        int ClassId { get; set; }
        int StudentGrade { get; set; }
        int StudentId { get; set; }
    }
}