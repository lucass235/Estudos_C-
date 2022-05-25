namespace ProcessoContrato.Service {
    public class PaypalService : IOnlinePaymentService {
        public double Interest(double amount, int months) {
            return (0.01 * amount) * months + amount;
        }

        public double PaymentFee(double amount) {
            return (amount * 0.02) + amount;
        }
    }
}