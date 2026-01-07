namespace VehicleRENTAL.Classes {
    public class SUV : Vehicle {
        public decimal towingCapability;
        public decimal groundClearance;

        public override decimal CalculateRate() {
        return 30000;
        }
    }
}
