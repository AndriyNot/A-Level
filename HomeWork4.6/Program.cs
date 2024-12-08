using HomeWork4._6.Data;
using HomeWork4._6.Services.Abstractions;
using HomeWork4._6.Services;
using HomeWork4._6;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HomeWork4._6.Repositories.Abstractions;
using HomeWork4._6.Repositories;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

void ConfigureServices(ServiceCollection serviceCollection, IConfiguration configuration)
{
    var connectionString = configuration.GetConnectionString("DefaultConnection");
    serviceCollection.AddDbContextFactory<ApplicationDbContext>(opts
        => opts.UseSqlServer(connectionString));
    serviceCollection.AddScoped<IDbContextWrapper<ApplicationDbContext>, DbContextWrapper<ApplicationDbContext>>();

    serviceCollection
        .AddTransient<IPetService, PetService>()
        .AddLogging(configure => configure.AddConsole())
        .AddTransient<IPetRepository, PetRepository>()
        .AddTransient<ILocationRepository, LocationRepository>()
        .AddTransient<ICategoryRepository, CategoryRepository>()
        .AddTransient<IBreedRepository, BreedRepository>()
        .AddTransient<ILocationService, LocationService>()
        .AddTransient<ICategoryService, CategoryService>()
        .AddTransient<IBreedService, BreedService>()
        .AddTransient<App>();
}

IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile(@"C:\Users\admin\source\repos\HomeWork4.6\config.json")
    .Build();

var serviceCollection = new ServiceCollection();
ConfigureServices(serviceCollection, configuration);
var provider = serviceCollection.BuildServiceProvider();

var migrationSection = configuration.GetSection("Migration");
var isNeedMigration = migrationSection.GetSection("IsNeedMigration");


if (bool.Parse(isNeedMigration.Value))
{
    var dbContext = provider.GetService<ApplicationDbContext>();
    await dbContext!.Database.MigrateAsync();
}

var app = provider.GetService<App>();
await app!.Start();