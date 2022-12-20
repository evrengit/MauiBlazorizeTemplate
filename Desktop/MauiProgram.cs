using Blazorise;
using Blazorise.Icons.Material;
using Blazorise.Material;
using Microsoft.Extensions.Logging;

namespace MauiBlazorizeTemplate;

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

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        builder.Services
            .AddBlazorise()
            .AddMaterialProviders()
            .AddMaterialIcons();

        return builder.Build();
    }
}