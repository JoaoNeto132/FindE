using Blazored.Toast;
using FindE.Features.Cep.Services;
using FindE.Features.ChuckNorris.Services;
using FindE.Features.PrevisaoDoTempo.Services;
using FindE.Features.KenyeWest.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazoredToast();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<CepService>();
builder.Services.AddSingleton<ChuckNorrisService>();
builder.Services.AddSingleton<CitacaoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();