namespace OOPSamples.Vehicles
{
    public class Boeing_737_800 : AirVehicles, IFly
    {
        public string Fly()
        {
            return ("i can fly.");
        }

        public override void Run()
        {
            System.Windows.Forms.MessageBox.Show("Flyin");
        }
    }
}
