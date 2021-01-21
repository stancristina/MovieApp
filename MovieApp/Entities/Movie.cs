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

        public virtual Production Production { get; set; }

        public int ProductionId { get; set; }

        public virtual MoviePremier MoviePremier { get; set; }

        public int MoviePremierId { get; set; }

        public virtual List<MovieGenre> MovieGenreList { get; set; }

        public virtual List<MovieCast> MovieCastList { get; set; }

    }
}
