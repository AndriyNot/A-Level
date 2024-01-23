namespace HomeWork9.Models
{
    public class RootVegetable : Vegetable , IRootType
    {
        public string RootType { get; set; }

        public RootVegetable(string name, int calories, int weight, string rootType) : base(name, calories, weight)
        {
            RootType = rootType;
        }

        public override string Display()
        {
            return $"Type vegetable:{RootType}, Name: {Name}, Calories: {Calories}, Weight: {Weight} ";
        }
    }
}
