using AlriyadahBMS.Services;
using AlriyadahBMS.Services.IServices;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;

namespace AlriyadahBMS
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMudServices();
            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddLocalization();
            builder.Services.AddSingleton<LocalizationService>();
            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:52985") });

            builder.Services.AddScoped(sp => {
                var httpClient = new HttpClient
                {
                    BaseAddress = new Uri("http://localhost:52985"),
                    Timeout = TimeSpan.FromSeconds(20000) // Timeout set to 30 seconds
                };
                return httpClient;
            });

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://bmstest.alriyadahbms.com") });
            builder.Services.AddScoped<ISwaggerApiService, SwaggerApiService>();
            builder.Services.AddScoped<AuthenticationStateProvider, AuthenticationStateService>();
            builder.Services.AddScoped<IAuthenticationStateService, AuthenticationStateService>();
            builder.Services.AddScoped<IAccountService, AccountService>();
            builder.Services.AddScoped<TableService>();
            builder.Services.AddScoped<FileUploadService>();
            builder.Services.AddScoped<RegisterService>();
            builder.Services.AddScoped<NafathService>();


#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();

#endif
            LocalizationService.InitializeAsync().GetAwaiter().GetResult();
            return builder.Build();
        }
    }
}
