namespace HomeWork9
{
    using HomeWork9.Models;
    using HomeWork9.Services;
    using Microsoft.Extensions.DependencyInjection;

    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
            .AddScoped<ILeafType, LeafyVegetable>()
            .AddScoped<IRootType, RootVegetable>()
            .AddScoped<IFruitType, FruitVegetables>()
            .AddScoped<VegetableService>()
            .AddScoped<SaladService>()
            .AddScoped<Recipe>()
            .AddScoped<App>()
            .BuildServiceProvider();

            var scope = serviceProvider.CreateScope();

            var app = scope.ServiceProvider.GetRequiredService<App>();
            app.Start();
        }
    }
}
