namespace VetClinic.Api.Models;

public class Appointment
{
    public int Id { get; set; }

    public int DoctorId { get; set; }
    public int PetId { get; set; }

    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    public string Status { get; set; } = "Planned";
}