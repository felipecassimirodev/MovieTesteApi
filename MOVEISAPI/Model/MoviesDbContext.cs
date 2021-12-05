using Microsoft.EntityFrameworkCore;

namespace MOVEISAPI.Model
{
    public class MoviesDbContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }


        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movie");
        }
    }
}
