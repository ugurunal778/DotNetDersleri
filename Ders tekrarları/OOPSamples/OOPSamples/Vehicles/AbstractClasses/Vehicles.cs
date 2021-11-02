namespace OOPSamples.Vehicles
{
    public abstract class Vehicles
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public bool Isfly { get; set; }
        public string TypeOfFuel { get; set; }
        public int MaxSpeed { get; set; }
        public int HorsePower { get; set; }

        public virtual void Run()
        {
            System.Windows.Forms.MessageBox.Show("Vehicle Running");
        }
    }
}
