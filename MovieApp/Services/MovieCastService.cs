using MovieApp.Controllers;
using MovieApp.Models.Entities;
using MovieApp.Repositories;
using System.Collections.Generic;

namespace MovieApp.Services
{
    public class MovieCastService : IMovieCastService
    {
        private readonly IMovieCastRepository _repository;
        public MovieCastService(IMovieCastRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete(int id)
        {
            var actor = _repository.FindById(id);
            _repository.Delete(actor);
            return _repository.SaveChanges();
        }

        public List<MovieCast> GetAll()
        {
            return _repository.GetAllActive();
        }

        public MovieCast GetById(int id)
        {
            return _repository.GetByIdJoined(id);
        }

        public bool Insert(MovieCast movieCast)
        {
            _repository.Create(movieCast);
            return _repository.SaveChanges();
        }

        public bool Update(MovieCast movieCast)
        {
            _repository.Update(movieCast);
            return _repository.SaveChanges();
        }
    }
}
