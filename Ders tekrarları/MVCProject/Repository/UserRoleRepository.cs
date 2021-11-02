using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRoleRepository : BaseRepository, IRepository<UserRole>, IUserRoleRepository
    {
        public IEnumerable<UserRole> GetAll()
        {
            return Model1.UserRole.ToList();
        }

        public UserRole GetByID(int id)
        {
            return Model1.UserRole.FirstOrDefault(x => x.ID == id);
        }

        public bool Insert(UserRole entity)
        {
            Model1.UserRole.Add(entity);
            Model1.SaveChanges();
            return true;
        }

        public bool Remove(UserRole entity)
        {
            Model1.UserRole.Remove(entity);
            Model1.SaveChanges();
            return true;
        }

        public bool Update(UserRole entity)
        {
            Model1.SaveChanges();
            return true;
        }
    }
}