using DTO;
using System.Collections.Generic;

namespace Service
{
    interface INewUserInfoService
    {
        NewUserInfoDto GetById(int id);
        IList<NewUserInfoDto> GetAll();
        ResponseBase<int> Insert(NewUserInfoDto newUserInfoDto);
        bool Remove(int Id);
        KeyValuePair<bool, string> Update(NewUserInfoDto newUserInfoDto);
    }
}