using DAL.Contracts;
using DAL.Repositories.Adapters;
using DAL.Tools;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    internal class CuentaRepository : ICuentaRepository
    {
        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Cuenta]([ID_CUENTA],[ID_CA],[ID_BTC],[NombreUsuario])VALUES(@ID_CUENTA,@ID_CA,@ID_BTC,@Usuario)";
        }
        private string SelectOneStatement
        {
            get => "SELECT [ID_CUENTA],[ID_CA],[ID_BTC],[NombreUsuario] FROM [dbo].[Cuenta] WHERE NombreUsuario = @Nombre";
        }
        #endregion
        public Cuenta GetOne(string Nombre)
        {
            Cuenta cuenta = default;
            using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text,
                                                    new SqlParameter[] { new SqlParameter("@Nombre", Nombre) }))
            {
                if (dr.Read())
                {
                    object[] values = new object[dr.FieldCount];
                    dr.GetValues(values);

                    cuenta = CuentaAdapter.Current.Adapt(values);
                }
            }
            return cuenta;
        }
        public void Insert(Cuenta obj)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@ID_CUENTA", obj.IDCuenta);
            parameters[1] = new SqlParameter("@ID_CA", obj.CajaAhorro.ID_CA);
            parameters[2] = new SqlParameter("@ID_BTC", obj.WalletBTC.ID);
            parameters[3] = new SqlParameter("@Usuario", obj.Nombre);
            SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, parameters);
        }
    }
}
