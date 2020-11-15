using MovieApp.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApp.Models.Entities
{
    public class MovieGenre
    {
        public Guid MovieId { get; set; }

        public Movie Movie { get; set; }
        public Guid GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}
