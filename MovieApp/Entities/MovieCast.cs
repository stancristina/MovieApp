using MovieApp.Models.Base;
using System;

namespace MovieApp.Models.Entities
{
    public class MovieCast : BaseEntity
    {
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }

        public int ActorId { get; set; }

        public virtual Actor Actor { get; set; }

        public string Role { get; set; }

        public int Revenue { get; set; }
    }
}
