namespace HomeWork4._6.Data.Entities
{
    public class PetEntity
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string CategoryId { get; set; } = null!;
        public CategoryEntity? Category { get; set; }
        public string BreedId { get; set; } = null!;
        public BreedEntity? Breed { get; set; }
        public int Age { get; set; }
        public string LocationId { get; set; } = null!;
        public LocationEntity? Location { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
    }
}
