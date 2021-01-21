using Microsoft.EntityFrameworkCore;
using MovieApp.Models.Entities;
using System.Linq;


namespace MovieApp.Repositories
{
    public class ProductionRepository : GenericRepository<Production>, IProductionRepository
    {
        public ProductionRepository(AppDbContext _context) : base(_context)
        {

        }
        public Production GetByIdJoined(int id)
        {
            var production = _context.Productions.Where(x => x.Id == id)
                .Include(x => x.MovieList)
                .FirstOrDefault();

            return production;
        }
    }
}
