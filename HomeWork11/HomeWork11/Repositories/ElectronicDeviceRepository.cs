namespace HomeWork11.Repositories
{
    using HomeWork11.Models;
    using HomeWork11.Repositories.Abstractions;
    using HomeWork11.Services.Abstraction;

    public class ElectronicDeviceRepository : IElectronicDeviceRepository
    {
        public IElectronicDeviceService[] CreatedElectronicDevices()
        {
            return new IElectronicDeviceService[]
            {
                new EntertainmentAppliance("samsungtv", 0, 2, true),
                new EntertainmentAppliance("asus laptop", 100, 4, true),

                new KitchenElectronics("refrigerator bosch", 1100, false),
                new KitchenElectronics("dishwasher samsung", 0, true),
                new KitchenElectronics("microwave indeside", 750, true),
                new KitchenElectronics("kettle bosch", 450, false),
                new KitchenElectronics("baking oven bosch", 1300, true),

                new CleaningAppliance("vacuum vleaner", 800, "Basic Mode", true),
                new CleaningAppliance("washing machine", 1300, "Eco Mode", true),
                new CleaningAppliance("clothes dryer", 0, "Eco Mode", true),
            };
        }
    }
}
