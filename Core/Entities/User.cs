namespace Backend.Core.Entities;
public class User
{
    public Guid Guid { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty; 
    public string Password { get; set; } = string.Empty;
}
