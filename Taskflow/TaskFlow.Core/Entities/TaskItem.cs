using System.ComponentModel.DataAnnotations;
using TaskFlow.Core.Enums;

namespace TaskFlow.Core.Entities;
/// <summary>
/// TaskItem: Items on the board
/// </summary>
public class TaskItem
{
    public long TaskId { get; set; }
    
    [StringLength(160)]
    [Required]
    public required string Title { get; set; }
    
    [Required]
    public required User Creator { get; set; }
    
    public List<User>? Participants { get; set;}
    
    public DateTime CreationDate { get; set; }
    
    public DateTime Deadline { get; set; }
    
    public string? Description { get; set; }
    
    public TaskItemStatus Status { get; set; }
}