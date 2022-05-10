namespace CadastroProdutos {
    class Program {
        static void Main(string[] args) {
            string name;
            double preco;
            int qtd, opcao = 5;
            Produto produto = new Produto();
            try {
                Console.Write("Digite o nome do produto: ");
                name = Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                preco = double.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade do produto: ");
                qtd = int.Parse(Console.ReadLine());

                produto.Nome = name;
                produto.Preco = preco;
                produto.Quantidade = qtd;
            }
            catch (Exception ex) {
                Console.WriteLine("Erro: " + ex.Message);

            }


            do {
                try {
                    menu();
                    opcao = int.Parse(Console.ReadLine());
                    switch (opcao) {
                        case 1:
                            Console.WriteLine(produto);
                            break;
                        case 2:
                            Console.WriteLine("Digite a quantidade a ser adicionada: ");
                            qtd = int.Parse(Console.ReadLine());
                            while (qtd <= 0) {
                                Console.WriteLine("Digite uma quantidade maior que 0: ");
                                qtd = int.Parse(Console.ReadLine());
                            }
                            produto.adicionarProduto(qtd);
                            break;
                        case 3:
                            Console.WriteLine("Digite a quantidade a ser removida: ");
                            qtd = int.Parse(Console.ReadLine());
                            produto.removerProduto(qtd);
                            while (qtd <= 0) {
                                Console.WriteLine("Digite uma quantidade maior que 0: ");
                                qtd = int.Parse(Console.ReadLine());
                            }
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
                    opcao = 1;
                }
            } while (opcao != 0);

        }

        public static void menu() {
            Console.Write(" 1 - Ver produto \n 2 - Adicionar quantidade \n " +
                "3 - Remover quantidade \n 0 - encerrar \n");
        }
    }
}
