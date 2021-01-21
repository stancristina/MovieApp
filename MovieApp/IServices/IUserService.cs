using MovieApp.Models;
using MovieApp.Models.Entities;
using System.Collections.Generic;

namespace MovieApp.Services
{
    public interface IUserService
    {
        User GetById(int id);
        List<User> GetAll();
        bool Register(AuthenticationRequest request);
        AuthenticationResponse Login(AuthenticationRequest request);
    }
}
