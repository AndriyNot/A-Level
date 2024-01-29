using HomeWork11.Models;
using HomeWork11.Repositories;
using HomeWork11.Services;
using HomeWork11.Services.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class App
    {

        private readonly LoggerService _loggerService;

        public App(LoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        public void Start()
        { 
            ElectronicDeviceRepository repository = new ElectronicDeviceRepository();
            ElectronicServices services = new ElectronicServices(repository);
            services.PlugInAllDevices();
            _loggerService.LogInformation("\nSorting Appliances\n");
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

            repository.AddDeviceToDatabase(services.ElectronicsInApartment);
        }
    }
}
