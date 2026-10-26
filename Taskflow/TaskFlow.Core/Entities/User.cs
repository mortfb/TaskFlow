using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace TaskFlow.Core.Entities;

/// <summary>
/// User represents a person using the board
/// </summary>
public class User : IdentityUser<long>
{
    [StringLength(60)]
    [Required]
    public required string Name { get; set; }
    
    [Required]
    public required string Email { get; set; }
}