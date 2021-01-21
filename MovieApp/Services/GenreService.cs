using MovieApp.IServices;
using MovieApp.Models.Entities;
using MovieApp.Repositories;
using System.Collections.Generic;

namespace MovieApp.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _repository;
        public GenreService(IGenreRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete(int id)
        {
            var genre = _repository.FindById(id);
            _repository.Delete(genre);
            return _repository.SaveChanges();
        }

        public List<Genre> GetAll()
        {
            return _repository.GetAllActive();
        }

        public Genre GetById(int id)
        {
            return _repository.GetByIdJoined(id);
        }

        public bool Insert(Genre genre)
        {
            _repository.Create(genre);
            return _repository.SaveChanges();
        }

        public bool Update(Genre genre)
        {
            _repository.Update(genre);
            return _repository.SaveChanges();
        }
    }
}
