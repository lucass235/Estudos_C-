using ContaException.Entites;
using ContaException.Entites.Exceptions;
namespace ContaException {
    class Program {
        static void Main(string[] args) {
            int number;
            string holder;
            double balance, limit;
            bool volta = true;
            Accont account;
            Console.WriteLine("Bem vindo!");
            do {

                try {
                    Console.Write("Digite o número da conta: ");
                    number = int.Parse(Console.ReadLine());
                    Console.Write("Digite o nome do usuario da conta: ");
                    holder = Console.ReadLine();
                    Console.Write("Digite o limite de saque a conta: ");
                    limit = double.Parse(Console.ReadLine());
                    account = new Accont(number, holder, limit);

                    Console.Write("Digite o valor inicial do saldo em conta: ");
                    balance = double.Parse(Console.ReadLine());
                    account.deposit(balance);

                    Console.WriteLine("Dados\n" + account);

                    Console.Write("Digite o valor para saque: ");
                    balance = double.Parse((Console.ReadLine()));
                    account.withdraw(balance);

                    Console.WriteLine("Dados\n" + account);

                    volta = false;
                }
                catch (SaldoInsuficienteException e) {
                    Console.WriteLine("Erro: " + e.Message);
                    volta = true;
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (LimiteSaqueException e) {
                    Console.WriteLine("Erro: " + e.Message);
                    volta = true;
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e) {
                    Console.WriteLine("Erro: " + e.Message);
                    volta = true;
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (volta);
            Console.WriteLine("Obrigado!!");

        }
    }
}