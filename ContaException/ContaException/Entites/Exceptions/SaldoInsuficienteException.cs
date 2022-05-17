using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaException.Entites.Exceptions {
     class SaldoInsuficienteException: ApplicationException {

        public SaldoInsuficienteException(string menssage): base(menssage) {
        }
    }
}
