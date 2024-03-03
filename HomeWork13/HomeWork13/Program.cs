using HomeWork13;
using HomeWork13.Repository;
using HomeWork13.Repository.Abstractions;
using HomeWork13.Services;
using HomeWork13.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;

void ConfigureService(ServiceCollection serviceCollection)
{
    serviceCollection
        .AddScoped<IContactService, ContactService>()
        .AddScoped<IContactRepositorie, ContactRepositorie>()
        .AddTransient<Startup>();


}

var serviceCollection = new ServiceCollection();
ConfigureService(serviceCollection);

var provider = serviceCollection.BuildServiceProvider();

var startup = provider.GetService<Startup>();
startup.Start();