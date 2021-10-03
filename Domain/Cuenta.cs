using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cuenta
    {
        public Guid IDCuenta { get; set; }
        public CA CajaAhorro { get; set; }
        public WalletBTC WalletBTC { get; set; }
        public string Nombre { get; set; }
        public Cuenta()
        {

        }
        public Cuenta (Guid _IDCuenta, string _Nombre, CA _CajaAhorro, WalletBTC _WalletBTC)
        {
            IDCuenta = _IDCuenta;
            Nombre = _Nombre;
            CajaAhorro = _CajaAhorro;
            WalletBTC = _WalletBTC;
        }
    }
}
