using MovieApp.Models.Entities;
using MovieApp.Repositories;


namespace MovieApp.Repositories
{
    public interface IMovieRepository : IGenericRepository<Movie>
    {
        Movie GetByIdJoined(int id);
    }
}
