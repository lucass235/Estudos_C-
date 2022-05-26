using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoDeProduto {
    class Produto {
        public string name { get; set; }
        public double price { get; set; }
        public int qtd { get; set; }

        public Produto(string name, double price, int qtd) {
            this.name = name;
            this.price = price;
            this.qtd = qtd;
        }

        public double total() {
            return this.price * this.qtd;
        }
    }
}
