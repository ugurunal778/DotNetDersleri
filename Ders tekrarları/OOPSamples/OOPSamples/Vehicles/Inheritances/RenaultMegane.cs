namespace OOPSamples.Vehicles
{
    public class RenaultMegane : GroundVehicles, IMove
    {
        public string Move()
        {
            return "i can move.";
        }

        public override void Run()
        {
            System.Windows.Forms.MessageBox.Show("Engine Started");
        }
    }
}
