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
            return Model.NewUserInfo.ToList();
        }

        public NewUserInfo GetById(int id)
        {
            return Model.NewUserInfo.FirstOrDefault(x => x.Id == id);
        }

        public bool Insert(NewUserInfo entity)
        {
            Model.NewUserInfo.Add(entity);
            Model.SaveChanges();
            return true;
        }

        public bool Remove(NewUserInfo entity)
        {
            Model.NewUserInfo.Remove(entity);
            Model.SaveChanges();
            return true;
        }

        public bool Update(NewUserInfo entity)
        {
            Model.SaveChanges();
            return true;
        }
        public List<NewUserInfo> GetByUserName(string userName)
        {
            var newUserInfo = Model.NewUserInfo.Where(x => x.UserName == userName).ToList();
            return newUserInfo;
        }

        public List<NewUserInfo> GetUserInfoExistForId(int id)
        {
            return Model.NewUserInfo.Where(x => x.Id != id).ToList();
        }
    }
}
