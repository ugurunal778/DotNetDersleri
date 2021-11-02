namespace Service
{
    public interface IUserAuthenticationService
    {
        bool CheckUserNamePassword(string userName, string password);
    }
}
