using MovieApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MovieApp.Repositories
{
    public interface IGenreRepository : IGenericRepository<Genre>
    {
        Genre GetByIdJoined(int id);
    }
}
