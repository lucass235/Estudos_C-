using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuinte.Entites {
    class Individual : TaxPayer {
        public double healthExpenditures { get; private set; }
        public Individual(string name, double anulincome, double healthExpenditures)
            : base(name, anulincome) {
            this.healthExpenditures = healthExpenditures;
        }
        public override double tax() {
            double tax;
            tax = this.anulincome < 20000.0 ? (this.anulincome) * 0.15 : (this.anulincome) * 0.25;
            return this.healthExpenditures > 0 ? tax - (this.healthExpenditures * 0.5) : tax;

        }
        
    }
}

