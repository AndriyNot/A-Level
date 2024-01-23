namespace HomeWork9
{
    using System;
    using HomeWork9.Models;
    using HomeWork9.Services;

    public class App
    {
        public void Start()
        {
            Console.WriteLine("Ingredients for a salad:");
            VegetableService vegetableService = new VegetableService();

            Recipe recipe = new Recipe();
            recipe.RandomCreatRecipe(vegetableService.vegetables);
            foreach (Vegetable item in recipe.Ingredients)
            {
                if (item.Name != null)
                {
                    Console.WriteLine($"Name:{item.Name}, WeightVegetable: {item.Weight}");
                }

            }

            SaladService saladService = new SaladService();
            Console.WriteLine("\nA salad made according to the recipe.\n");
            saladService.AddVegetables(vegetableService.vegetables, recipe);

            int totalCalorie = saladService.CalculationCalorie(saladService.VegetablesInSalad);
            Console.WriteLine($"The salad has {totalCalorie} calories\n");

            Console.WriteLine($"Enter the minimum number of calories to search for vegetables in the salad.");
            int MinCalories = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter the maximum number of calories to search for vegetables in the salad.");
            int MaxCalories = Convert.ToInt32(Console.ReadLine());

            saladService.SerchSalad(saladService.VegetablesInSalad, MinCalories, MaxCalories);
            Console.WriteLine("The vegetables in the salad are sorted by calories.\n");
            saladService.SortVegetables();
            foreach (Vegetable item in saladService.VegetablesInSalad)
            {
                if (item.Name != null)
                {
                    Console.WriteLine(item.Display());
                }
            }
        }
    }
}
