using MovieApp.Models.Entities;
using System.Collections.Generic;

namespace MovieApp.IServices
{
    public interface IActorService
    {
        List<Actor> GetAll();
        Actor GetById(int id);
        bool Insert(Actor actor);
        bool Update(Actor actor);
        bool Delete(int id);
    }
}
