using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Portfolio;
using Portfolio.Contracts;
using Portfolio.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IModelToJsonService, ModelToJson>();
builder.Services.AddScoped<ISkillService, SkillService>();

var app = builder.Build();

// Preload all data before app starts
using var scope = app.Services.CreateScope();
var dataService = scope.ServiceProvider.GetRequiredService<IModelToJsonService>();

_ = Task.WhenAll(
    dataService.GetPersonalInfoAsync(),
    dataService.GetCertificatesAsync(),
    dataService.GetEducationsAsync(),
    dataService.GetExperiencesAsync(),
    dataService.GetProjectsAsync(),
    dataService.GetSkillCategoriesAsync(),
    dataService.GetSkillsAsync()
);

await app.RunAsync();
