namespace HomeWork9.Services
{
    using System;
    using HomeWork9.Models;

    public class SaladService
    {
        public Vegetable[] VegetablesInSalad;
        public int vegetableCount;
        public const int MaxVegetables = 5;

        public SaladService()
        {
            VegetablesInSalad = new Vegetable[MaxVegetables];
            vegetableCount = 0;
        }

        public Vegetable[] AddVegetables(Vegetable[] vegetables, Recipe recipe)
        {
            foreach (Vegetable recipeVegetable in recipe.Ingredients)
            {
                foreach (Vegetable veg in vegetables)
                {
                    if (veg != null && veg.Name == recipeVegetable.Name)
                    {
                        if (vegetableCount <= VegetablesInSalad.Length)
                        {
                            VegetablesInSalad[vegetableCount] = veg;
                            vegetableCount++;
                        }
                        else
                        {
                            Console.WriteLine("no");
                        }
                    }
                }
            }

            return VegetablesInSalad;
        }

        public void SerchSalad(Vegetable[] vegetables, int MinCalories, int MaxCalories)
        {
            foreach (var item in vegetables)
            {
                if (item != null && item.Calories >= MinCalories && item.Calories <= MaxCalories)
                {
                    Console.WriteLine(item.Display());
                    break;
                }
                else
                {
                    Console.WriteLine("No candies found based on these criteria");
                    break;
                }
            }
        }

        public int CalculationCalorie(Vegetable[] vegetables)
        {
            int totalCalorie = 0;
            foreach (var item in vegetables)
            {
                if (item != null)
                {
                    totalCalorie += item.Calories;
                }
            }

            return totalCalorie;
        }

        public void SortVegetables()
        {
            for (int i = 0; i < VegetablesInSalad.Length - 1; i++)
            {
                for (int j = 0; j < VegetablesInSalad.Length - i - 1; j++)
                {
                    if (VegetablesInSalad[j] != null && VegetablesInSalad[j + 1] != null && VegetablesInSalad[j].Calories > VegetablesInSalad[j + 1].Calories)
                    {
                        Vegetable temp = VegetablesInSalad[j];
                        VegetablesInSalad[j] = VegetablesInSalad[j + 1];
                        VegetablesInSalad[j + 1] = temp;
                    }
                }
            }
        }
    }
}
