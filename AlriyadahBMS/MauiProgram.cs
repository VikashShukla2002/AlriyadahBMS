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
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:52985") });
            builder.Services.AddScoped<ISwaggerApiService, SwaggerApiService>();
            builder.Services.AddScoped<AuthenticationStateProvider, AuthenticationStateService>();
            builder.Services.AddScoped<IAuthenticationStateService, AuthenticationStateService>();
            builder.Services.AddScoped<IAccountService, AccountService>();
            builder.Services.AddScoped<TableService>();


#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();

#endif

            return builder.Build();
        }
    }
}
