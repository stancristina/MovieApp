using MovieApp.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApp.Models.Entities
{
    public class MovieGenre : BaseEntity
    {
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }
        public int GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}
