using DTO;
using System.Collections.Generic;
using System.ServiceModel;

namespace Service
{
    [ServiceContract]
    public interface IUserInfoService
    {
        [OperationContract]
        UserInfoDto GetUserInfoById(int id);
        [OperationContract]
        IList<UserInfoDto> GetUserInfoAll(string userName, string password);
        [OperationContract]
        ResponseBase<bool> InsertUserInfo(UserInfoDto userInfoDto);
        [OperationContract]
        bool RemoveUserInfo(int Id);
        [OperationContract]
        bool UpdateUserInfo(UserInfoDto userInfoDto);
    }
}
