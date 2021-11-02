namespace OOPSamples.Vehicles
{
    public abstract class GroundVehicles : Vehicles
    {
        public int CountOfTyre { get; set; }
        public int CountOfDoors { get; set; }
        public int NumberOfCyclinder { get; set; }
        public int CyclinderVolume { get; set; }
        public override void Run() 
        {
            base.Run();
        }
    }
}
