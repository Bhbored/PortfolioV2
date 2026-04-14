namespace Portfolio.Contracts
{
    public interface IAdminAuthService
    {
        bool IsAuthenticated { get; }
        bool Login(string password);
        void Logout();
    }
}
