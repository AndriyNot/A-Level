using HomeWork11.Services.Abstraction;
using System;

namespace HomeWork11.Models
{
    public class ElectronicDevice : IElectronicDeviceService
    {
        public string Name { get; set; }

        public int EnergyUsage { get; set; }

        public ElectronicDevice(string name, int powerConsumption)
        {
            Name = name;
            EnergyUsage = powerConsumption;
        }

        public void PlugIn()
        {
            Console.WriteLine($"{Name} connected to the network.");
        }

        public virtual string Display()
        {
            return $"Name:{Name}, Energy usage:{EnergyUsage}";
        }
    }
}
