using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Dto;
using AutoMapper;

namespace Service
{
    public class BaseService
    {
        private UserRepository _userRepository;

        private MapperConfiguration _userToUserDtoConfig;
        private Mapper _userToUserDtoMappper;

        private MapperConfiguration _userDtoToUserConfig;
        private Mapper _userDtoToUserMappper;

        public UserRepository UserRepository
        {
            get
            {
                if (_userRepository is null)
                    _userRepository = new UserRepository();
                return _userRepository;
            }
        }
        internal Mapper UserToUserDtoMappper
        {
            get
            {
                if (_userToUserDtoConfig is null)
                    _userToUserDtoConfig = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDto>());
                if (_userToUserDtoMappper is null)
                    _userToUserDtoMappper = new Mapper(_userToUserDtoConfig);

                return _userToUserDtoMappper;
            }
        }
        internal Mapper UserDtoToUserMappper
        {
            get
            {
                if (_userDtoToUserConfig is null)
                    _userDtoToUserConfig = new MapperConfiguration(cfg => cfg.CreateMap<UserDto, User>());
                if (_userDtoToUserMappper is null)
                    _userDtoToUserMappper = new Mapper(_userDtoToUserConfig);

                return _userDtoToUserMappper;
            }
        }
    }
}
