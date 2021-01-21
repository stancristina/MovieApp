using MovieApp.Models.Base;

namespace MovieApp.Models.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
    }
}
