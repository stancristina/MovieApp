using MovieApp.Models.Entities;


namespace MovieApp.Repositories
{
    public interface IActorRepository : IGenericRepository<Actor>
    {
        Actor GetByIdJoined(int id);
    }
}
