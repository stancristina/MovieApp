using MovieApp.Models.Base;
using System.Collections.Generic;

namespace MovieApp.Models.Entities
{
    public class Production : BaseEntity
    {
        public string Name { get; set; }

        public virtual List<Movie> MovieList { get; set; }

    }
}
