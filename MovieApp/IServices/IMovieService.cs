using MovieApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.IServices
{
    public interface IMovieService
    {
        List<Movie> GetAll();
        Movie GetById(int id);
        bool Insert(Movie movie);
        bool Update(Movie movie);
        bool Delete(int id);
    }
}
