using MovieApp.Models.Base;
using System;
using System.Collections.Generic;

namespace MovieApp.Models.Entities
{
    public class Movie: BaseEntity
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int Revenue { get; set; }

        public Production Production { get; set; }

        public Guid ProductionId { get; set; }

        public ICollection<MovieGenre> MovieGenreList { get; set; }

        public ICollection<MovieCast> MovieCastList { get; set; }

    }
}
