namespace VehicleRENTAL.Classes {
    public class Sedan : Vehicle {
        public decimal trunkCapacity;
        public bool Sunroom;

        public override decimal CalculateRate() {
        return 15000m;
        }
    }
}
