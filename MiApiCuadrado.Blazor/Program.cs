using MiApiCuadrado.Blazor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MiApiCuadrado.Blazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://atreaapi-cdbcfmcffuaec7hf.centralus-01.azurewebsites.net/") });

builder.Services.AddScoped<EstudianteService>();

await builder.Build().RunAsync();
