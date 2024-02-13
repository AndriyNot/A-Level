
    using HomeWork11;
    using HomeWork11.Config;
    using HomeWork11.Repositories;
    using HomeWork11.Repositories.Abstractions;
    using HomeWork11.Services;
    using HomeWork11.Services.Abstractions;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;
using HomeWork11.Models;

void ConfigureServices(ServiceCollection serviceCollection, IConfiguration configuration)
{
    serviceCollection.AddOptions<LoggingSettings>().Bind(configuration.GetSection("Logger"));



        serviceCollection.AddTransient<IElectronicDeviceService, ElectronicDevice>()
        .AddTransient<IElectronicDeviceRepository, ElectronicDeviceRepository>()
        .AddTransient<IElectronicServices, ElectronicServices>()
        .AddTransient<ILoggerService, LoggerService>()
        .AddTransient<App>();
    
    
}


        var configuration = new ConfigurationBuilder()
        .AddJsonFile(@"F:\codingC#\HomeProjects\HomeWorkk11\HomeWork11\config.json")
        .Build();



        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection, configuration);
        var provider = serviceCollection.BuildServiceProvider();

        var app = provider.GetService<App>();
        app!.Start();
