using DAL.Contracts;
using DAL.Repositories;
using Domain;

namespace DAL.Factory
{
    public sealed class Factory
    {
        #region Singleton
        private readonly static Factory _instance = new Factory();
        public static Factory Current
        {
            get
            {
                return _instance;
            }
        }
        private Factory()
        {
            GetCuentaRepository = new CuentaRepository();
            GetWalletBTCRepository = new WalletBTCRepository();
            GetCARepository = new CARepository();
        }
        #endregion
        public ICuentaRepository GetCuentaRepository { get; }
        public IGenericRepository<WalletBTC> GetWalletBTCRepository { get; }
        public IGenericRepository<CA> GetCARepository { get; }
    }
}
