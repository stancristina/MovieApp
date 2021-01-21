using MovieApp.Models.Entities;
using System.Collections.Generic;

namespace MovieApp.Controllers
{
    public interface IMovieCastService 
    
        {
            List<MovieCast> GetAll();
            MovieCast GetById(int id);
            bool Insert(MovieCast movieCast);
            bool Update(MovieCast movieCast);
            bool Delete(int id);
        }
 }