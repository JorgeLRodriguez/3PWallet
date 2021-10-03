using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    internal interface IGenericBusinessLogic<T> where T: class, new ()
    {
        decimal Depositar(decimal monto);
        decimal Convertir(decimal monto);
        void Transferir(decimal monto);
    }
}
