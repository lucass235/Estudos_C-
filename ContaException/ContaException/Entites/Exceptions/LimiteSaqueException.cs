using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaException.Entites.Exceptions {
     class LimiteSaqueException: ApplicationException {

        public LimiteSaqueException(string message) : base(message) {
        }
    }
}
