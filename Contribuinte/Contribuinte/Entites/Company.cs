using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuinte.Entites {
    class Company : TaxPayer {
        public int numberOfEmployees { get; set; }

        public Company(string name, double anulincome, int numberOfEmployees)
            : base(name, anulincome) {
            this.numberOfEmployees = numberOfEmployees;
        }

        public override double tax() {
            return numberOfEmployees <= 10 ? this.anulincome * 0.16 : this.anulincome * 0.14;
        }
    }
}
