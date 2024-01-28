namespace HomeWork9.Models
{
    public abstract class Vegetable
    {
        public string Name { get; }

        public int Calories { get; }

        public int Weight { get; }

        public Vegetable(string name, int calories, int weight) 
        {
            Name = name;
            Calories = calories;
            Weight = weight;
        }

        public abstract string Display();

    }
}
