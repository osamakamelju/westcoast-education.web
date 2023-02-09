namespace westcoast_education.web.Models
{
    public class Classroom
    {

    public int Number { get; set; }
    public string Name { get; set; } = "";
    public string Title { get; set; } = "";
    public string Content { get; set; } = "";
    public double AvgGrade { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public TimeSpan Length { get => End - Start; }
    public string Schedule { get; set; } = "";
    public bool IsOnDistance { get; init; }
    public int TeacherId { get; set; }
    public int ClassroomId { get; internal set; }

    }
}