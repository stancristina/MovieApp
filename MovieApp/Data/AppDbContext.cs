using Microsoft.EntityFrameworkCore;
using MovieApp.Models.Entities;

namespace MovieApp
{
    public class AppDbContext : DbContext
    {
        /* Many-to-many relations */
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<MovieCast> MovieCasts { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<MovieGenre> MovieGenres { get; set; }

        /* One-to-many relation*/
        public DbSet<Production> Productions { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            /* One-to-many relation*/
            builder.Entity<Production>()
                .HasMany(x => x.MovieList)
                .WithOne(y => y.Production);

            /* Many-to-many relations*/
            builder.Entity<MovieGenre>()
                .HasKey(mg => new { mg.MovieId, mg.GenreId });

            builder.Entity<MovieGenre>()
                .HasOne<Movie>(x => x.Movie)
                .WithMany(y => y.MovieGenreList)
                .HasForeignKey(z => z.MovieId);

            builder.Entity<MovieGenre>()
                .HasOne<Genre>(x => x.Genre)
                .WithMany(y => y.MovieGenreList)
                .HasForeignKey(z => z.GenreId);

            builder.Entity<MovieCast>()
                .HasKey(mg => new { mg.MovieId, mg.ActorId });

            builder.Entity<MovieCast>()
                .HasOne<Movie>(x => x.Movie)
                .WithMany(y => y.MovieCastList)
                .HasForeignKey(z => z.MovieId);

            builder.Entity<MovieCast>()
                .HasOne<Actor>(x => x.Actor)
                .WithMany(y => y.MovieCastList)
                .HasForeignKey(z => z.ActorId);

            base.OnModelCreating(builder);
        }

    }
}
