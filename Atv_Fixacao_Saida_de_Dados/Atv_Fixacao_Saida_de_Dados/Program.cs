using System.Globalization;

string prod1 = "Computador";
string prod2 = "Mesa de escritorio";

byte idade = 30;
int codigo = 5290;
char genero = 'F';

double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;

Console.WriteLine("Produtos: ");
Console.WriteLine($"{prod1}, cujo preço é R${preco1}");
Console.WriteLine($"{prod2}, cujo preço é R${preco2}");

Console.WriteLine();

Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");

Console.WriteLine();

Console.WriteLine($"Medida com 8 casas decimais: {medida:F8}");
Console.WriteLine($"Arredondado (Três casas decimais): {medida:F3}");
Console.WriteLine($"Separador decimal invariant culture: {medida.ToString(CultureInfo.InvariantCulture)}");




Console.WriteLine("Hello, World!");
