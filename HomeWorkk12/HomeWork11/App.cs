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
        private readonly ILoggerService _loggerService;

       
        public App(ILoggerService loggerService) 
        {
            _loggerService = loggerService;
           
        }
        public void Start()
        { 
            ElectronicDeviceRepository repository = new ElectronicDeviceRepository();
            ElectronicServices services = new ElectronicServices(repository);
            
            services.PlugInAllDevices();
            _loggerService.Log("\nSorting Appliances\n");
            services.SortDevicesByName();
            //services.SetDefaultDeviceAt(2);
            foreach (var item in services.ElectronicsInApartment)
            {
                Console.WriteLine(item.Display());
            }

            services.ElectricityUsageCalculator();
            Console.WriteLine("\nTotal Electricity Consumption:");

            Console.WriteLine("\nEnter the device name for searching.");
            string searchedDeviceName = Console.ReadLine();
            services.SearchDeviceByName(searchedDeviceName);

            //repository.AddDeviceToDatabase(services.ElectronicsInApartment);
        }
    }
}
