using System.Linq;
using Microsoft.EntityFrameworkCore;
using MovieApp.IRepositories;
using MovieApp.Models.Entities;

namespace MovieApp.Repositories
{
    public class MovieGenreRepository: GenericRepository<MovieGenre>, IMovieGenreRepository
    {
        public MovieGenreRepository(AppDbContext _context) : base(_context)
        {

        }
        public MovieGenre GetByIdJoined(int id)
        {
            var genre = _context.MovieGenres.Where(x => x.Id == id)
                .Include(x => x.Genre)
                .FirstOrDefault();

            return genre;
        }
    }
}

