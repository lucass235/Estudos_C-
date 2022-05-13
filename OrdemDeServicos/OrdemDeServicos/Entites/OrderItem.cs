using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemDeServicos.Entites {
     class OrderItem {
        public int quantity { get; set; }
        public double price { get; set; }
        public Product product { get; set; }

        public OrderItem(int quantity, double price, Product product) {
            this.quantity = quantity;
            this.price = price;
            this.product = product;
        }

        public double subTotal() {
            return quantity * price;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.product.name}, R${this.price}, " +
                $"quantidade: {this.quantity}, Total R${this.subTotal()}");
            return sb.ToString();
        }
    }
}
