using AutoMapper;
using DTO;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
    public partial class UserInfoService : BaseService, IUserInfoService
    {
        public IList<UserInfoDto> GetAll()
        {
            var result = UserInfoRepository.GetAll();
            var userInfoDto = UserInfoToUserInfoDtoMapper.Map<List<UserInfoDto>>(result);
            return userInfoDto;
        }

        public UserInfoDto GetById(int id)
        {
            var result = UserInfoRepository.GetById(id);

            var userInfoDto = UserInfoToUserInfoDtoMapper.Map<UserInfoDto>(result);

            return userInfoDto;
        }

        public ResponseBase<int> Insert(UserInfoDto userInfoDto)
        {
            var response = new ResponseBase<int>();
            response.Success(1);
            var validationResult = SameUserNameValidation(userInfoDto.UserName); 

            if (validationResult.Key)
            {
                var userInfo = UserInfoDtoToUserInfoMapper.Map<UserInfo>(userInfoDto);
                UserInfoRepository.Insert(userInfo);
            }
            else
            {
                response.Error();
            }
            return response;
        }

        public bool Remove(int Id)
        {
            var deletedItem = UserInfoRepository.GetById(Id);
            var result = UserInfoRepository.Remove(deletedItem);
            return result;
        }

        public KeyValuePair<bool,string> Update(UserInfoDto userInfoDto)
        {
            var response = new ResponseBase<int>();
            response.Success(1);
            var validationResult = UpdateValidation(userInfoDto.Id, userInfoDto.UserName);

            if (validationResult.Key)
            {
                var updatedModel = UserInfoRepository.GetById(userInfoDto.Id);
                updatedModel.FirstName = userInfoDto.FirstName;
                updatedModel.LastName = userInfoDto.LastName;
                updatedModel.Password = userInfoDto.Password;
                updatedModel.UserName = userInfoDto.UserName;
                updatedModel.ModifiedDate = DateTime.Now;


                var result = UserInfoRepository.Update(updatedModel);
            }
            return validationResult;
        }
    }
}
