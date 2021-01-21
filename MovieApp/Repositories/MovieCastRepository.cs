using Microsoft.EntityFrameworkCore;
using MovieApp.Models.Entities;
using System.Linq;

namespace MovieApp.Repositories
{
    public class MovieCastRepository : GenericRepository<MovieCast>, IMovieCastRepository
    {
        public MovieCastRepository(AppDbContext _context) : base(_context)
        {

        }
        public MovieCast GetByIdJoined(int id)
        {
            var movieCast = _context.MovieCasts.Where(x => x.Id == id)
                .Include(x => x.Movie)
                .Include(x => x.Actor)
                .FirstOrDefault();

            return movieCast;
        }
    }
}
