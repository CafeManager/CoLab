using CoLab.Models;
using Microsoft.EntityFrameworkCore;

namespace CoLab.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Comments> Comments {get; set;}
    }
}
