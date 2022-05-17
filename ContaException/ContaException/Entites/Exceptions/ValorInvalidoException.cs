using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaException.Entites.Exceptions {
     class ValorInvalidoException: ApplicationException {

        public ValorInvalidoException(string message) : base(message) {
        }
    }
}
