using AutoMapper;
using DTO;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
    public class UserInfoService : BaseService, IUserInfoService
    {
        public IList<UserInfoDto> GetAll()
        {
            var result = UserInfoRepository.GetAll();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserInfo, UserInfoDto>());
            var mapper = new Mapper(config);

            var userInfoDto = mapper.Map<List<UserInfoDto>>(result);

            return userInfoDto;
        }

        public UserInfoDto GetById(int id)
        {
            var result = UserInfoRepository.GetById(id);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserInfo, UserInfoDto>());
            var mapper = new Mapper(config);

            var userInfoDto = mapper.Map<UserInfoDto>(result);

            return userInfoDto;
        }

        public bool Insert(UserInfoDto userInfoDto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserInfoDto, UserInfo>());
            var mapper = new Mapper(config);
            var userInfo = mapper.Map<UserInfo>(userInfoDto);

            var result = UserInfoRepository.Insert(userInfo);
            return result;
        }

        public bool Remove(int Id)
        {
            var deletedItem = UserInfoRepository.GetById(Id);
            var result = UserInfoRepository.Remove(deletedItem);
            return result;
        }

        public bool Update(UserInfoDto userInfoDto)
        {
            var updatedModel = UserInfoRepository.GetById(userInfoDto.Id);
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<UserInfoDto, UserInfo>());
            //var mapper = new Mapper(config);
            //var mappedModel = mapper.Map(userInfoDto, updatedModel);
            updatedModel.FirstName = userInfoDto.FirstName;
            updatedModel.LastName = userInfoDto.LastName;
            updatedModel.Password = userInfoDto.Password;
            updatedModel.UserName = userInfoDto.UserName;
            updatedModel.ModifiedDate = DateTime.Now;


            var result = UserInfoRepository.Update(updatedModel);
            return result;
        }
    }
}
