using BLL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    internal class CAService : IGenericBusinessLogic<CA>
    {
        #region "Singleton"
        private static readonly Lazy<IGenericBusinessLogic<CA>> _default = new Lazy<IGenericBusinessLogic<CA>>(() => new CAService());
        public static IGenericBusinessLogic<CA> Default
        {
            get { return _default.Value; }
        }
        #endregion
        public decimal Convertir(decimal monto)
        {
            throw new NotImplementedException();
        }
        public decimal Depositar(decimal monto)
        {
            throw new NotImplementedException();
        }

        public void Transferir(decimal monto)
        {
            throw new NotImplementedException();
        }
    }
}
