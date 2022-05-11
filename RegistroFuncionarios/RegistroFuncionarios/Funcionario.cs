using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroFuncionarios {
    internal class Funcionario {
        public string nome { get; private set; }
        public double salario { get; private set; }
        public int id { get; private set; }

        public Funcionario(string nome, double salario, int id) {
            this.nome = nome;
            this.salario = salario;
            this.id = id;
        }

        public bool receberAumento(double porcentagem) {
            if (porcentagem > 0) {
            double aumento = this.salario * (porcentagem / 100);
            this.salario += aumento;
                return true;
            } else {
                throw new Exception("Porcentagem inválida!");
            }
        }

        public override string ToString() {
            return $"Funcinario: {this.id}\nNome: {this.nome}\n" +
                $"Salário: {this.salario}\n";
        }
    }
}
