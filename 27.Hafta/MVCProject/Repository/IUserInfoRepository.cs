﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUserInfoRepository
    {
        List<UserInfo> GetByUserName(string userName);
        List<UserInfo> GetUserInfoExistForId(int id);
    }
}
