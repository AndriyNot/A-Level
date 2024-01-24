namespace HomeWork8.Models
{
    public class FilledChocolate : Chocolate 
    {
        public string Filling { get; set; }

        public FilledChocolate(string name, int weight, string brand, int cocoaContent , string filling) : base(name, weight, brand, cocoaContent)
        {
            Filling = filling;
        }

        public override string Display()
        {
            return $"{base.Display()},Filling:{Filling}";
        }
    }
}
