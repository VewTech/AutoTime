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

        public async Task SubmitClocking(ClockingAction clockingAction, string token)
        {
            var dateTime = DateTime.Today + clockingAction.ScheduledTime.ToTimeSpan();
            var data = new[]
            {
                new KeyValuePair<string, string>("userAction", clockingAction.Action.ToString()),
                new KeyValuePair<string, string>("timestamp", dateTime.ToString("yyyy'-'MM'-'dd HH':'mm':'ss")),
                new KeyValuePair<string, string>("token", token),
                new KeyValuePair<string, string>("coordinates", "39.35564548706826, -0.4456134227862798")
            };
            var content = new FormUrlEncodedContent(data);
            await Clients.IntratimeMiddlewareClient.PostAsync("user/clocking", content);
        }
    }
}
