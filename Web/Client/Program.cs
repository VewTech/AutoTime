using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Web;
using Blazored.LocalStorage;
using Web.Core;

namespace Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddBlazoredLocalStorage();


            try
            {
                var client = new HttpClient();
                var response = client.GetAsync("https://newapi.intratime.es/api/user/my-profile").Result;
                //if (response.IsSuccessStatusCode)
                //{
                //    var a = 2;
                //}
                var b = 2;
            }
            catch (Exception ex)
            {
                var c = 2;
            }

            await builder.Build().RunAsync();

        }
    }
}