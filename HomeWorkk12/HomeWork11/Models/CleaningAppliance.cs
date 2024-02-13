namespace HomeWork11.Models
{
    public class CleaningAppliance : ElectronicDevice
    {
        public string CleaningMode { get; set; }

        public bool IsAutoEmpty { get; set; }

        public CleaningAppliance(string name, int powerConsumption, string cleaningMode, bool hasAutoEmpty)
            : base(name, powerConsumption)
        {
            CleaningMode = cleaningMode;
            IsAutoEmpty = hasAutoEmpty;
        }

        public override string Display()
        {
            return $"{base.Display()}, cleaning mode:{CleaningMode}, {(IsAutoEmpty ? "Automatic Dust Removal" : "No")}";
        }
    }
}
