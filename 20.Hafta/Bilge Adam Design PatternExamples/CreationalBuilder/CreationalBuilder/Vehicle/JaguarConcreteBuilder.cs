namespace CreationalBuilder.Vehicle
{
    class JaguarConcreteBuilder : VehicleBuilder
    {
        public JaguarConcreteBuilder()
        {
            vehicle = new Vehicle();
        }

        public override void Brand()
        {
            vehicle.Brand = "Jaguar";
        }

        public override void FuelType()
        {
            vehicle.FuelType = "Diesel";
        }

        public override void GearType()
        {
            vehicle.GearBoxType = "JF Şanzıman";
        }

        public override void MaxSpeed()
        {
            vehicle.MaxSpeedLimit = 300;
        }
    }
}
