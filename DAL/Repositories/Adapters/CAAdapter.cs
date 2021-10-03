using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Adapters
{
    internal class CAAdapter : IEntityAdapter<CA>
    {
        #region Singleton
        private readonly static CAAdapter _instance = new CAAdapter();
        public static CAAdapter Current
        {
            get
            {
                return _instance;
            }
        }
        private CAAdapter()
        {
        }
        #endregion
        public CA Adapt(object[] values)
        {
            return new CA()
            {
                ID_CA = Guid.Parse(values[(int)Columnas.ID_CA].ToString()),
                CBU = long.Parse(values[(int)Columnas.CBU].ToString()),
                CUIT = int.Parse(values[(int)Columnas.CUIT].ToString()),
                Saldo = decimal.Parse(values[(int)Columnas.Saldo].ToString())
            };
        }
        private enum Columnas
        {
            ID_CA,
            CBU,
            CUIT,
            Saldo
        }
    }
}
