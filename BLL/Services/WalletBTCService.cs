using BLL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    internal class WalletBTCService : IGenericBusinessLogic<WalletBTC>
    {
        #region "Singleton"
        private static readonly Lazy<IGenericBusinessLogic<WalletBTC>> _default = new Lazy<IGenericBusinessLogic<WalletBTC>>(() => new WalletBTCService());
        public static IGenericBusinessLogic<WalletBTC> Default
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
