﻿using Dto;
using WcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WcfService : BaseWcfService, IWcfService
    {
        public IList<UserDto> GetAllUser()
        {
            var result = UserService.GetAllUser();
            return result;
        }

        public UserDto GetByIdUser(int id)
        {
            var result = UserService.GetByIdUser(id);
            return result;
        }

        public bool InsertUser(UserDto userInfoDto)
        {
            var result = UserService.InsertUser(userInfoDto);
            return result;
        }

        public bool RemoveUser(int id)
        {
            var result = UserService.RemoveUser(id);
            return result;
        }

        public bool UpdateUser(UserDto userInfoDto)
        {
            var result = UserService.UpdateUser(userInfoDto);
            return result;
        }
    }
}
