namespace HomeWork11.Services
{
    using HomeWork11.Models;
    using HomeWork11.Repositories.Abstractions;
    using HomeWork11.Services.Abstractions;

    public class ElectronicServices : IElectronicServices
    {
        public IElectronicDeviceRepository repository;

        public CollectionCustom<IElectronicDeviceService> ElectronicsInApartment;


        public ElectronicServices(IElectronicDeviceRepository repository)
        {
            this.repository = repository;
            this.ElectronicsInApartment = new CollectionCustom<IElectronicDeviceService>();
            this.ElectronicsInApartment.AddRange(repository.CreatedElectronicDevices());
        }

        public void PlugInAllDevices()
        {
            foreach (var appliance in ElectronicsInApartment)
            {
                if (Math.Abs(appliance.EnergyUsage) > 0)
                {
                    Console.WriteLine($"{appliance.Name} is connected to power.");
                }
            }
        }

        public void SortDevicesByName()
        {
            ElectronicsInApartment.Sort((a, b) => String.Compare(a.Name, b.Name, StringComparison.Ordinal));
        }

        public void SearchDeviceByName(string name)
        {

        }

        public int ElectricityUsageCalculator()
        {
            int totalElectricityUsage = 0;
            foreach (var item in ElectronicsInApartment)
            {
                if (item != null)
                {
                    totalElectricityUsage += item.EnergyUsage;
                }
            }
            return totalElectricityUsage;


        }

        public void SetDefaultDeviceAt(int index)
        {
            ElectronicsInApartment.SetDefaultAt(index);
        }
    }
}
