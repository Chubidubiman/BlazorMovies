using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorMovies.Client;
using BlazorMovies.Client.Repositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
ConfigureServices(builder.Services);
//builder.Services.AddSingleton<ServicesSingleton>();
//builder.Services.AddTransient<ServicesTransient>();

await builder.Build().RunAsync();

void ConfigureServices(IServiceCollection services)
{
    services.AddSingleton<ServicesSingleton>();
    services.AddTransient<ServicesTransient>();
    services.AddSingleton<IRepositorie,Repositorie>();
}
