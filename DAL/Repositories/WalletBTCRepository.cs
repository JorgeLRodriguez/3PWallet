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
    internal class WalletBTCRepository : IGenericRepository<WalletBTC>
    {
        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[WalletBTC] ([ID_BTC] ,[Saldo]) VALUES (@ID_BTC,@Saldo)";
        }
        private string SelectOneStatement
        {
            get => "SELECT [ID_BTC],[Saldo] FROM [dbo].[WalletBTC] WHERE ID_BTC = @ID_BTC";
        }
        private string UpdateStatement
        {
            get => "UPDATE [dbo].[WalletBTC] SET [Saldo] = @Saldo WHERE ID_BTC = @ID_BTC";
        }
        #endregion
        public WalletBTC GetOne(Guid id)
        {
            WalletBTC BTC = default;
            using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text,
                                                    new SqlParameter[] { new SqlParameter("@ID_BTC", id) }))
            {
                if (dr.Read())
                {
                    object[] values = new object[dr.FieldCount];
                    dr.GetValues(values);
                    BTC = WalletBTCAdapter.Current.Adapt(values);
                }
            }
            return BTC;
        }
        public void Insert(WalletBTC obj)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@ID_BTC", obj.ID);
            parameters[1] = new SqlParameter("@Saldo", obj.Saldo);
            SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, parameters);
        }
        public void Update(WalletBTC obj)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@ID_BTC", obj.ID);
            parameters[1] = new SqlParameter("@Saldo", obj.Saldo);
            SqlHelper.ExecuteNonQuery(UpdateStatement, System.Data.CommandType.Text, parameters);
        }
    }
}
