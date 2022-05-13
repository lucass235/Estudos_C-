namespace Matriz {
    class Program {


        static void Main(string[] args) {
            Console.WriteLine("Bem vindo a Empresa Direction Systems\n" +
                "====================================================");
            char opcao = 'n';
            int[,] matriz = null;
            int valor;
            bool continuar;
            do {

                try {
                    Console.Write("Digite os tamanhos de linha e coluna da Matriz: ");
                    string[] valores = Console.ReadLine().Split(' ');
                    int linha = int.Parse(valores[0]);
                    int coluna = int.Parse(valores[0]);

                    matriz = new int[linha, coluna];
                    for (int i = 0; i < linha; i++) {
                        Console.Write($"Digite os {matriz.GetLength(1)} valores da {i + 1}º linha da Matriz: ");
                        valores = Console.ReadLine().Split(' ');
                        for (int j = 0; j < coluna; j++) {
                            matriz[i, j] = int.Parse(valores[j]);
                        }
                    }
                    continuar = false;

                }
                catch(FormatException) {
                    continuar = true;
                    Console.WriteLine("Formato de entrada incorreto!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e) {
                    continuar = true;
                    Console.WriteLine($"Erro: {e.Message}");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while(continuar);

            do {
                try {
                    menu();
                    opcao = char.Parse(Console.ReadLine());

                    switch (opcao) {
                        case '1':
                            exibirMatrix(matriz);
                            break;
                        case '2':
                            Console.Write("Digite o valor a ser verificado: ");
                            valor = int.Parse(Console.ReadLine());
                            buscarValor(matriz, valor);
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
            Console.Write(" 1 - Ver matriz \n 2 - Ver Detalhes de 1 valor\n " +
                "0 - encerrar \n Digite a opção desejada: ");
        }
        public static void exibirMatrix(int[,] matriz) {
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void buscarValor(int[,] matriz, int valor) {
            bool achou = false;
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    if (matriz[i, j] == valor) {
                        achou = true;
                        Console.WriteLine($"Valor {matriz[i, j]}, posição: {(i + 1)},{(j + 1)} ");
                        if (j > 0) {
                            Console.WriteLine($"Valor a esquerda {matriz[i, (j - 1)]} ");
                        }
                        if (j < matriz.GetLength(1) - 1) {
                            Console.WriteLine($"Valor a direita {matriz[i, (j + 1)]} ");
                        }
                        if (i > 0) {
                            Console.WriteLine($"Valor acima {matriz[(i -1), j]} ");
                        }
                        if (i < matriz.GetLength(0) -1) {
                            Console.WriteLine($"Valor a baixo {matriz[(i + 1), j]} ");
                        }
                    }
                }
            }
            if (!achou) {
                throw new Exception("Valor não encontrado!");
            }
        }

    }
}
