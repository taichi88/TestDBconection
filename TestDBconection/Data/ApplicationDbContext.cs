using Microsoft.EntityFrameworkCore;
using TestDBconection.Models;


namespace TestDBconection.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

        {

        }

        public DbSet<BooksModel> BooksModelTable { get; set; }


        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BooksModel>().HasData(
                new BooksModel { Id = 1, date = DateTime.Now, Description = "sdad", Name = "sdawqe" }

                );
        }*/

    }
}
