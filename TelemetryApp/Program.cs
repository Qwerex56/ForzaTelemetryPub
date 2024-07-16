using TelemetryApp;
using TelemetryApp.Components;
using UdpListenerService.Listeners;
using UdpListenerService.UdpSettings;

// using Microsoft.EntityFrameworkCore;
// using UdpDbModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
       .AddInteractiveServerComponents();

builder.Services.AddMvc();

builder.Configuration.SetBasePath(builder.Environment.ContentRootPath);
builder.Configuration.AddJsonFile("./ForzaUdpSettings.json", true, true);

builder.Services.AddOptions();
builder.Services.Configure<ForzaUdpSettings>(builder.Configuration.GetSection("ForzaUdpSettings"));

builder.Services.AddSingleton<FmFhListener>();
builder.Services.AddHostedService(sp => sp.GetRequiredService<FmFhListener>());

// var connectionString = builder.Configuration.GetSection("ConnectionStrings").Get<ConnectionStrings>();
// builder.Services.AddDbContext<ForzaTelemetryContext>(optionsBuilder =>
//     optionsBuilder.UseNpgsql(connectionString?.DevLocal));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.UseRouting();
app.UseAntiforgery();
app.MapDefaultControllerRoute();

app.Run();