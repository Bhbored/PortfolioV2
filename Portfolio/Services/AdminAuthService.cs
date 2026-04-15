using Portfolio.Contracts;

namespace Portfolio.Services
{
    public class AdminAuthService : IAdminAuthService
    {
        private readonly string? _adminPassword;

        public bool IsAuthenticated { get; private set; }
        private readonly IConfiguration _configuration;
        public AdminAuthService(IConfiguration configuration)
        {
            _configuration = configuration;
            _adminPassword = _configuration["ADMIN_KEY"];
        }

        public bool Login(string password)
        {
            if (string.IsNullOrEmpty(_adminPassword))
                return false;

            if (password.ToLower() == _adminPassword?.ToLower())
            {
                IsAuthenticated = true;
                return true;
            }

            return false;
        }

        public void Logout()
        {
            IsAuthenticated = false;
        }
    }
}
