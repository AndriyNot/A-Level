namespace HomeWork8.Models
{
    public class Chocolate : Sweet
    {
        public string Brand { get; set; }

        public int CocoaContent { get; set; }

        public Chocolate(string name, int weight, string brand, int cocoaContent) : base(name, weight)
        {
            Brand = brand;
            CocoaContent = cocoaContent;
        }

        public override string Display()
        {
            return $"Brand:{Brand}, CocoaContent:{CocoaContent}, {base.Display()}";
        }
    }
}
