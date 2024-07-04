using UdpListenerService.Listeners;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<FmFhListener>();

var host = builder.Build();
host.Run();