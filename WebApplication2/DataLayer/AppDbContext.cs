using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.DataLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Message> Messages { get; set; }
    }
}
//hello karthik

