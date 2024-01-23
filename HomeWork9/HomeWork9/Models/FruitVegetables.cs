namespace HomeWork9.Models
{
    public class FruitVegetables : Vegetable, IFruitType
    {
        public string FruitType { get; set; }

        public FruitVegetables(string name, int calories, int weight, string fruitType) : base(name, calories, weight)
        {
            FruitType = fruitType;
        }

        public override string Display()
        {
            return $"Type Fruit:{FruitType}, Name: {Name}, Calories: {Calories}, Weight: {Weight} ";
        }
    }
}
