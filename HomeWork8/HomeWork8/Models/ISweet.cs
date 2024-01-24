namespace HomeWork8.Models
{
    public interface ISweet
    {
         string Name { get; }

         int Weight { get; }

         string Display();
    }
}
