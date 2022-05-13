using System.Text;

namespace OrdemDeServicos.Entites {
     class OrderItem {
        public int quantity { get; private set; }
        public double price { get; private set; }
        public Product product { get; private set; }

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
