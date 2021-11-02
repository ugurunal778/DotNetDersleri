using AutoMapper;
using DTO;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BaseService
    {
        private NewUserInfoRepository _newUserInfoRepository;
        private UserRoleRepository _userRoleRepository;
        private RoleRepository _roleRepository;
        private MapperConfiguration _newUserInfoToUserInfoDtoConfig;
        private Mapper _newUserInfoToUserInfoDtoMapper;

        private MapperConfiguration _newUserInfoDtoToUserInfoConfig;
        private Mapper _newUserInfoDtoToUserInfoMapper;

        internal Mapper NewUserInfoToUserInfoDtoMapper
        {
            get
            {
                if (_newUserInfoToUserInfoDtoConfig is null)
                    _newUserInfoToUserInfoDtoConfig = new MapperConfiguration(cfg => cfg.CreateMap<NewUserInfo, NewUserInfoDto>());
                if (_newUserInfoToUserInfoDtoMapper is null)
                    _newUserInfoToUserInfoDtoMapper = new Mapper(_newUserInfoToUserInfoDtoConfig);

                return _newUserInfoToUserInfoDtoMapper;
            }
        }
        internal Mapper NewUserInfoDtoToUserInfoMapper
        {
            get
            {
                if (_newUserInfoDtoToUserInfoConfig is null)
                    _newUserInfoDtoToUserInfoConfig = new MapperConfiguration(cfg => cfg.CreateMap<NewUserInfoDto, NewUserInfo>());
                if (_newUserInfoDtoToUserInfoMapper is null)
                    _newUserInfoDtoToUserInfoMapper = new Mapper(_newUserInfoDtoToUserInfoConfig);

                return _newUserInfoDtoToUserInfoMapper;
            }
        }
        internal NewUserInfoRepository NewUserInfoRepository
        {
            get
            {
                if (_newUserInfoRepository is null)
                    _newUserInfoRepository = new NewUserInfoRepository();

                return _newUserInfoRepository;
            }
        }
        //----------------------------------------------------------------------------mapper eklenebilir
        internal UserRoleRepository UserRoleRepository
        {
            get
            {
                if (_userRoleRepository is null)
                    _userRoleRepository = new UserRoleRepository();

                return _userRoleRepository;
            }
        }
        //----------------------------------------------------------------------------mapper eklenebilir
        internal RoleRepository RoleRepository
        {
            get
            {
                if (_roleRepository is null)
                    _roleRepository= new RoleRepository();
                
                return _roleRepository;
            }
        }
    }
}
