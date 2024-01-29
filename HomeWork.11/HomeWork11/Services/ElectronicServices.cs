namespace HomeWork11.Services
{
    using HomeWork11.Repositories.Abstractions;
    using HomeWork11.Services.Abstractions;

    public class ElectronicServices : IElectronicServices
    {
        public IElectronicDeviceRepository repository;

        public IElectronicDeviceService[] ElectronicsInApartment;

        public ElectronicServices(IElectronicDeviceRepository repository)
        {
            this.repository = repository;
            this.ElectronicsInApartment = repository.CreatedElectronicDevices(); 
        }

        public void PlugInAllDevices()
        {
            foreach (var device in ElectronicsInApartment)
            {
                if (device.EnergyUsage > 0)
                {
                    device.PlugIn();
                }
            }
        }

        public void SortDevicesByName()
        {
            Array.Sort(ElectronicsInApartment, (x, y) => string.Compare(x.Name, y.Name));
        }

        public void SearchDeviceByName(string Name)
        {
            foreach (var item in ElectronicsInApartment)
            {
                if (item != null && item.Name == Name)
                {
                    Console.WriteLine(item.Display());
                    return;
                }
                else
                {
                    Console.WriteLine("No candies found based on these criteria");
                    break;
                }
            } 
        }

        public int ElectricityUsageCalculator()
        {
            int total = 0;
            foreach (var item in ElectronicsInApartment)
            {
                if (item != null)
                {
                    total += item.EnergyUsage;
                }
            }
            return total;
        }

    }
}
