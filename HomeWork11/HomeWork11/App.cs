namespace HomeWork11
{
    using System;
    using HomeWork11.Repositories;
    using HomeWork11.Services;

    public class App
    {
       public void Start()
       {
            ElectronicDeviceRepository repository = new ElectronicDeviceRepository();
            ElectronicServices services = new ElectronicServices(repository);
            services.PlugInAllDevices();

            Console.WriteLine("\nSorting Appliances\n");
            services.SortDevicesByName();
            foreach (var item in services.ElectronicsInApartment)
            {
                Console.WriteLine(item.Display());
            }

            int total = services.ElectricityUsageCalculator();
            Console.WriteLine("\nTotal Electricity Consumption:" + total);

            Console.WriteLine("\nEnter the device name for searching.");
            string savingName = Console.ReadLine();
            services.SearchDeviceByName(savingName);
       }
    }
}
