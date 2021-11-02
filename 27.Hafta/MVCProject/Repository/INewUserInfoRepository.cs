using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface INewUserInfoRepository
    {
        List<NewUserInfo> GetByUserName(string userName);
        List<NewUserInfo> GetUserInfoExistForId(int id);
    }
}
