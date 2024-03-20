namespace HomeWork4._4.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? CategoryId { get; set; }
        public int BreedId { get; set; }
        public float Age { get; set; }
        public int LocationId { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string Description { get; set; } = null!;

    }
}
