using e_movies.Models;
using Microsoft.EntityFrameworkCore;

namespace e_movies.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { 
        
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_MovieModel>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId,
               
            }
            );

            modelBuilder.Entity<Actor_MovieModel>().HasOne(m => m.Movie).WithMany(am=> am.Actor_movies).HasForeignKey(m=>m.MovieId);
            modelBuilder.Entity<Actor_MovieModel>().HasOne(m => m.Actor).WithMany(am => am.Actor_movies).HasForeignKey(m => m.ActorId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ActorModel> Actors { get; set; }
        public DbSet<MovieModel> Movies { get; set;}

        public DbSet<Actor_MovieModel> Actor_Movie { get; set; }
        public DbSet<ProducerModel> Producers { get; set; }
        public DbSet<CinemaModel> Cinemas { get; set; }


    }
}
