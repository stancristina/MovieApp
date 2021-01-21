using MovieApp.Models.Base;
using System;

namespace MovieApp.Models.Entities
{
    public class MoviePremier: BaseEntity
    {
        public DateTime premierDate { get; set; }

        public string premierLocation { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
