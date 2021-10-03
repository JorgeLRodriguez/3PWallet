using Domain;
using System;

namespace BLL
{
    public class Session
    {
        #region "Singleton"

        private static readonly Lazy<Session> DefaultInstance =
            new Lazy<Session>(() => new Session());

        public static Session Instance
        {
            get { return DefaultInstance.Value; }
        }

        #endregion
        private Cuenta _cuenta;
        public Cuenta CuentaActual
        {
            get { return _cuenta; }
            private set { _cuenta = value; }
        }
        public void IniciarSesion(Cuenta cuenta)
        {
            CuentaActual = cuenta;
        }
    }
}
