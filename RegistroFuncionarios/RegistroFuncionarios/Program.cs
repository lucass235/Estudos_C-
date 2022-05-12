

namespace RegistroFuncionarios {
    class Program {
        static void Main(string[] args) {
            List<Funcionario> funcionarios = new List<Funcionario>();

            char opcao = '9';
            string nomeFuncionario;
            int idFuncionario;
            double salarioFuncionario, porcentagem;
            Funcionario achouFuncionario;

            Console.WriteLine("Bem vindo a Empresa Direction Systems\n" +
                "====================================================");

            do {
                try {
                    menu();
                    opcao = char.Parse(Console.ReadLine());

                    switch (opcao) {
                        case '1':
                            Console.Write("Digite o id do funcionario: ");
                            idFuncionario = int.Parse(Console.ReadLine());
                            achouFuncionario = buscarFuncionario(funcionarios, idFuncionario);
                            if (achouFuncionario == null) {
                                Console.Write("Digite o nome do funcionario: ");
                                nomeFuncionario = Console.ReadLine();
                                Console.Write("Digite o salário do funcionario: ");
                                salarioFuncionario = double.Parse(Console.ReadLine());
                                funcionarios.Add(new Funcionario(nomeFuncionario, salarioFuncionario, idFuncionario));
                                Console.WriteLine("Funcionario Registrado!");

                            } else {
                                Console.WriteLine("Id já existente!");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        case '2':
                            if (!listaVazia(funcionarios)) {
                                exibirFuncionarios(funcionarios);
                            } else {
                                Console.WriteLine("Lista vazia!!");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        case '3':
                            if (!listaVazia(funcionarios)) {
                                Console.WriteLine("Digite o id do funcionario: ");
                                idFuncionario = int.Parse(Console.ReadLine());
                                achouFuncionario = buscarFuncionario(funcionarios, idFuncionario);
                                if (achouFuncionario != null) {
                                    Console.WriteLine("Digite a parcentagem de aumento do funcionrio: ");
                                    porcentagem = double.Parse(Console.ReadLine());
                                    if (achouFuncionario.receberAumento(porcentagem)) {
                                        Console.WriteLine($"Aumento no Salario do funcionario {achouFuncionario.id}");
                                    }
                                } else {
                                    Console.WriteLine("Funcionario não encontrado!");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            } else {
                                Console.WriteLine("Lista vazia!");
                                Console.ReadKey();
                                Console.Clear();
                            }
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
            Console.Write(" 1 - Adcionar funcionarios \n 2 - Ver todos os funcionarios\n " +
                "3 - Dar aumento ao funcionario \n 0 - encerrar \n Digite a opção desejada: ");
        }

        public static void exibirFuncionarios(List<Funcionario> funcionarios) {
            foreach (Funcionario funcionario in funcionarios) {
                Console.WriteLine(funcionario);
            }
        }

        public static Funcionario buscarFuncionario(List<Funcionario> funcionarios, int id) {
            if (id <= 0) {
                throw new Exception("Id inválido!");
            }
            foreach (Funcionario fun in funcionarios) {
                if (fun.id == id) {
                    return fun;
                }
            }
            return null;
        }

        public static bool listaVazia(List<Funcionario> fun) {
            
            return fun.Count == 0;
        }


    }
}

