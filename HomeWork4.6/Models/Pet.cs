namespace HomeWork4._6.Models
{
    public class Pet
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string CategoryId { get; set; } = null!;
        public Category? Category { get; set; }
        public string BreedId { get; set; } = null!;
        public Breed? Breed { get; set; }
        public int Age { get; set; }
        public string LocationId { get; set; } = null!;
        public Location? Location { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }

    }
}
