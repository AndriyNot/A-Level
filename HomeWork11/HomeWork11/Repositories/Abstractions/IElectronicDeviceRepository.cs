namespace HomeWork11.Repositories.Abstractions
{
    using HomeWork11.Services.Abstraction;

    public interface IElectronicDeviceRepository
    {
        IElectronicDeviceService[] CreatedElectronicDevices();
    }
}
