using Contribuinte.Entites;

namespace Contribuinte {
    class Program {
        static void Main(string[] args) {
            int qtd, numberEmployees;
            char op = ' ';
            string name;
            double anual, health, total = 0;
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            do {
                try {

                    Console.Write("Digite a quantidade de pessoas a ser registradas: ");
                    qtd = int.Parse(Console.ReadLine());

                    for (int i = 0; i < qtd; i++) {
                        Console.Write("Irá registar um pessoa física (f) ou Júridica (j): ");
                        op = char.Parse(Console.ReadLine());
                        switch (op) {
                            case 'f':
                                Console.Write("Digite o nome: ");
                                name = Console.ReadLine();
                                Console.Write("Digite a renda anual: ");
                                anual = double.Parse(Console.ReadLine());
                                Console.Write("Digite os gastos com saúde: ");
                                health = double.Parse(Console.ReadLine());
                                taxPayers.Add(new Individual(name, anual, health));
                                break;
                            case 'j':
                                Console.Write("Digite o nome: ");
                                name = Console.ReadLine();
                                Console.Write("Digite a renda anual: ");
                                anual = double.Parse(Console.ReadLine());
                                Console.Write("Digite a quantidade de fúncionarios: ");
                                numberEmployees = int.Parse((Console.ReadLine()));
                                taxPayers.Add(new Company(name, anual, numberEmployees));
                                break;
                            default:
                                throw new Exception("Opção inválida!");
                                
                        }
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine("Erro: " + ex.Message);
                    op = ' ';
                }

            } while (op != 'j' && op != 'f');


            Console.WriteLine("Taxas: ");
            foreach (TaxPayer taxPayer in taxPayers) {
                total += taxPayer.tax();
                Console.WriteLine(taxPayer);
            }
            Console.WriteLine($"Total de taxas: R${total}");


        }
    }
}