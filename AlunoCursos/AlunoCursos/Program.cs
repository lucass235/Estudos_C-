using AlunoCursos.Entites;
namespace AlunoCursos {
    class Program {
        static void Main(string[] args) {
            int cod, qtd;
            char op = ' ';

            SortedSet<Aluno> A = new SortedSet<Aluno>();
            SortedSet<Aluno> B = new SortedSet<Aluno>();
            SortedSet<Aluno> C = new SortedSet<Aluno>();

            try {
                do {
                    menu();
                    op = char.Parse(Console.ReadLine());
                    switch (op) {
                        case '1':
                            Console.Write("Digite a quantidade de estudante do curso A: ");
                            qtd = int.Parse(Console.ReadLine());
                            fillCourse(qtd, A);
                            break;
                        case '2':
                            Console.Write("Digite a quantidade de estudante do curso B: ");
                            qtd = int.Parse(Console.ReadLine());
                            fillCourse(qtd, B);
                            break;
                        case '3':
                            Console.Write("Digite a quantidade de estudante do curso C: ");
                            qtd = int.Parse(Console.ReadLine());
                            fillCourse(qtd, C);
                            break;
                        case '4':
                            if (A.Count == 0 && B.Count == 0 && C.Count == 0) {
                                Console.WriteLine("Listas vazias");
                            } else {
                                SortedSet<Aluno> union = new SortedSet<Aluno>(A);
                                union.UnionWith(B);
                                union.UnionWith(C);
                                foreach (Aluno aluno in union) {
                                    Console.WriteLine(aluno);
                                }
                                Console.WriteLine($"Total alunos: {union.Count}");
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

                } while (op != '0');

            }
            catch (Exception e) {
                Console.WriteLine("Erro: " + e.Message);
            }


        }
        public static void fillCourse(int qtd, SortedSet<Aluno> course) {
            for (int i = 0; i < qtd; i++) {
                Console.WriteLine($"Digite o nome do {i + 1} aluno: ");
                string name = Console.ReadLine();
                Console.Write($"Digite o código do estudante {i + 1}: ");
                int code = int.Parse(Console.ReadLine());
                course.Add(new Aluno(code, name));
            }
            Console.WriteLine("Estudante do curso cadastradas!");
        }

        public static void menu() {
            Console.Write(" 1 - Adicionar alunos do curso A \n 2 - Adicionar alunos do curso B \n " +
                "3 - Adicionar alunos do curso C \n 4 - Ver todos os Alunos do Alex \n 0 - encerrar \n Digite a opção: ");
        }
    }

}