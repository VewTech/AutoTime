using Library;
using Library.Schemas;
using System.Net.Http.Json;

namespace Web.Core.Services
{
    public class IntratimeService : IIntratimeService
    {
        public async Task<User> LoginUser(string user, string pin)
        {
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("user", user),
                new KeyValuePair<string, string>("pin", pin)
            });
            var response = await Clients.IntratimeMiddlewareClient.PostAsync("user/login", content);
            if (!response.IsSuccessStatusCode) throw new HttpRequestException($"Could not login. Reason: {response.StatusCode} - {response.ReasonPhrase} - {response.Content}");
            return await response.Content.ReadFromJsonAsync<User>();
        }
    }
}
