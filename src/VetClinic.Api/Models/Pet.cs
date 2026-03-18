namespace VetClinic.Api.Models;

public class Pet
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Species { get; set; } = "";
    public string? Breed { get; set; }
    public DateTime? BirthDate { get; set; }

    public int OwnerId { get; set; }
}