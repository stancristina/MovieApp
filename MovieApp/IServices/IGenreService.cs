using MovieApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.IServices
{
    public interface IGenreService
    {
        List<Genre> GetAll();
        Genre GetById(int id);
        bool Insert(Genre genre);
        bool Update(Genre grof);
        bool Delete(int id);
    }
}
