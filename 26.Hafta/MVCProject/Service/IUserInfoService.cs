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
        bool Insert(UserInfoDto userInfoDto);
        bool Remove(int Id);
        bool Update(UserInfoDto userInfoDto);
    }
}
