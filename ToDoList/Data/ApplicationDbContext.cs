using Microsoft.EntityFrameworkCore;

namespace ToDoList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ToDoList.Models.Task> Tasks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}