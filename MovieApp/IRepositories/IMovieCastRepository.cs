using MovieApp.Models.Entities;

namespace MovieApp.Repositories
{
    public interface IMovieCastRepository : IGenericRepository<MovieCast>
    {
        public MovieCast GetByIdJoined(int id);
    }
}
