namespace HomeWork11.Services.Abstractions
{
    public interface IElectronicServices
    {
       
        void PlugInAllDevices();

        void SortDevicesByName();

        void SearchDeviceByName(string name);

        int ElectricityUsageCalculator();

        
    }
}
