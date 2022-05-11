using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelQuartos {
    internal class Estudante {

        public string name { get; private set; }
        public string email { get; set; }

        public Estudante(string name, string email) {
            this.name = name;
            this.email = email;
        }

        public override string ToString() {
            return $"{this.name}, {this.email}.";
            }
    }
}
