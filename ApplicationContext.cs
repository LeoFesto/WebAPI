namespace WebAPI
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;

    public class ApplicationContext : DbContext
    {
        public DbSet<Entity> Entities { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
