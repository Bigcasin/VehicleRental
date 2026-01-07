namespace VehicleRENTAL.Classes {
    public class Hatchback : Vehicle {
        public int cargoCapacity;
        public bool functionalBackdoor;

        public override decimal CalculateRate() {
        return 21000;
        }
    }
}
