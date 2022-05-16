using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos.Entites {
    class UsedProduct : Product {
        public  DateTime manufactureDate { get; private set; }
        public UsedProduct(string name, double price, DateTime manufactureDate) 
            : base(name, price) {
            this.manufactureDate = manufactureDate;
        }

        public override string priceTag() {
            StringBuilder sb = new StringBuilder();
            sb.Append("(Usado) ");
            sb.Append($"Fabricado em {this.manufactureDate.ToString("dd/MM/yyyy")}");
            return base.priceTag() + sb;
        }
    }
}
