using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Dto;
using Repository;

namespace Service
{
    public class UserService : BaseService, IUserService
    {
        public IList<UserDto> GetAllUser()
        {
            var result = UserRepository.GetAll();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDto>());
            var mapper = new Mapper(config);

            var userDto = mapper.Map<List<UserDto>>(result);

            return userDto;
        }

        public UserDto GetByIdUser(int id)
        {
            var result = UserRepository.GetById(id);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDto>());
            var mapper = new Mapper(config);

            var userDto = mapper.Map<UserDto>(result);

            return userDto;
        }

        public bool InsertUser(UserDto userDto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserDto, User>());
            var mapper = new Mapper(config);
            var user = mapper.Map<User>(userDto);

            var result = UserRepository.Insert(user);
            return result;
        }

        public bool RemoveUser(int id)
        {
            var deletedItem = UserRepository.GetById(id);
            var result = UserRepository.Remove(deletedItem);
            return result;
        }

        public bool UpdateUser(UserDto userDto)
        {
            var updatedModel = UserRepository.GetById(userDto.Id);
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<UserDto, User>());
            //var mapper = new Mapper(config);
            //var mappedModel = mapper.Map(userDto, updatedModel);
            updatedModel.Firstname = userDto.Firstname;
            updatedModel.Surname = userDto.Surname;
            updatedModel.Adress = userDto.Adress;
            updatedModel.TCKN = userDto.TCKN;
            updatedModel.PersonId = userDto.PersonId;
            updatedModel.EMail = userDto.EMail;
            updatedModel.BloodType = userDto.BloodType;
            updatedModel.RegisterDate = DateTime.Now;
            updatedModel.IsActive = userDto.IsActive;


            var result = UserRepository.Update(updatedModel);
            return result;
        }
    }
}
