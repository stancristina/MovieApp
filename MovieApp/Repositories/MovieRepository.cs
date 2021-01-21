using Microsoft.EntityFrameworkCore;
using MovieApp.Models.Entities;
using System.Linq;

namespace MovieApp.Repositories
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(AppDbContext _context) : base(_context)
        {

        }
        public Movie GetByIdJoined(int id)
        {
            var movie = _context.Movies.Where(x => x.Id == id)
                .Include(x => x.MovieGenreList)
                .Include(x => x.MovieCastList)
                .FirstOrDefault();


            return movie;
        }

        internal interface IMoviePremierRepository
        {
        }
    }
}
