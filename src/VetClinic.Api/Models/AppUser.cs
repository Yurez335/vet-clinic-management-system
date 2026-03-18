namespace VetClinic.Api.Models;

public class AppUser
{
    public int Id { get; set; }
    public string FullName { get; set; } = "";
    public string Role { get; set; } = "client";
}