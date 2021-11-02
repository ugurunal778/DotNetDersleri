using System.Collections.Generic;

namespace Repository
{
    public interface INewUserInfoRepository
    {
        List<NewUserInfo> GetByUserName(string userName);
        List<NewUserInfo> GetUserInfoExistForId(int id);
    }
}
