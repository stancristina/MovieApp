using MovieApp.IServices;
using MovieApp.Models.Entities;
using MovieApp.Repositories;
using System.Collections.Generic;

namespace MovieApp.Services
{
    public class MoviePremierService : IMoviePremierService
    {
        private readonly IMoviePremierRepository _repository;
        public MoviePremierService(IMoviePremierRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete(int id)
        {
            var moviePremier = _repository.FindById(id);
            _repository.Delete(moviePremier);
            return _repository.SaveChanges();
        }

        public List<MoviePremier> GetAll()
        {
            return _repository.GetAllActive();
        }

        public MoviePremier GetById(int id)
        {
            return _repository.GetByIdJoined(id);
        }

        public bool Insert(MoviePremier moviePremier)
        {
            _repository.Create(moviePremier);
            return _repository.SaveChanges();
        }

        public bool Update(MoviePremier moviePremier)
        {
            _repository.Update(moviePremier);
            return _repository.SaveChanges();
        }
    }
}