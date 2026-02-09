using Microsoft.Extensions.Logging;
using HandKit.Maui.MaterialIcons;

namespace sample
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddMaterialIconsFonts(); // <-- add this if using this font to global.
                                                   // using: FontFamily="Icon" (Icon or IconFilled)
                    // fonts.AddMaterialIconsFontsPartial(); // <-- add this if using this font as partial.
                    // using: FontFamily="MaterialIcon" (MaterialIcon or MaterialIconFilled)
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
