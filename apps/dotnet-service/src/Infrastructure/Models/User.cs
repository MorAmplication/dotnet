using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace DotnetService.Infrastructure.Models;

[Table("Users")]
public class User : IdentityUser
{
    [Key()]
    [Required()]
    public string Id { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(256)]
    public string? FirstName { get; set; }

    [StringLength(256)]
    public string? LastName { get; set; }

    [Required()]
    public string Username { get; set; }

    public string? Email { get; set; }

    [Required()]
    public string Password { get; set; }

    [Required()]
    public string Roles { get; set; }
}
