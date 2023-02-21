using Microsoft.AspNetCore.Mvc;
using Library;
using Library.Schemas;

namespace IntratimeMiddleware.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        // Login with the user credentials to the Intratime service and return the user
        [HttpPost("login")]
        public User PostLogin(string user, string pin)
        {
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("user", user),
                new KeyValuePair<string, string>("pin", pin)
            });

            var response = Clients.IntratimeClient.PostAsync("user/login", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadFromJsonAsync<User>().Result!; 
            }
            throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        // Post a clocking using the user token
        [HttpPost("clocking")]
        public void PostClocking(int userAction, DateTime timestamp, string coordinates, string token)
        {
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("user_action", userAction.ToString()),
                new KeyValuePair<string, string>("user_timestamp", timestamp.ToString()),
                new KeyValuePair<string, string>("user_gps_coordinates", coordinates)
            });

            Clients.IntratimeClient.DefaultRequestHeaders.Add("token", token);
            Clients.IntratimeClient.PostAsync("user/clocking", content);
        }
    }
}
