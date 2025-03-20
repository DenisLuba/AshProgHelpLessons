using Login_MAUI.Models;

namespace Login_MAUI.Services;

public interface ILoginRepository
{
    Task<UserInfo?> Login(string username, string password);
}
