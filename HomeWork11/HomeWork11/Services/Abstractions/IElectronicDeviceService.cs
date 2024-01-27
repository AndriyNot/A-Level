namespace HomeWork11.Services.Abstraction
{
    public interface IElectronicDeviceService
    {
        string Name { get; set; }

        int EnergyUsage { get; set; }

        void PlugIn();

        string Display();
    }
}
