using Login_MAUI.Models;
using System.Diagnostics;
using System.Net.Http.Json;

namespace Login_MAUI.Services;

public class LoginService(HttpClient client) : ILoginRepository
{
    #region Private Variables
    readonly HttpClient client = client; 
    #endregion

    #region Login Method
    public async Task<UserInfo?> Login(string _username, string _password)
    {
        try
        {
            if (Connectivity.Current.NetworkAccess is not NetworkAccess.Internet)
                return null;

            if (Application.Current?.Resources.TryGetValue("url", out object value) is not true
                || value is not string url) return null;

            UserInfo userInfo = new() { username = _username, password = _password };
            JsonContent content = JsonContent.Create(userInfo);
            using var response = await client.PostAsync(url, content);
            return await response.Content.ReadFromJsonAsync<UserInfo>();
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
        return null;
    } 
    #endregion
}
