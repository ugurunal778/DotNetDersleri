using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public partial class UserRepository : BaseRepository, IRepository<User>, IUserRepository
    {
        public IEnumerable<User> GetAll()
        {
            return Model.User.ToList();
        }

        public User GetById(int id)
        {
            return Model.User.FirstOrDefault(x => x.Id == id);
        }


        public bool Insert(User entity)
        {
            Model.User.Add(entity);
            Model.SaveChanges();
            return true;
        }

        public bool Remove(User entity)
        {
            Model.User.Remove(entity);
            Model.SaveChanges();
            return true;
        }

        public bool Update(User entity)
        {
            Model.SaveChanges();
            return true;
        }
    }
}
