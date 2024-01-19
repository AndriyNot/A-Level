namespace HomeWork8.Models
{
    public class Sweet : ISweet
    {
        public string Name { get; set; }

        public int Weight { get; set; }

        public Sweet(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }


        public virtual string Display()
        {
            return $"Name Sweet:{Name}, Weight:{Weight} grams";
        }
    }
}
