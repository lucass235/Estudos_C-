using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProdutos {
    internal class Produto {
        private string nome;
        private double preco;
        private int quantidade;

        public Produto() {
            this.nome = "Nome Produto";
            this.preco = 0;
            this.quantidade = 0;
        }

        public string Nome {
            get { return this.nome; }
            set {
                if (value == null) {
                    return;
                }
                this.nome = value; 
            }
        }

        public double Preco {
            get { return this.preco; }
            set {
                if (value <= 0) {
                    return;
                }

                this.preco = value;
            }
        }

        public int Quantidade {
            get { return this.quantidade; }
            set {
                if (value < 0) {
                    return;
                }
                this.quantidade = value;
            }
        }

        public double valorTotalEmEstoque() {
            return quantidade * preco;
        }

        public void adicionarProduto(int quantidade) {
            if (quantidade <= 0) {
                return;
            }

            this.quantidade += quantidade;
        }

        public void removerProduto(int quantidade) {
            if (quantidade <= 0 || quantidade > this.quantidade) {
                return;
            }

            this.quantidade -= quantidade;
        }

        public override string ToString() {
            return $"Dados do produto: {this.nome}, R${this.preco}," +
                $" {this.quantidade} unidades, Total: R${this.valorTotalEmEstoque()}";
        }
    }
}
