using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTriangulo {
    internal class Triangulo {
        private double x;
        private double y;
        private double z;

        public Triangulo(double x, double y, double z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double getX() {
            return x;
        }

        public double getY() {
            return y;
        }

        public double getZ() {
            return z;
        }

        public void setX(int x) {
            this.x = x;
        }

        public void setY(int y) {
            this.y = y;
        }

        public void setZ(int z) {
            this.z = z;
        }

        public double calcArea() {
            double area = 0;
            double p = 0;
            
            p = (this.x + this.y + this.z) / 2.0;
            area = Math.Sqrt(p * (p - this.x) * (p - this.y) * (p - this.z));
            
            return area;
        }


    }
}
