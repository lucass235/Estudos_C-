using ProcessoContrato.Entities;
using ProcessoContrato.Service;
using System;
using System.Globalization;
using System.Collections.Generic;
namespace ProcessoContrato {
    class Program {
        static void Main(string[] args) {
            DateTime date = new DateTime();
            ContractService contractService = new ContractService();
            double amount;
            int months, number;
            Console.Write("Digite o numero do contrato: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Digite a data do contrato no formato (dd/mm/yy): ");
             date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Digite o valor do contrato: ");
            amount = double.Parse(Console.ReadLine());
            Console.Write("Digite o numero parcelas: ");
            months = int.Parse(Console.ReadLine());

            contractService.processContract(number, date, amount, months, new PaypalService());

            Console.WriteLine("Parcelas do contrato: ");
            contractService.showInstallments();
        }
}
}