namespace ContagemVotos {
    class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\votos.txt";
            Dictionary<string, int> voter = new Dictionary<string, int>();
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(",");
                        if (voter.ContainsKey(line[0])) {
                            voter[line[0]] += int.Parse(line[1]);
                        } else {

                            voter.Add(line[0], int.Parse(line[1]));
                        }
                    }
                }

                foreach (KeyValuePair<string, int> line in voter) {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}