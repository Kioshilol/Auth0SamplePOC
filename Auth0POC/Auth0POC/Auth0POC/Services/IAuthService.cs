using System.Threading.Tasks;

namespace Auth0POC.Services
{
    public interface IAuthService
    {
        Task Login(string connectionName);
        Task Logout();
    }
}
