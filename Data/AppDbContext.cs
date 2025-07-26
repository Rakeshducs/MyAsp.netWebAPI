using Microsoft.EntityFrameworkCore;
using MyAsp.netWebAPI.Models;

namespace MyAsp.netWebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}

