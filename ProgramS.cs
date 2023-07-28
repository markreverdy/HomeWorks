using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module2_Ex5.Services.Abstractions;
using Module2_Ex5.Services;

namespace Module2_Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("config.json")
                .Build();

            services.AddSingleton<IConfiguration>(configuration);
            services.AddTransient<ILogger, Logger>();
            services.AddTransient<IFileService, FileService>();
            services.AddTransient<Actions>();
            services.AddTransient<App>();

            var serviceProvider = services.BuildServiceProvider();

            var app = serviceProvider.GetRequiredService<App>();
            app.Run();
        }
    }
}