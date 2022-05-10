using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoeda {
    class ConversorDeMoeda {
        public static double cotacaoDolar;
        public static double dolar;

        public static double valorPagoEmReais() {
            
            return (cotacaoDolar * dolar) * 1.06;
        }
    }
}
