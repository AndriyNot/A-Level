namespace HomeWork8.Models
{
    public class Candy : Sweet
    {
        public string Type { get; set; }

        public string Taste { get; set; }

        public Candy(string name, int weight, string type, string taste) : base(name, weight)
        {
            Type = type;
            Taste = taste;
        }

        public override string Display()
        {
            return $"{base.Display()},Type:{Type}, Taste:{Taste},";
        }
    }
}
