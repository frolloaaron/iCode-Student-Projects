using Microsoft.Extensions.Logging;

namespace ArcadeAppCora
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

            string dbpath = System.IO.Path.Combine(FileSystem.AppDataDirectory, "users.db3");
            builder.Services.AddSingleton<UsersRep>(
                s => ActivatorUtilities.CreateInstance<UsersRep>(s, dbpath)
            );

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
