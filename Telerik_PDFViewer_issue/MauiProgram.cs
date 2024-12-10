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

//#if WINDOWS10_0_17763_0_OR_GREATER
//    Microsoft.Maui.Handlers.LabelHandler.Mapper.AppendToMapping("FontFamily", (handler, element) =>
//    {
//        /*  An unpackaged app does not have ms-appx://Assets/ folder available. To avoid issues you can explicitly define the new path to the font file
//         *
//         *  - Packaged => "ms-appx://Assets/Fonts/Font.ttf#familyname" 
//         *  - Unpackaged => "font.ttf#familyname"
//         *
//         *  In order for the unpackaged approach to work, be sure to include the font's file with the project's assets and set the Build Action to 'CopyAlways'
//        */

//        handler.PlatformView.FontFamily = element.Font.Family.ToLower() switch
//        {
//            "telerikcontrolsicons" => new Microsoft.UI.Xaml.Media.FontFamily("telerikcontrolsicons.ttf#telerikcontrolsicons"),
//            "telerikfontexamples" => new Microsoft.UI.Xaml.Media.FontFamily("telerikfontexamples.ttf#telerikfontexamples"),
//            _ => handler.PlatformView.FontFamily
//        };
//    });
//#endif


            return builder.Build();
        }
    }
}
