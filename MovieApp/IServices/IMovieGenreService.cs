using System.Collections.Generic;
using MovieApp.Models.Entities;

namespace MovieApp.IServices
{
    public interface IMovieGenreService 
    {
        List<MovieGenre> GetAll();
        MovieGenre GetById(int id);
        bool Insert(MovieGenre genre);
        bool Update(MovieGenre genre);
        bool Delete(int id);
    }
}
