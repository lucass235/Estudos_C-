using System;

namespace CadastroPecas // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite a quantidade de peças: ");
            int qtd = int.Parse(Console.ReadLine());
            
            int codigo, qtdPeca;
            double preco, soma = 0;

            for (int i = 0; i < qtd; i++) {
                Console.Write("Digite o código da peça: ");
                codigo = int.Parse(Console.ReadLine());
                Console.Write("Digite a quantidade da peça: ");
                qtdPeca = int.Parse(Console.ReadLine());
                Console.Write("Digite o preço da peça: ");
                preco = double.Parse(Console.ReadLine());

                soma = soma + (qtdPeca * preco);

            }
            Console.WriteLine($"O resultado da soma dos preços das peças é R${soma}");

        }
    }
}