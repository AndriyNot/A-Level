namespace HomeWork8.Models
{
    public class GummyBear : Candy
    {
        public string Color { get; set; }

        public GummyBear(string name, int weight, string type, string taste, string color) : base(name, weight, type, taste) 
        { 
            Color = color;
        }

        public override string Display()
        {
            return $"{base.Display()},Color:{Color}";
        }
    }
}
