using System;

namespace Domain
{
    public class WalletBTC
    {
        public Guid ID { get; set; }
        public decimal Saldo { get; set; }
        public WalletBTC()
        {

        }
        public WalletBTC(Guid _ID, decimal _Saldo)
        {
            ID = _ID;
            Saldo = _Saldo;
        }
    }
}
