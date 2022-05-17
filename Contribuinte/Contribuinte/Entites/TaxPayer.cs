using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuinte.Entites {
    abstract class TaxPayer {
        public string name { get; protected set; }
        public double anulincome { get; protected set; }

        protected TaxPayer(string name, double anulincome) {
            this.name = name;
            this.anulincome = anulincome;
        }

        public abstract double tax();

        public override string? ToString() {
            return $"{this.name}: R${this.tax()}";
        }
    }
}
