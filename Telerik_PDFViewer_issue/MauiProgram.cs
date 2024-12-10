using Microsoft.Extensions.Logging;
using Telerik.Maui.Controls.Compatibility;

namespace Telerik_PDFViewer_issue
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseTelerik()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("telerikcontrolsicons.ttf", "TelerikControlsIcons");
                    fonts.AddFont("telerikfontexamples.ttf", "TelerikFontExamples");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
