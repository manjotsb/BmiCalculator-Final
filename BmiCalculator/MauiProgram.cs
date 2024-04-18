using Microsoft.Extensions.Logging;

namespace BmiCalculator
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansRegular");
                    fonts.AddFont("Hindi-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("PassionOne-Regualar.ttf", "PassionOneRegular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
