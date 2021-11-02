using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IUserInfoService
    {
        UserInfoDto GetById(int id);
        IList<UserInfoDto> GetAll();
        ResponseBase<int> Insert(UserInfoDto userInfoDto);
        bool Remove(int Id);
        KeyValuePair<bool,string> Update(UserInfoDto userInfoDto);
    }
}
