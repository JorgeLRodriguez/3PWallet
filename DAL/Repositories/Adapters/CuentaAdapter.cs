using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Adapters
{
    internal class CuentaAdapter : IEntityAdapter<Cuenta>
    {
        #region Singleton
        private readonly static CuentaAdapter _instance = new CuentaAdapter();
        public static CuentaAdapter Current
        {
            get
            {
                return _instance;
            }
        }
        private CuentaAdapter()
        {
        }
        #endregion

        public Cuenta Adapt(object[] values)
        {
            return new Cuenta()
            {
                IDCuenta = Guid.Parse(values[(int)Columnas.ID_CUENTA].ToString()),
                CajaAhorro = new CARepository().GetOne(Guid.Parse( values[(int)Columnas.ID_CA].ToString())),
                WalletBTC = new WalletBTCRepository().GetOne(Guid.Parse(values[(int)Columnas.ID_BTC].ToString())),
                Nombre = values[(int)Columnas.Nombre].ToString()
            };
        }
        private enum Columnas
        {
            ID_CUENTA,
            ID_CA,
            ID_BTC,
            Nombre
        }
    }
}
