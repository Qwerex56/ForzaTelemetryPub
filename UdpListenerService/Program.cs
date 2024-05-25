using UdpListenerService;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<ListenerTest>();

var host = builder.Build();
host.Run();