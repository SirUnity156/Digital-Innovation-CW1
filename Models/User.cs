using System.ComponentModel.DataAnnotations;

namespace DigitalInnovationCW1.Models;

/**
    * Represents a user record in the database.
*/
public class User
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public required string HashedPassword { get; set; }
    public bool IsDarkMode { get; set; }
}