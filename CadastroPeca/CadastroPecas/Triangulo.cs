using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPecas {
    internal class Triangulo {
        private int A;
        private int B;
        private int C;

        public Triangulo(int A, int B, int C) {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public int getA() {
            return this.A;
        }

        public int getB() {
            return this.B;
        }

        public void setA(int A) {
            this.A = A;
        }

        public void setB(int B) {
            this.B = B;
        }
    }
}
