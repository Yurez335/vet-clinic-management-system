namespace VetClinic.Api.Models;

public class Visit
{
    public int Id { get; set; }
    public int AppointmentId { get; set; }

    public string? Complaints { get; set; }
    public string? Examination { get; set; }
    public string? Diagnosis { get; set; }
    public string? Recommendations { get; set; }
}