using System;

namespace MovieApp.Models.Entities
{
    public class MovieCast
    {
        public Guid MovieId { get; set; }

        public Movie Movie { get; set; }

        public Guid ActorId { get; set; }

        public Actor Actor { get; set; }

        public string Role { get; set; }

        public int Revenue { get; set; }
    }
}
