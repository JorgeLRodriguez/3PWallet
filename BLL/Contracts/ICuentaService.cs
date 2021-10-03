using Domain;

namespace BLL.Contracts
{
    public interface ICuentaService
    {
        Cuenta Create(string Nombre, int CUIT, long CBU);
        Cuenta Ingresar(string Nombre);
        decimal DepositarPesos(decimal monto);
        decimal ConvertirAPesos(decimal monto);
        decimal ConvertirABTC(decimal monto);
        void TransferirPesos(decimal monto, string destinatario);
        void TransferirBTC(decimal monto, string destinatario);
    }
}
