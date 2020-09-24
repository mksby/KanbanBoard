using Microsoft.EntityFrameworkCore;
using Web.Api.Core.Models;

namespace Web.Api.Infrastructure.Data
{
    public sealed class StatusLinkContext : DbContext
    {
        public DbSet<StatusLink> StatusLinks { get; set; }
        public StatusLinkContext(DbContextOptions<StatusLinkContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}