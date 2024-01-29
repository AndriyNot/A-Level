﻿namespace HomeWork11.Repositories.Abstractions
{
    using HomeWork11.Entity;
    using HomeWork11.Services.Abstractions;

    public interface IElectronicDeviceRepository
    {
        IElectronicDeviceService[] CreatedElectronicDevices();

        DeviceEntity[] AddDeviceToDatabase(IElectronicDeviceService[] electronicDevices);
    }   
}
