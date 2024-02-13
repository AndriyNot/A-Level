namespace HomeWork11.Models
{
    public class EntertainmentAppliance : ElectronicDevice
    {
        public bool IsSupportsWiFi { get; set; }

        public int NumberOfSpeakers { get; set; }

        public EntertainmentAppliance(string name, int powerConsumption, int numberOfSpeakers, bool supportsWiFi)
            : base(name, powerConsumption)
        {
            NumberOfSpeakers = numberOfSpeakers;
            IsSupportsWiFi = supportsWiFi;
        }

        public override string Display()
        {
            return $"{base.Display()}, supports WiFi:{(IsSupportsWiFi ? "yes" : "no")}, number of Speakers:{NumberOfSpeakers}";
        }
    }
}
