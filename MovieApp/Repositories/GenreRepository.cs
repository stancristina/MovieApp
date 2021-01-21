using Microsoft.EntityFrameworkCore;
using MovieApp.Models.Entities;
using System.Linq;

namespace MovieApp.Repositories
{
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        public GenreRepository(AppDbContext _context) : base(_context)
        {

        }
        public Genre GetByIdJoined(int id)
        {
            var genre = _context.Genres.Where(x => x.Id == id)
                .Include(x => x.MovieGenreList)
                .FirstOrDefault();

            return genre;
        }
    }
}
