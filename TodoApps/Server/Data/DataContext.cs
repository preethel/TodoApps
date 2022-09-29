using Microsoft.EntityFrameworkCore;

namespace TodoApps.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(
                new Todo
                {
                    Id = 1,
                    Title = "Fazar",
                    Description = "at 5 o'clock",
                    CreatedAt = DateTime.Now
                }
                );
        }
        public DbSet<Todo> Todos { get; set; }
    }
}
