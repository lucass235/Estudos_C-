using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos.Entites {
     class Product {
        public string name { get; private set; }
        public double price { get; protected set; }

        public Product(string name, double price) {
            this.name = name;
            this.price = price;
        }

        public virtual string priceTag() {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{name} ");
            sb.Append($"R${price}");
            return sb.ToString();
        }
    }
}
