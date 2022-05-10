namespace ProjetoTriangulo {
    class Program {
        static void Main(string[] args) {
            double ladoX, ladoY, ladoZ, area;
            string continuar;
            Triangulo triangulo;

            do {
            Console.Write("Digite o valor do lado X do triângulo: ");
            ladoX = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do lado Y do triângulo: ");
            ladoY = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do lado Z do triângulo: ");
            ladoZ = double.Parse(Console.ReadLine());

            triangulo = new Triangulo(ladoX, ladoY, ladoZ);
            area = triangulo.calcArea();

            Console.WriteLine($"Area do trinagulo: {area:F2}");

                Console.Write("Deseja calcular outro triangulo?: ");
                continuar = Console.ReadLine();

                Console.WriteLine(continuar);



            } while (continuar == "sim" || continuar == "s");




        }
    }
}
