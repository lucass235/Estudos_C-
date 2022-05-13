
namespace OrdemDeServicos.Entites {
     class Product {
        public string name { get; private set; }
        public double price { get; private set; }

        public Product(string name, double price) {
            this.name = name;
            this.price = price;
        }

        public override string ToString() {
            return $"Produto: {this.name} preço R${this.price}";
        }
    }
}
