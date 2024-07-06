using UdpListenerService.Listeners;
using UdpListenerService.UdpSettings;

var builder = Host.CreateApplicationBuilder(args);

builder.Configuration.SetBasePath(builder.Environment.ContentRootPath);
builder.Configuration.AddJsonFile("./UdpSettings/ForzaUdpSettings.json", true, false);

builder.Services.AddOptions();
builder.Services.Configure<ForzaUdpSettings>(builder.Configuration.GetSection("ForzaUdpSettings"));

builder.Services.AddHostedService<FmFhListener>();

var host = builder.Build();
host.Run();