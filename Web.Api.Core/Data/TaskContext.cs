using Microsoft.EntityFrameworkCore;
using Web.Api.Core.Models;

namespace Web.Api.Infrastructure.Data
{
    public sealed class TaskContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public TaskContext(DbContextOptions<TaskContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}