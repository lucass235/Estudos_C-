using Produtos.Entites;

namespace Produtos.Entites {
    class ImportedProduct : Product {
        public double customsFee { get; private set; }
        public ImportedProduct(string name, double price, double customsFee) 
            : base(name, price) {
            this.customsFee = customsFee;
        }

        public double totalPrice() {
            return this.price += this.customsFee;
        }

        public override string priceTag() {
            string custom = $"(Taxa da alfândega R${this.customsFee})";
            return base.priceTag() + custom;
        }
    }
}
