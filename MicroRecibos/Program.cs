using MicroRecibos;
using MicroRecibos.Servicios;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using static System.Net.WebRequestMethods;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient
{
	//BaseAddress = new Uri("https://localhost:44353/")
	BaseAddress = new Uri("https://recibosmicro.azurewebsites.net")
});


builder.Services.AddScoped<IReciboApiClient, ReciboApiClient>();
builder.Services.AddScoped<IPagoApiClient, PagoApiClient>();

builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();


await builder.Build().RunAsync();

