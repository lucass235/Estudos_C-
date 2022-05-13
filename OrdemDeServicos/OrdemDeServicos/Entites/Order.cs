using OrdemDeServicos.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemDeServicos.Entites {
     class Order {
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }
        public Cliente client { get; set; }
        public List<OrderItem> items { get; set; }

        public Order(DateTime moment, OrderStatus status) {
            this.moment = moment;
            this.status = status;
            items = new List<OrderItem>();
        }

        public void addItem(OrderItem item) {
            items.Add(item);
        }

        public void removeItem(OrderItem item) {
            items.Remove(item);
        }

        public double total() {
            double sum = 0;
            foreach (OrderItem item in items) {
                sum += item.subTotal();
            }
            return sum;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Comanda:".ToUpper());
            sb.AppendLine($"Tempo da comanda: {this.moment.ToString("dd-MM-yyy HH-mm-ss")}");
            sb.AppendLine($"Status da comanda: {this.status}");
            sb.AppendLine($"Cliente: {this.client}");
            sb.AppendLine($"Pedidos:");
            foreach (OrderItem item in items) {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Preço total: R${this.total()}");
            return sb.ToString();
        }
    }
}
