using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class NewUserInfoRepository : BaseRepository, IRepository<NewUserInfo>, INewUserInfoRepository
    {
        public IEnumerable<NewUserInfo> GetAll()
        {
            return Model1.NewUserInfo.ToList();
        }

        public NewUserInfo GetByID(int id)
        {
            return Model1.NewUserInfo.FirstOrDefault(x => x.Id == id);
        }

        public List<NewUserInfo> GetByUserName(string userName)
        {
            var newUserInfo = Model1.NewUserInfo.Where(x => x.UserName == userName).ToList();
            return newUserInfo;
        }

        public List<NewUserInfo> GetUserInfoExistForId(int id)
        {
            return Model1.NewUserInfo.Where(x => x.Id != id).ToList();
        }

        public bool Insert(NewUserInfo entity)
        {
            Model1.NewUserInfo.Add(entity);
            Model1.SaveChanges();
            return true;
        }

        public bool Remove(NewUserInfo entity)
        {
            Model1.NewUserInfo.Remove(entity);
            Model1.SaveChanges();
            return true;
        }

        public bool Update(NewUserInfo entity)
        {
            Model1.SaveChanges();
            return true;
        }
    }
}
