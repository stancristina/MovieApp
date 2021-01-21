using MovieApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.IServices
{
    public interface IMoviePremierService
    {
        List<MoviePremier> GetAll();
        MoviePremier GetById(int id);
        bool Insert(MoviePremier moviePremier);
        bool Update(MoviePremier moviePremier);
        bool Delete(int id);
    }
}
