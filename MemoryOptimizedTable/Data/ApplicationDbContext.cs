using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MemoryOptimizedTable.Data
{
    public class Test
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }


        protected override void OnModelCreating(ModelBuilder builder) {

            builder.Entity<Test>().IsMemoryOptimized(true);

            builder.Entity<Test>().HasData(
                new Test { Id = 1, Name = "test" }, 
                new Test { Id = 2, Name = "test1" },
                new Test { Id = 3, Name = "test2" }
                );

            base.OnModelCreating(builder);
        }
        public DbSet<Test> Tests { get; set; }
    }
}
