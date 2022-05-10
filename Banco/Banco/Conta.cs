using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    internal class Conta {

        private int numero;
        private string nome;
        private double valor;

        public Conta(int numero, string nome) {
            this.numero = numero;
            this.nome = nome;
        }

        public Conta(int numero, string nome, double valor): this(numero, nome) {
            this.valor = valor;
        }
        public double Valor { 
            get { return valor; } 
        }

        public int Numero {
            // numero da conta não pode ser alterada!(somente leitura)
            get { return numero; }
            
        }

        public string Nome {
            get { return nome; }
            set { nome = value; }
        }

        public void depositar(double valor) {
            if (valor <= 0) {
                throw new ArgumentException("Valor de deposito não pode ser" +
                    "menor ou igual a 0!");
                
            }
            this.valor += valor;
            Console.WriteLine($"Deposito de R${valor:F2} realizado!");

        }

        public void sacar(double valor) {
            if (this.valor > 0) {
                if ((valor <= 0) ) {
                    throw new ArgumentException("Valor de saque menor  ou igual a 0!");
                } else {
                    this.valor = (this.valor - valor) - 5.0;
                    Console.WriteLine($"Saque de R${valor:F2} realizado!");
                }
            } else {
                throw new ArgumentException("Saldo insuficiente!");
            }
            
        }

        public override string ToString() {
            return $"Conta {this.Numero}, Titular: {this.Nome}, Saldo: " +
                $"R${this.Valor}";
        }

    }
}
