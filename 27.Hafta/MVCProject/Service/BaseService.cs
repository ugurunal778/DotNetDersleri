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
        private UserInfoRepository _userInfoRepository;
        private MapperConfiguration _userInfoToUserInfoDtoConfig;
        private Mapper _userInfoToUserInfoDtoMappper;

        private MapperConfiguration _userInfoDtoToUserInfoConfig;
        private Mapper _userInfoDtoToUserInfoMappper;

        internal Mapper UserInfoToUserInfoDtoMapper
        {
            get
            {
                if (_userInfoToUserInfoDtoConfig is null)
                    _userInfoToUserInfoDtoConfig = new MapperConfiguration(cfg => cfg.CreateMap<UserInfo, UserInfoDto>());
                if (_userInfoToUserInfoDtoMappper is null)
                    _userInfoToUserInfoDtoMappper = new Mapper(_userInfoToUserInfoDtoConfig);

                return _userInfoToUserInfoDtoMappper;
            }
        }
        internal Mapper UserInfoDtoToUserInfoMapper
        {
            get
            {
                if (_userInfoDtoToUserInfoConfig is null)
                    _userInfoDtoToUserInfoConfig = new MapperConfiguration(cfg => cfg.CreateMap<UserInfoDto, UserInfo>());
                if (_userInfoDtoToUserInfoMappper is null)
                    _userInfoDtoToUserInfoMappper = new Mapper(_userInfoDtoToUserInfoConfig);

                return _userInfoDtoToUserInfoMappper;
            }
        }

        internal UserInfoRepository UserInfoRepository
        {
            get
            {
                if (_userInfoRepository is null)
                    _userInfoRepository = new UserInfoRepository();

                return _userInfoRepository;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------
        private NewUserInfoRepository _newUserInfoRepository;
        private MapperConfiguration _newUserInfoToUserInfoDtoConfig;
        private Mapper _newUserInfoToUserInfoDtoMappper;

        private MapperConfiguration _newUserInfoDtoToUserInfoConfig;
        private Mapper _newUserInfoDtoToUserInfoMappper;

        internal Mapper NewUserInfoToUserInfoDtoMapper
        {
            get
            {
                if (_newUserInfoToUserInfoDtoConfig is null)
                    _newUserInfoToUserInfoDtoConfig = new MapperConfiguration(cfg => cfg.CreateMap<NewUserInfo, NewUserInfoDto>());
                if (_newUserInfoToUserInfoDtoMappper is null)
                    _newUserInfoToUserInfoDtoMappper = new Mapper(_newUserInfoToUserInfoDtoConfig);

                return _newUserInfoToUserInfoDtoMappper;
            }
        }
        internal Mapper NewUserInfoDtoToUserInfoMapper
        {
            get
            {
                if (_newUserInfoDtoToUserInfoConfig is null)
                    _newUserInfoDtoToUserInfoConfig = new MapperConfiguration(cfg => cfg.CreateMap<NewUserInfoDto, NewUserInfo>());
                if (_newUserInfoDtoToUserInfoMappper is null)
                    _newUserInfoDtoToUserInfoMappper = new Mapper(_newUserInfoDtoToUserInfoConfig);

                return _newUserInfoDtoToUserInfoMappper;
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
    }
}