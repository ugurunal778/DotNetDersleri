using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Service;

namespace WcfService
{
    public class BaseWcfService
    {
        private UserService _userService;

        public UserService UserService
        {
            get
            {
                if (_userService is null)
                {
                    _userService = new UserService();
                }
                return _userService;
            }
        }
    }
}