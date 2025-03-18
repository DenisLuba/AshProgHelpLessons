using System.Net.Http.Json;
using UsersFromWeb_LoginPage_MAUI.Models;

namespace UsersFromWeb_LoginPage_MAUI.Services;

public class LoginService : ILoginRepository
{
    const string URL = "https://dummyjson.com/user/login";
    static HttpClient? httpClient;

    public async Task<UserInfo?> Login(string userName, string password)
    {
        if (httpClient is null) httpClient = new HttpClient();
        
        UserInfo user = new() { username = "", password = "" };
        JsonContent json = JsonContent.Create(user);
        using HttpResponseMessage response = await httpClient.PostAsync(URL, json);
        return await response.Content.ReadFromJsonAsync<UserInfo>();
    }
}
