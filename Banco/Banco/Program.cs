namespace Banco {
    class Program {
        static void Main(string[] args) {
            string nomeConta;
            int numeroConta, op2 = 0;
            double valorConta;
            char op;
            Conta conta = null;
            try {
            Console.Write("Entre o Número de conta: ");
            numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            nomeConta = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n) : ");
            op = Char.ToLower(char.Parse(Console.ReadLine()));

            if (op == 's') {
                Console.Write("Entre com o valor de depósito inicial: ");
                valorConta = double.Parse(Console.ReadLine());
                conta = new Conta(numeroConta, nomeConta, valorConta);
            } else {
                conta = new Conta(numeroConta, nomeConta);
            }

            }
            catch (Exception e) {
                Console.WriteLine("Erro: " + e.Message);
            }
            do {
                try {
                    menu();
                    op2 = int.Parse(Console.ReadLine());
                    switch (op2) {
                        case 1:
                            Console.WriteLine(conta);
                            break;
                        case 2:
                            Console.Write("Entre com o valor para saque: ");
                            valorConta = double.Parse(Console.ReadLine());
                            conta.sacar(valorConta);
                            break;
                        case 3:
                            Console.Write("Entre com o valor para deposito: ");
                            valorConta = double.Parse(Console.ReadLine());
                            conta.depositar(valorConta);
                            break;
                        case 0:
                            Console.WriteLine("Programa encerrado!");

                            break;
                        default:
                            Console.WriteLine("Opção incorreta, digite qual quer tecla para continuar!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                catch (Exception e) {
                    Console.WriteLine("Erro: " + e.Message);

                }
            } while (op2 != 0);


        }
        public static void menu() {
            Console.Write(" 1 - Ver conta \n 2 - Fazer saque \n " +
               "3 - Fazer Deposito \n 0 - encerrar \n");

        }
    }

}

