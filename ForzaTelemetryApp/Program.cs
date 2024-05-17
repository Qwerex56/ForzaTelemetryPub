using System.Net;
using System.Net.Sockets;
using ForzaTelemetry.ForzaModels.DataFormatters;
using ForzaTelemetry.ForzaModels.DataOut;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ForzaTelemetryApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// builder.Services.AddSingleton<>()

await builder.Build().RunAsync();