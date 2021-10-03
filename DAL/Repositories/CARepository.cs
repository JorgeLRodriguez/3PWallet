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
    internal class CARepository : IGenericRepository<CA>
    {
        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[CA]([ID_CA],[CBU],[CUIT],[Saldo])VALUES(@ID_CA,@CBU,@CUIT,@Saldo)";
        }
        private string SelectOneStatement
        {
            get => "SELECT [ID_CA],[CBU],[CUIT],[Saldo]  FROM [dbo].[CA] WHERE ID_CA = @ID_CA";
        }
        private string UpdateStatement
        {
            get => "UPDATE [dbo].[CA] SET [CBU] = @CBU, [CUIT] = @CUIT, [Saldo] = @Saldo WHERE ID_CA = @ID_CA";
        }
        #endregion
        public CA GetOne(Guid id)
        {
            CA CA = default;
            using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text,
                                                    new SqlParameter[] { new SqlParameter("@ID_CA", id) }))
            {
                if (dr.Read())
                {
                    object[] values = new object[dr.FieldCount];
                    dr.GetValues(values);
                    CA = CAAdapter.Current.Adapt(values);
                }
            }
            return CA;
        }
        public void Insert(CA obj)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@ID_CA", obj.ID_CA);
            parameters[1] = new SqlParameter("@CBU", obj.CBU);
            parameters[2] = new SqlParameter("@CUIT", obj.CUIT);
            parameters[3] = new SqlParameter("@Saldo", obj.Saldo);
            SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, parameters);
        }
        public void Update(CA obj)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@ID_CA", obj.ID_CA);
            parameters[1] = new SqlParameter("@CBU", obj.CBU);
            parameters[2] = new SqlParameter("@CUIT", obj.CUIT);
            parameters[3] = new SqlParameter("@Saldo", obj.Saldo);
            SqlHelper.ExecuteNonQuery(UpdateStatement, System.Data.CommandType.Text, parameters);
        }
    }
}
