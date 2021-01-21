using MovieApp.Models.Entities;
using System.Linq;

namespace MovieApp.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public User GetByUserAndPassword(string username, string password)
        {
            return _table.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
        }
    }
}
