namespace OOPSamples.Vehicles
{
    public class Dassault_Falcon_900 : AirVehicles, IFly
    {
        public string Fly()
        {
            return ("i can fly.");
        }

        public override void Run()
        {
            System.Windows.Forms.MessageBox.Show("Jet Flyin");
        }
    }
}
