using MovieApp.Models.Base;
using System.Collections.Generic;

namespace MovieApp.Models.Entities
{
    public class Genre : BaseEntity
    {
        public string Type { get; set; }

        public ICollection<MovieGenre> MovieGenreList { get; set; }
    }
}
