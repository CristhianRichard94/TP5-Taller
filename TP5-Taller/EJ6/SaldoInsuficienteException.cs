using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ6
{
    /// <summary>
    /// Clase de excepcion producida cuando se intenta debitar un saldo superior al disponible, incluyendo el acuerdo
    /// </summary>
    class SaldoInsuficienteException : ApplicationException
    {
            public SaldoInsuficienteException(string pMensaje) : base(pMensaje)
            { }
    }
}
