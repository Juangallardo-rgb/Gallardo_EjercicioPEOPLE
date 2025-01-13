using Microsoft.Extensions.Logging;

namespace JGPeople
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            string dbPath = JGFileAccessHelper.GetLocalFilePath("JGpeople.db3");
            builder.Services.AddSingleton<JGPersonRepository>(s => ActivatorUtilities.CreateInstance<JGPersonRepository>(s, dbPath));

            return builder.Build();
        }
    }
}
