using Microsoft.EntityFrameworkCore;
using MvcMovie.Models.Entities;
namespace MvcMovie.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Person> Person { get; set; }

    }
}