using System;

namespace Domain
{
    public class CA
    {
        public Guid ID_CA { get; set; }
        public long CBU { get; set; }
        public int CUIT { get; set; }
        public decimal Saldo { get; set; }
        public CA()
        {

        }
        public CA(Guid _ID_CA, long _CBU, int _CUIT, decimal _Saldo)
        {
            ID_CA = _ID_CA;
            CBU = _CBU;
            CUIT = _CUIT;
            Saldo = _Saldo;
        }
    }
}