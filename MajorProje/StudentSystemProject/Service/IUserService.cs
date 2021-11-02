using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Service
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        UserDto GetByIdUser(int id);
        [OperationContract]
        IList<UserDto> GetAllUser();
        [OperationContract]
        bool InsertUser(UserDto userDto);
        [OperationContract]
        bool RemoveUser(int id);
        [OperationContract]
        bool UpdateUser(UserDto userDto);
    }
}
