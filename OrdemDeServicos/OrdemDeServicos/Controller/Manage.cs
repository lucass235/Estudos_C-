using OrdemDeServicos.Entites;
using System.Text;

namespace OrdemDeServicos.Controller {
    class Manage {
        public List<Order> orders { get; private set; }

        public Manage() {
            this.orders = new List<Order>();
        }

        public void addOrder(Order order) {
            orders.Add(order);
        }

        public void removeOrder(DateTime moment) {
            if (this.orders.Count > 0) {
                foreach (Order order in orders) {
                        Console.WriteLine($"Hora entrada: {moment.Second}");
                    Console.WriteLine($"Hora dentro: {order.moment.Second}");

                    if (order.moment.Second.Equals(moment.Second)) {
                        orders.Remove(order);
                        Console.WriteLine("Comanda finalizada!");
                        return;
                    }
                }
                Console.WriteLine("Comanda não encontrada!");
            } else {
                Console.WriteLine("Sem comandas!!");

            }

        }

        public void showOrdes() {
            if (orders.Count > 0) {
                foreach (Order order in orders) {
                    Console.WriteLine(order.ToString());
                }
            } else {
                Console.WriteLine("Sem comandas!!");
            }
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*Comandas*".ToUpper());
            foreach (Order order in orders) {
                sb.AppendLine(order.ToString());
            }
            return sb.ToString();
        }
    }
}
