using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Enums;
using MovieApp.Helpers;
using MovieApp.IServices;
using MovieApp.Models.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _service;
        public MovieController(IMovieService service)
        {
            this._service = service;
        }

        [HttpGet("all")]
        [Authorize]
        public IActionResult GetAll()
        {
            System.Console.WriteLine("intrat");
            var response = _service.GetAll();
            System.Console.WriteLine(response);
            return Ok(response);
        }

        [HttpGet("{id}")]
        [Authorize]
        public IActionResult Get(int id)
        {
            var response = _service.GetById(id);
            return Ok(response);
        }

        [HttpPost("update")]
        [Authorize]
        public IActionResult Update(Movie movie)
        {
            if (!UserIsInRole(UserTypeEnum.Admin))
                return Unauthorized("You are not in role to permit this action");

            _service.Update(movie);
            return Ok(movie);
        }

        [HttpPost("create")]
        [Authorize]
        public IActionResult Create(Movie movie)
        {
            if (!UserIsInRole(UserTypeEnum.Admin))
                return Unauthorized("You are not in role to permit this action");

            _service.Insert(movie);
            return Ok(movie);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete(int id)
        {
            if (!UserIsInRole(UserTypeEnum.Admin))
                return Unauthorized("You are not in role to permit this action");

            _service.Delete(id);
            return Ok();
        }

        private bool UserIsInRole(params UserTypeEnum[] roles)
        {
            var user = GetUserFromContext();
            return roles.Select(x => x.ToString()).Contains(user.Type);
        }

        private User GetUserFromContext() =>
            (User)HttpContext.Items["User"];
    }
}