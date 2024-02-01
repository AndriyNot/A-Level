namespace HomeWork11.Models
{
    public class KitchenElectronics : ElectronicDevice
    {
        public bool HasTimer { get; set; }

        public KitchenElectronics(string name, int powerConsumption, bool hasTimer)
            : base(name, powerConsumption)
        {
            this.HasTimer = hasTimer;
        }

        public override string Display()
        {
            return $"{base.Display()}, has timer:{(HasTimer ? "yes" : "no")}";
        }
    }
}
