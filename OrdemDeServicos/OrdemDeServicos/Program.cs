using OrdemDeServicos.Controller;
using OrdemDeServicos.Entites;
using OrdemDeServicos.Entites.Enums;

namespace OrdemDeServicos {
    class Program {
        static void Main(string[] args) {
            DateTime datePedido;

            char opcao = ' ';
            Manage gerencia = new Manage();

            do {
                try {
                    menu();
                    opcao = char.Parse(Console.ReadLine());

                    switch (opcao) {
                        case '1':
                           makeWish(gerencia);
                            Console.WriteLine("Pedido realizado!");
                            break;
                        case '2':
                            gerencia.showOrdes();
                            break;
                        case '3':
                            Console.Write("Digite o tempo de segundos do pedido a ser finalizado: ");
                            datePedido = DateTime.Parse(Console.ReadLine());
                            gerencia.removeOrder(datePedido);

                            break;
                        case '0':
                            Console.WriteLine("Programa encerrado!");
                            break;
                        default:
                            Console.WriteLine("Opção incorreta, digite qual quer tecla para continuar!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                catch (FormatException) {
                    Console.WriteLine("Formato de entrada incorreto!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (IndexOutOfRangeException) {
                    Console.WriteLine("Indice fora dos limites aceitos");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e) {
                    Console.WriteLine("Erro: " + e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcao != '0');
        }


        public static void menu() {
            Console.Write(" 1 - Fazer Comanda \n 2 - Ver todos as comandas\n " +
                "3 - Finalizar Pedido \n 0 - encerrar \n Digite a opção desejada: ");
        }

        public static void makeWish(Manage gerencia) {
            string nameClient, email, nameProduct;
            DateTime dateBirth;
            OrderStatus status;
            int quantityProduct, qtdItems;
            double priceproduct;
            Order order;
            Cliente cliente;
            OrderItem item = null;
            Product product;

            Console.WriteLine("Digite os dados do cliente: ");
            Console.Write("Nome: ");
            nameClient = Console.ReadLine();
            Console.Write("E-mail: ");
            email = Console.ReadLine();
            Console.Write("Data de aniversario: ");
            dateBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite o satus da comanda");
            status = Enum.Parse<OrderStatus>(Console.ReadLine());
            cliente = new Cliente(nameClient,email,dateBirth);
            order = new Order(DateTime.Now, status);
            order.client = cliente;
            
            Console.Write("Digite a quantidade de pedidos que o cliente deseja: ");
            qtdItems = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdItems; i++) {
                Console.Write($"Digite o nome do {i+1}º pedido: ");
                nameProduct = Console.ReadLine();
                Console.Write($"Digite o preço do {i+1}º pedido: ");
                priceproduct = double.Parse(Console.ReadLine());
                Console.Write($"Digite a quantidade do {i+1}º pedido: ");
                quantityProduct = int.Parse(Console.ReadLine());
                product = new Product(nameProduct,priceproduct);
                item = new OrderItem(quantityProduct,priceproduct,product);
                order.addItem(item);
            }
            gerencia.addOrder(order);
        }
    }
}
