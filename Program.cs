using MudBlazor.Services;
using MyBlazorApp.Components;

var builder = WebApplication.CreateBuilder(args);

// Aggiunge i servizi Razor/Blazor
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Aggiunge i servizi MudBlazor
builder.Services.AddMudServices();

var app = builder.Build();

// Configurazione pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
