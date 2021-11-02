namespace OOPSamples.Vehicles
{
    public abstract class AirVehicles : Vehicles
    {
        public int CountOfMotors { get; set; }
        public int CountOfPassenger { get; set; }
        public int CountOfCrew { get; set; }
        public string TailNumber { get; set; }
        public bool IsPrivate { get; set; }
        public override void Run()
        {
            base.Run();
        }
    }
}
