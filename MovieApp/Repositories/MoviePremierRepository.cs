using MovieApp.Models.Entities;
using System.Linq;

namespace MovieApp.Repositories
{
    public class MoviePremierRepository : GenericRepository<MoviePremier>, IMoviePremierRepository
    {
        public MoviePremierRepository(AppDbContext _context) : base(_context)
        {

        }

        public MoviePremier GetByIdJoined(int id)
        {
            return _context.MoviePremiers.Where(x => x.Id == id)
                .FirstOrDefault();
        }
    }
}

