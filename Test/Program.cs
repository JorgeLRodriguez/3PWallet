using BLL;
using BLL.Contracts;
using BLL.Services;
using System;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            new Test().Execute();
        }

        class Test { 
        public void Execute()
            {
                string Destinatario = "";
                decimal MontoPesos = 0;
                decimal MontoBTC = 0;

                Console.WriteLine("Hello World!");
                ICuentaService service = CuentaService.Current;

                service.Create("Jorge", 11111, 22222);
                Console.WriteLine("Usuario {0} registrado.", Session.Instance.CuentaActual.Nombre);
                service.Create("Luis", 33333, 44444);
                Console.WriteLine("Usuario {0} registrado.", Session.Instance.CuentaActual.Nombre);

                service.Ingresar("Jorge");
                Console.WriteLine("Usuario {0} ingresado.", Session.Instance.CuentaActual.Nombre);

                service.DepositarPesos(1000);
                Console.WriteLine("Usuario {0} deposito  ${1}.", Session.Instance.CuentaActual.Nombre, Session.Instance.CuentaActual.CajaAhorro.Saldo);

                Destinatario = "Luis";
                MontoPesos = 100;
                service.TransferirPesos(MontoPesos, Destinatario);
                Console.WriteLine("Usuario {0} transfirio  ${1} a {2}.", Session.Instance.CuentaActual.Nombre, MontoPesos, Destinatario);

                MontoPesos = 300;
                MontoBTC = service.ConvertirABTC(MontoPesos);
                Console.WriteLine("Usuario {0} convirtio  ${1} a BTC:{2}.", Session.Instance.CuentaActual.Nombre, MontoPesos, MontoBTC);

                MontoBTC = 1;
                Destinatario = "Luis";
                service.TransferirBTC(MontoBTC, Destinatario);
                Console.WriteLine("Usuario {0} transfirio  BTC{1} a {2}.", Session.Instance.CuentaActual.Nombre, MontoBTC, Destinatario);

                MontoBTC = 1;
                MontoPesos = service.ConvertirAPesos(MontoBTC);
                Console.WriteLine("Usuario {0} convirtio BTC{1} a ${2}.", Session.Instance.CuentaActual.Nombre, MontoBTC, MontoPesos);
            }

        }
    }
}
