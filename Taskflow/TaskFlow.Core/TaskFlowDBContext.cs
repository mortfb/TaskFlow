using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskFlow.Core.Entities;

namespace TaskFlow.Core;

public class TaskFlowDbContext : IdentityDbContext<User, IdentityRole<long>, long>
{
    public DbSet<User> Users { get; set; }
    public DbSet<TaskItem> Items { get; set; }
    public DbSet<TaskBoard> Boards { get; set; }


    public TaskFlowDbContext(DbContextOptions<TaskFlowDbContext> options) : base(options)
    {
        
    }
}