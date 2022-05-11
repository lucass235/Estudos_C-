namespace AluguelQuartos {
    class Program {
        static void Main(string[] args) {
            Estudante estudante;
            Quarto[] quartos = new Quarto[2];
            char opcao = '9';
            string nomeEstudante, emailEstudante;
            int id;

            do {
                try {
                    menu();
                    opcao = char.Parse(Console.ReadLine());

                    switch (opcao) {
                        case '1':
                            if (vagaDisponivel(quartos)) {
                                for (int i = 0; i < quartos.Length; i++) {
                                    if (quartos[i] == null) {
                                        Console.Write($" Quarto {i + 1} |");
                                    }
                                }
                                Console.WriteLine();
                            } else {
                                Console.WriteLine($"Quartos cheios!");
                            }
                            break;
                        case '2':
                            if (vagaDisponivel(quartos)) {
                                Console.Write("Informe o nome do estudante: ");
                                nomeEstudante = Console.ReadLine();
                                Console.Write("Informe o e-mail do estudante: ");
                                emailEstudante = Console.ReadLine();
                                estudante = new Estudante(nomeEstudante, emailEstudante);
                                Console.Write("Informe o número do quarto que deseja alugar: ");
                                id = int.Parse(Console.ReadLine());
                                while (id > quartos.Length || id <= 0) {
                                    Console.Write("Número incorreto, informe um quarto valido: ");
                                    id = int.Parse(Console.ReadLine());
                                }
                                alugarQuarto(id, quartos, estudante);

                            } else {
                                Console.WriteLine($"Quartos cheios!");
                            }
                            break;
                        case '3':
                            detalhesAluguel(quartos);
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
                catch (Exception e) {
                    Console.WriteLine("Erro: " + e.Message);
                }

            } while (opcao != '0');
        }

        public static void menu() {
            Console.Write(" 1 - Ver quartos disponiveis \n 2 - Alugar quarto \n " +
                "3 - Ver detalhes dos alugueis \n 0 - encerrar \n");
        }

        public static bool vagaDisponivel(Quarto[] quartos) {

            for (int i = 0; i < quartos.Length; i++) {
                if (quartos[i] == null) {
                    return true;
                }
            }
            return false;
        }

        public static void alugarQuarto(int id, Quarto[] quartos, Estudante estu) {
            for (int i = 0; i < quartos.Length; i++) {
                if (quartos[i] == null && i == (id - 1)) {
                    quartos[i] = new Quarto();
                    quartos[i].estudante = estu;
                    Console.WriteLine($"Quarto {i + 1} alugado!");
                    return;
                }
            }
            Console.WriteLine("Quarto ocupado!");
        }

        public static void detalhesAluguel(Quarto[] quartos) {
            for (int i = 0; i < quartos.Length; i++) {
                if (quartos[i] != null) {
                    Console.WriteLine($"Quarto {i + 1} alugado por \n" +
                        $"{quartos[i].estudante}");
                }
                Console.WriteLine();
            }
        }
    }
}