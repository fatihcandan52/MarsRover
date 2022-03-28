using Microsoft.Extensions.DependencyInjection;

namespace MarsRover.ConsoleApp
{
    public static class ServiceCollectionInit
    {
        public static ServiceProvider ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<ICommandCenter, CommandCenter>(); 
            return services.BuildServiceProvider();
        }
    }
}
