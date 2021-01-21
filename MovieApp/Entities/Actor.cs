using MovieApp.Models.Base;
using System;
using System.Collections.Generic;

namespace MovieApp.Models.Entities
{
    public class Actor: BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public virtual List<MovieCast> MovieCastList { get; set; }

    }
}
