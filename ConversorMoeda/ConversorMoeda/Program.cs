namespace ConversorMoeda {
    class Program {
        static void Main(string[] args) {

            double cotacao, dolar;

            Console.Write("Qual é a contação do dólar: ");
            ConversorDeMoeda.cotacaoDolar = double.Parse( Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar: ");
            ConversorDeMoeda.dolar = double.Parse( Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais: R$" +  ConversorDeMoeda.valorPagoEmReais().ToString("F2"));
        }
    }
}
