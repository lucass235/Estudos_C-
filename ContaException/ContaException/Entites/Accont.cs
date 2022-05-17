using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContaException.Entites.Exceptions;

namespace ContaException.Entites {
     class Accont {

        public int number { get; set; }
        public string holder { get; set; }
        public double balance { get; set; }
        public double withdrawLimit { get; set; }

        public Accont(int number, string holder, double withdrawLimit) {
            this.number = number;
            this.holder = holder;
            this.withdrawLimit = withdrawLimit;
        }

        public void deposit(double amount) {
            _ = amount <= 0 ? throw new ValorInvalidoException("Valor menor ou igual a zero") : this.balance = amount;
        }

        public void withdraw(double amount) {
            if (amount > this.balance) {
                throw new SaldoInsuficienteException("Saldo insuficiente");
            } else if (amount > this.withdrawLimit) {
                throw new LimiteSaqueException("Limite de saque excedido!");
            } else {
                this.balance -= amount;
            }
        }

        public override string ToString() {
            return $"Numero da conta: {this.number}\nNome do usúario: {this.holder}\n" +
                $"Saldo: R${this.balance}";
        }
    }
}
