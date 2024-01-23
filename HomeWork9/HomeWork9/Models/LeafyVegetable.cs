namespace HomeWork9.Models
{
    public class LeafyVegetable : Vegetable, ILeafType
    {
        public string LeafType { get; set; }

        public LeafyVegetable(string name, int calories, int weight, string leafType) : base(name, calories, weight)
        {
            LeafType = leafType;
        }

        public override string Display()
        {
            return $"Type Leaf:{LeafType}, Name: {Name}, Calories: {Calories}, Weight: {Weight} ";
        }
    }
}
