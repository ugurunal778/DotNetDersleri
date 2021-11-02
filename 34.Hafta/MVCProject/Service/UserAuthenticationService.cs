namespace Service
{
    public class UserAuthenticationService : IUserAuthenticationService
    {
        public bool CheckUserNamePassword(string userName, string password)
        {
            return true;
        }
    }
}
