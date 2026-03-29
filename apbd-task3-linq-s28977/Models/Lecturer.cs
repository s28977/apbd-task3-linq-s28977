namespace apbd_task3_linq_s28977.Models;

public sealed class Lecturer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Department { get; set; } = string.Empty;

    public DateTime EmploymentDate { get; set; }
}
