using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RoleRepository : BaseRepository, IRepository<Role>, IRoleRepository
    {
        public IEnumerable<Role> GetAll()
        {
            return Model1.Role.ToList();
        }

        public Role GetByID(int id)
        {
            return Model1.Role.FirstOrDefault(x => x.Id == id);
        }

        public bool Insert(Role entity)
        {
            Model1.Role.Add(entity);
            Model1.SaveChanges();
            return true;
        }

        public bool Remove(Role entity)
        {
            Model1.Role.Remove(entity);
            Model1.SaveChanges();
            return true;
        }

        public bool Update(Role entity)
        {
            Model1.SaveChanges();
            return true;
        }
    }
}
