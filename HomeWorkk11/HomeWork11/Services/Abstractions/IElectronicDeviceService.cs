namespace HomeWork11.Services.Abstractions
{
    public interface IElectronicDeviceService
    {
        string Name { get; set; }

        int EnergyUsage { get; set; }

        void PlugIn();

        string Display();
    }
}
