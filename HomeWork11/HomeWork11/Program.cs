namespace HomeWork11
{
    using HomeWork11.Repositories;
    using HomeWork11.Repositories.Abstractions;
    using HomeWork11.Services;
    using HomeWork11.Services.Abstractions;
    using Microsoft.Extensions.DependencyInjection;

    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
            .AddScoped<IElectronicDeviceRepository, ElectronicDeviceRepository>()
            .AddScoped<IElectronicServices, ElectronicServices>()
            .AddScoped<App>()
            .BuildServiceProvider();

            using (var scope = serviceProvider.CreateScope())
            {
                var app = scope.ServiceProvider.GetRequiredService<App>();
                app.Start();
            }
        }
    }
}
