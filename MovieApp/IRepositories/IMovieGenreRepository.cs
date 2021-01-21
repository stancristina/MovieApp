using MovieApp.Models.Entities;
using MovieApp.Repositories;

namespace MovieApp.IRepositories
{
    public interface IMovieGenreRepository : IGenericRepository<MovieGenre>
    {
        public MovieGenre GetByIdJoined(int id);
    }
}
