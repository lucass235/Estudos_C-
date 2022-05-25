using ProcessoContrato.Service;
using ProcessoContrato.Entities;
namespace ProcessoContrato.Service {
    public class ContractService {
       Contract contract;
       IOnlinePaymentService onlinePaymentService;
       public void processContract(int number, DateTime date, double amount, int months, IOnlinePaymentService onlinePaymentService) {
              this.onlinePaymentService = onlinePaymentService;
              contract = new Contract(number, date, amount);
              double parce = contract.TotalValue / months;
              for (int i = 1; i <= months; i++) {
                double interest = this.onlinePaymentService.Interest(parce, i);
                double fullAmount = onlinePaymentService.PaymentFee(interest);
                contract.AddInstallment(new Installment(contract.Date.AddMonths(i), fullAmount));
              }
        }

        public void showInstallments() {
            foreach (Installment installment in contract.Installments) {
                Console.WriteLine(installment);
            }
        }
    }
}