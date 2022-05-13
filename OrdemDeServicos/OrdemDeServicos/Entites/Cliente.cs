using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemDeServicos.Entites {
    class Cliente {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }

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



