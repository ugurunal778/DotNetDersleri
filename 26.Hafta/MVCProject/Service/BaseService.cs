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

        public UserInfoRepository UserInfoRepository
        {
            get
            {
                if (_userInfoRepository is null)
                    _userInfoRepository = new UserInfoRepository();
                return _userInfoRepository;

            }
        }
    }
}

