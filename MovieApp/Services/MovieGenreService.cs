using System.Collections.Generic;
using MovieApp.IRepositories;
using MovieApp.IServices;
using MovieApp.Models.Entities;

namespace MovieApp.Services
{
    public class MovieGenreService: IMovieGenreService
    {
        private readonly IMovieGenreRepository _repository;
        public MovieGenreService(IMovieGenreRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete(int id)
        {
            var genre = _repository.FindById(id);
            _repository.Delete(genre);
            return _repository.SaveChanges();
        }

        public List<MovieGenre> GetAll()
        {
            return _repository.GetAllActive();
        }

        public MovieGenre GetById(int id)
        {
            return _repository.GetByIdJoined(id);
        }

        public bool Insert(MovieGenre genre)
        {
            _repository.Create(genre);
            return _repository.SaveChanges();
        }

        public bool Update(MovieGenre genre)
        {
            _repository.Update(genre);
            return _repository.SaveChanges();
        }
    }
}

