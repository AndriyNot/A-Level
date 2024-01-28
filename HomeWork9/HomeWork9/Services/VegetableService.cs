namespace HomeWork9.Services
{
    using HomeWork9.Models;

    public class VegetableService
    {
        public Vegetable[] vegetables;

        public VegetableService() 
        {
            vegetables = CreateVegetables();
        }

        public static Vegetable CreateLeafyVegetable(string name, int calories, int weight, string leafType)
        {
            return new LeafyVegetable(name, calories, weight, leafType);
        }

        public static Vegetable CreateRootVegetable(string name, int calories, int weight, string rootType)
        {
            return new RootVegetable(name, calories, weight, rootType);
        }

        public static Vegetable CreateFruitVegetable(string name, int calories, int weight, string fruitType)
        {
            return new FruitVegetables(name, calories, weight, fruitType);
        }

        public Vegetable[] CreateVegetables()
        {
            return new Vegetable[]
            {
                CreateRootVegetable("carrot", 32, 160, "Root vegetables"),
                CreateRootVegetable("beet", 12, 260, "Root vegetables"),
                CreateRootVegetable("radish", 25, 30, "Root vegetables"),

                CreateLeafyVegetable("cabbage", 69, 300, "Leafy vegetables"),
                CreateLeafyVegetable("arugula", 20, 75, "Leafy vegetables"),
                CreateLeafyVegetable("lettuce", 65, 100, "Leafy vegetables"),

                CreateFruitVegetable("tomato", 25, 40, "Fruit vegetables"),
                CreateFruitVegetable("cucumber", 15, 120, "Fruit vegetables"),
                CreateFruitVegetable("zucchini", 54, 400, "Fruit vegetables"),
            };
        }
    }
}
