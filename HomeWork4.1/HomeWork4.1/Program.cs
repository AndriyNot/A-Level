using HomeWork4._1.Config;
using HomeWork4._1.Services.Abstarctions;
using HomeWork4._1.Services;
using HomeWork4._1;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

void ConfigureServices(ServiceCollection serviceCollection, IConfiguration configuration)
{
    serviceCollection.AddOptions<ApiOption>().Bind(configuration.GetSection("Api"));
    serviceCollection
        .AddLogging(configure => configure.AddConsole())
        .AddHttpClient()
        .AddTransient<IInternalHttpClientService, InternalHttpClientService>()
        .AddTransient<IUserService, UserService>()
        .AddTransient<App>();
}

IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile(@"F:/codingC#/ProjectsA-Level/HomeProjects/HomeWork4.1/HomeWork4.1/config.json")
    .Build();

var serviceCollection = new ServiceCollection();
ConfigureServices(serviceCollection, configuration);
var provider = serviceCollection.BuildServiceProvider();

var app = provider.GetService<App>();
await app!.Start();