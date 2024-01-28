namespace HomeWork9.Models
{
    using System;

    public class Recipe 
    {
        public Vegetable[] Ingredients;

        public const int MaxVegetablesIgredients = 5;

        public Recipe()
        {
            Ingredients = new Vegetable[MaxVegetablesIgredients];
        }

        public void RandomCreatRecipe(Vegetable[] allVegetables)
        {
                Random random = new Random();

                for (int i = 0; i < Ingredients.Length; i++)
                {
                   if (allVegetables != null)
                   {
                       int randomIndex = random.Next(0, allVegetables.Length);
                       Ingredients[i] = allVegetables[randomIndex];
                   }
                }
        }
    }
}
