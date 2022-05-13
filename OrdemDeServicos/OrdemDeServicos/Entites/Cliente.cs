using System.Text;

namespace OrdemDeServicos.Entites {
    class Cliente {
        public string name { get; private set; }
        public string email { get; private set; }
        public DateTime birthDate { get; private set; }

        public Cliente(string name, string email, DateTime birthDate) {
            this.name = name;
            this.email = email;
            this.birthDate = birthDate;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.name} ");
            sb.Append($"({this.birthDate.ToString("dd/MM/yyyy")}) - ");
            sb.Append($"{this.email}");
            return sb.ToString();
        }
    }
}



