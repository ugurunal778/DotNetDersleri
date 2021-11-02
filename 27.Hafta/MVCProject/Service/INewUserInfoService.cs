using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    interface INewUserInfoService
    {
        NewUserInfoDto GetById(int id);
        IList<NewUserInfoDto> GetAll();
        ResponseBase<int> Insert(NewUserInfoDto userInfoDto);
        bool Remove(int Id);
        KeyValuePair<bool, string> Update(NewUserInfoDto userInfoDto);
    }
}
