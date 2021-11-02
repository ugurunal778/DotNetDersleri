using Service;

namespace WCFServiceApp
{
    public class BaseMvcSampleWcf
    {
        private UserInfoService _userInfoService;
        private RoleService _roleService;
        private UserRoleService _userRoleService;
        private UserAuthenticationService _userAuthenticationService;

        public UserAuthenticationService UserAuthenticationService
        {
            get
            {
                if (_userAuthenticationService is null)
                {
                    _userAuthenticationService = new UserAuthenticationService();
                }
                return _userAuthenticationService;
            }
        }
        public UserRoleService UserRoleService
        {
            get
            {
                if (_userRoleService is null)
                {
                    _userRoleService = new UserRoleService();
                }
                return _userRoleService;
            }
        }

        public UserInfoService UserInfoService
        {
            get
            {
                if (_userInfoService is null)
                {
                    _userInfoService = new UserInfoService();
                }
                return _userInfoService;
            }
        }
        public RoleService RoleService
        {
            get
            {
                if (_roleService is null)
                {
                    _roleService = new RoleService();
                }
                return _roleService;
            }
        }
    }
}