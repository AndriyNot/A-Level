namespace HomeWork11.Models
{
    public class CleaningAppliance : ElectronicDevice
    {
        public string CleaningMode { get; set; }

        public bool HasAutoEmpty { get; set; }

        public CleaningAppliance(string name, int powerConsumption, string cleaningMode, bool hasAutoEmpty) 
            : base(name, powerConsumption)
        {
            CleaningMode = cleaningMode;
            HasAutoEmpty = hasAutoEmpty;
        }

        public override string Display()
        {
            return $"{base.Display()}, cleaning mode:{CleaningMode}, {(HasAutoEmpty ? "Automatic Dust Removal" : "No")}";
        }
    }
}
