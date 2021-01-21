using Microsoft.EntityFrameworkCore;
using MovieApp.Models.Entities;
using System.Linq;

namespace MovieApp.Repositories
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(AppDbContext _context) : base(_context)
        {

        }
        public Actor GetByIdJoined(int id)
        {
            var actor = _context.Actors.Where(x => x.Id == id)
                .Include(x => x.MovieCastList)
                .FirstOrDefault();

            return actor;
        }
    }
}
