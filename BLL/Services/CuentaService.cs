using BLL.Contracts;
using DAL.Factory;
using Domain;
using System;
using System.Configuration;

namespace BLL.Services
{
    public class CuentaService : ICuentaService
    {
        private decimal ValorBTC = 0;
        private readonly Factory Fact;
        #region Singleton
        private readonly static CuentaService _instance = new CuentaService();
        public static CuentaService Current
        {
            get
            {
                return _instance;
            }
        }
        private CuentaService()
        {
            Fact = Factory.Current;
            ValorBTC = decimal.Parse( ConfigurationManager.AppSettings["Bitcoin"]);
        }
        #endregion
        public Cuenta Ingresar(string Nombre)
        {
            if (String.IsNullOrEmpty(Nombre)) throw new Exception("Debe completar el campo.");
            var cuentaActual = Session.Instance.CuentaActual;
            try
            {
                var usuario = Fact.GetCuentaRepository.GetOne(Nombre);
                if (usuario != null)
                {
                    Session.Instance.IniciarSesion(usuario);
                }
                cuentaActual = Session.Instance.CuentaActual;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cuentaActual ?? throw new Exception("Usuario inexistente.");
        }
        public Cuenta Create(string Nombre, int CUIT, long CBU)
        {
            try
            {
                Cuenta cuenta = Fact.GetCuentaRepository.GetOne(Nombre);
                if (cuenta != null) throw new Exception("Usuario previamente registrado.");
                cuenta = new Cuenta(
                                    Guid.NewGuid(),
                                    Nombre,
                                    new CA(Guid.NewGuid(), CBU, CUIT, 0),
                                    new WalletBTC(Guid.NewGuid(), 0)
                                    );
                Fact.GetCARepository.Insert(cuenta.CajaAhorro);
                Fact.GetWalletBTCRepository.Insert(cuenta.WalletBTC);
                Fact.GetCuentaRepository.Insert(cuenta);
                return cuenta;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public decimal DepositarPesos(decimal monto)
        {
            Session.Instance.CuentaActual.CajaAhorro.Saldo += monto;
            try
            {
                Fact.GetCARepository.Update(Session.Instance.CuentaActual.CajaAhorro);
                Session.Instance.CuentaActual.CajaAhorro = Session.Instance.CuentaActual.CajaAhorro;
                return Session.Instance.CuentaActual.CajaAhorro.Saldo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public decimal ConvertirAPesos(decimal monto)
        {
            decimal nuevopeso = monto * ValorBTC;
            try
            {
                if (monto > Session.Instance.CuentaActual.WalletBTC.Saldo) throw new Exception("Fondos insuficientes.");
                Session.Instance.CuentaActual.CajaAhorro.Saldo += nuevopeso;
                Session.Instance.CuentaActual.WalletBTC.Saldo -= monto;
                Fact.GetWalletBTCRepository.Update(Session.Instance.CuentaActual.WalletBTC);
                Fact.GetCARepository.Update(Session.Instance.CuentaActual.CajaAhorro);
                return Session.Instance.CuentaActual.WalletBTC.Saldo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public decimal ConvertirABTC(decimal monto)
        {
            decimal nuevoBTC = monto / ValorBTC;
            try
            {
                if (monto > Session.Instance.CuentaActual.CajaAhorro.Saldo) throw new Exception("Fondos insuficientes.");
                Session.Instance.CuentaActual.WalletBTC.Saldo += nuevoBTC;
                Session.Instance.CuentaActual.CajaAhorro.Saldo -= monto;
                Fact.GetWalletBTCRepository.Update(Session.Instance.CuentaActual.WalletBTC);
                Fact.GetCARepository.Update(Session.Instance.CuentaActual.CajaAhorro);
                return Session.Instance.CuentaActual.CajaAhorro.Saldo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void TransferirPesos(decimal monto, string destinatario)
        {
            Cuenta cuentadestino = default;
            try
            {
                if (monto > Session.Instance.CuentaActual.CajaAhorro.Saldo) throw new Exception("Fondos insuficientes.");
                cuentadestino = Fact.GetCuentaRepository.GetOne(destinatario);
                if (cuentadestino == null) throw new Exception("Usuario inexistente.");
                Session.Instance.CuentaActual.CajaAhorro.Saldo -= monto;
                cuentadestino.CajaAhorro.Saldo += monto;
                Fact.GetCARepository.Update(Session.Instance.CuentaActual.CajaAhorro);
                Fact.GetCARepository.Update(cuentadestino.CajaAhorro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void TransferirBTC(decimal monto, string destinatario)
        {
            Cuenta cuentadestino = default;
            try
            {
                if (monto > Session.Instance.CuentaActual.WalletBTC.Saldo) throw new Exception("Fondos insuficientes.");
                cuentadestino = Fact.GetCuentaRepository.GetOne(destinatario);
                if (cuentadestino == null) throw new Exception("Usuario inexistente.");
                Session.Instance.CuentaActual.WalletBTC.Saldo -= monto;
                cuentadestino.WalletBTC.Saldo += monto;
                Fact.GetWalletBTCRepository.Update(Session.Instance.CuentaActual.WalletBTC);
                Fact.GetWalletBTCRepository.Update(cuentadestino.WalletBTC);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
