using MovieApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetByUserAndPassword(string username, string password);
    }
}
