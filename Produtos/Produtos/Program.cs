using Produtos.Entites;

namespace Produtos {
    class Program {
        static void Main(string[] args) {
            List<Product> products = new List<Product>();
            string name;
            double price, customs;
            DateTime manufacture;
            int qtd;
            char op = ' ';
            try {
                Console.Write("Digite quanto produtos vão ser registrado: ");
                qtd = int.Parse(Console.ReadLine());

                for (int i = 0; i < qtd; i++) {
                    do {
                        Console.Write("Qual tipo de produto você deseja registrar?\nImportado(i),Comum(c) ou Usado(u): ");
                        op = Char.Parse(Console.ReadLine());
                        switch (op) {
                            case 'i':
                                Console.Write("Digite o nome do produto: ");
                                name = Console.ReadLine();
                                Console.Write("Digite o preço do produto: ");
                                price = double.Parse(Console.ReadLine());
                                Console.Write("Digite a taxa do produto: ");
                                customs = double.Parse(Console.ReadLine());
                                products.Add(new ImportedProduct(name, price, customs));
                                break;
                            case 'c':
                                Console.Write("Digite o nome do produto: ");
                                name = Console.ReadLine();
                                Console.Write("Digite o preço do produto: ");
                                price = double.Parse(Console.ReadLine());
                                products.Add(new Product(name, price));
                                break;
                            case 'u':
                                Console.Write("Digite o nome do produto: ");
                                name = Console.ReadLine();
                                Console.Write("Digite o preço do produto: ");
                                price = double.Parse(Console.ReadLine());
                                Console.Write("Digite a data de fabricação do produto: ");
                                manufacture = DateTime.Parse(Console.ReadLine());
                                products.Add(new UsedProduct(name, price, manufacture));
                                break;
                            default:
                                Console.WriteLine("Opção incorreta!");
                                break;

                        }
                    } while (op != 'c' && op != 'i' && op != 'u');
                }

            }
            catch (Exception ex) {
                Console.WriteLine("Erro: " + ex.Message);
            }


            Console.WriteLine("Price tags: ");
            foreach (var product in products) {
                Console.WriteLine(product.priceTag());
            }
        }

    }
}