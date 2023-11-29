using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Registro del HttpClient con la URL base
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://apiservicios.ecuasolmovsa.com:3009/api/") });

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
