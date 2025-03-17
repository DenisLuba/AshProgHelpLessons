using UsersFromWeb_LoginPage_MAUI.Models;

namespace UsersFromWeb_LoginPage_MAUI.Services;

public interface ILoginRepository
{
    Task<UserInfo?> Login(string userName, string password);
}
