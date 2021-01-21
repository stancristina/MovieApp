using MovieApp.IServices;
using MovieApp.Models.Entities;
using MovieApp.Repositories;
using System.Collections.Generic;

namespace MovieApp.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repository;
        public MovieService(IMovieRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete(int id)
        {
            var movie = _repository.FindById(id);
            _repository.Delete(movie);
            return _repository.SaveChanges();
        }

        public List<Movie> GetAll()
        {
            return _repository.GetAllActive();
        }

        public Movie GetById(int id)
        {
            return _repository.GetByIdJoined(id);
        }

        public bool Insert(Movie movie)
        {
            _repository.Create(movie);
            return _repository.SaveChanges();
        }

        public bool Update(Movie movie)
        {
            _repository.Update(movie);
            return _repository.SaveChanges();
        }
    }
}
