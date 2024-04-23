using HomeWork4._6.Services.Abstractions;


namespace HomeWork4._6
{
    public class App
    {
        private readonly IPetService _petService;
        private readonly ILocationService _locationService;
        private readonly ICategoryService _categoryService;
        private readonly IBreedService _breedService;

        public App(IPetService petService, ILocationService locationService, ICategoryService categoryService, IBreedService breedService)
        {
            _petService = petService;
            _locationService = locationService;
            _categoryService = categoryService;
            _breedService = breedService;
        }

        public async Task Start()
        {
            string categoryId = await _categoryService.AddCategoryAsync("ubi");

            string breedId = await _breedService.AddBreedAsync("is", categoryId);

            string locationId = await _locationService.AddLocationAsync("Ukrain");

            string petId = await _petService.AddPetAsync("Bi", categoryId, breedId, 1, locationId, "image_url", "description");

            var pet = await _petService.GetPetAsync(petId);
            if (pet != null)
            {
                Console.WriteLine($"New Pet: {pet.Name}, Category: {pet.CategoryId}, Breed: {pet.BreedId}, Age: {pet.Age}, Location: {pet.LocationId}, Image URL: {pet.ImageUrl}, Description: {pet.Description}");
            }
           

           
            string locationName = "Ukrain";
            var uniqueBreeds = await _petService.GetUniqueBreedsWithAgeOver3InLocationAsync(locationName);
            foreach (var uniqueBreed in uniqueBreeds)
            {
                Console.WriteLine($"Category: {uniqueBreed.CategoryName}, Breed: {uniqueBreed.BreedName}, Count: {uniqueBreed.Count}");
            }

            await _petService.DeletePetAsync(petId);
        }
    }
}
