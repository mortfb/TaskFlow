using System.ComponentModel.DataAnnotations;

namespace TaskFlow.Core.Entities;
/// <summary>
/// The board for tasks, multiple are possible
/// </summary>
public class TaskBoard
{
    public required HashSet<TaskItem> Items { get; set; }
    
    [StringLength(160)]
    [Required]
    public required string Title { get; set; }
    
    [Required]
    public required User Creator { get; set; }
    
    //public List<User>? Participants { get; set;} maybe
    
    public DateTime CreationDate { get; set; }
    
    public string? Description { get; set; }
}