using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Adapters
{
    internal class WalletBTCAdapter : IEntityAdapter<WalletBTC>
    {
        #region Singleton
        private readonly static WalletBTCAdapter _instance = new WalletBTCAdapter();
        public static WalletBTCAdapter Current
        {
            get
            {
                return _instance;
            }
        }
        private WalletBTCAdapter()
        {
        }
        #endregion
        public WalletBTC Adapt(object[] values)
        {
            return new WalletBTC()
            {
                ID = Guid.Parse(values[(int)Columnas.ID_BTC].ToString()),
                Saldo = decimal.Parse(values[(int)Columnas.Saldo].ToString())
            };
        }
        private enum Columnas
        {
            ID_BTC,
            Saldo
        }
    }
}
