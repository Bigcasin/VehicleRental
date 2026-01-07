namespace VehicleRENTAL.Classes {
    public class BilingManager {
        public Invoice GenerateInvoice(Rental rental) {
        return new Invoice();
        }
        public Payment ProcessPayment(Invoice invoice, decimal amount) {
        return new Payment();
        }
        public void ApplyDeposit(Invoice invoice, decimal amount) {

        }
        public decimal CalculateCharges(Rental rental) {
        return 0;
        }
    }
}
