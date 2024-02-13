namespace HomeWork11.Models
{
    public class KitchenElectronics : ElectronicDevice
    {
        public bool IsHasTimer { get; set; }

        public KitchenElectronics(string name, int powerConsumption, bool hasTimer)
            : base(name, powerConsumption)
        {
            this.IsHasTimer = hasTimer;
        }

        public override string Display()
        {
            return $"{base.Display()}, has timer:{(IsHasTimer ? "yes" : "no")}";
        }
    }
}
