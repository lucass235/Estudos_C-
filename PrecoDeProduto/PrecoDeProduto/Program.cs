namespace PrecoDeProduto {
    class Program {
        static void Main(string[] args) {
            string sourcePath = @"C:\temp\priceProduct.csv"; // camimho de origem do arquivo
            string targetPath = @"C:\temp\summary.csv"; // caminho de origem do arquivo
            //File.Create(targetPath);
            string[] lines = File.ReadAllLines(sourcePath); // guarda os dados de cada linha no array de string
            string[] dados;
            try {
                using (StreamWriter sw = File.AppendText(targetPath)) {
                    foreach (string line in lines) {
                        dados = line.Split(',');

                        Produto prod = new Produto(dados[0],double.Parse(dados[1]), int.Parse(dados[2]));
                        sw.WriteLine($"{prod.name}, R${prod.total()}");
                    }
                }
                Console.WriteLine("Criado!");
            }
            catch (IOException e) {
                Console.WriteLine("Erro de arquivo: " + e.Message);
            }
        }
    }
}
