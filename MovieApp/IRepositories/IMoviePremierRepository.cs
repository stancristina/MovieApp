using MovieApp.Models.Entities;


namespace MovieApp.Repositories
{
    public interface IMoviePremierRepository : IGenericRepository<MoviePremier>
    {
        MoviePremier GetByIdJoined(int id);
    }
}
