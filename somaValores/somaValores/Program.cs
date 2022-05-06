
//somar valores
namespace somaValores {

    class Program {

        public static void Main(string[] args) {
            int a, b, resul;

            Console.Write("Digite o 1º valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            b = int.Parse(Console.ReadLine());


            resul = somar(a, b);
            Console.WriteLine($"Resultado de {a} + {b}: {resul}");
            

        }

        public static int somar(int a, int b) {
            int resul = a + b;
            return resul;
        }
    }
}
