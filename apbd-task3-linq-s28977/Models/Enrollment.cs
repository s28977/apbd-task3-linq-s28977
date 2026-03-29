namespace apbd_task3_linq_s28977.Models;

public sealed class Enrollment
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public int CourseId { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public double? FinalGrade { get; set; }

    public bool IsActive { get; set; }
}
