using HomeWork4._5.Data;
using HomeWork4._5.Repositories.Abstractions;
using HomeWork4._5.Repositories;
using HomeWork4._5.Service.Abstractions;
using HomeWork4._5.Service;
using HomeWork4._5;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

void ConfigureServices(ServiceCollection serviceCollection, IConfiguration configuration)
{
    var connectionString = configuration.GetConnectionString("DefaultConnection");
    serviceCollection.AddDbContextFactory<ApplicationDbContext>(opts
        => opts.UseSqlServer(connectionString));
    serviceCollection.AddScoped<IDbContextWrapper<ApplicationDbContext>, DbContextWrapper<ApplicationDbContext>>();

    serviceCollection
        .AddTransient<IUserService, UserService>()
        .AddLogging(configure => configure.AddConsole())
        .AddTransient<IUserRepository, UserRepository>()
        .AddTransient<IOrderRepository, OrderRepository>()
        .AddTransient<IProductRepository, ProductRepository>()
        .AddTransient<INotificationService, NotificationService>()
        .AddTransient<IOrderService, OrderService>()
        .AddTransient<IProductService, ProductService>()
        .AddTransient<App>();
}

IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
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