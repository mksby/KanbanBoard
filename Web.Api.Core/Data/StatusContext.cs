using Microsoft.EntityFrameworkCore;
using Web.Api.Core.Models;

namespace Web.Api.Infrastructure.Data
{
    public sealed class StatusContext : DbContext
    {
        public DbSet<Status> Statuses { get; set; }
        public StatusContext(DbContextOptions<StatusContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}