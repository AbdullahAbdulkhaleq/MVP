using System;
using System.Data;
using System.Data.SqlClient;

namespace MVP.Presenter
{
    public class Helper
    {
        public static SqlCommand command = null;
        public static SqlConnection GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.InitialCatalog = "Library";
            builder.IntegratedSecurity = true;
            return new SqlConnection(builder.ConnectionString);
        }
        public static bool setData(string ProcedureName, Action Procedureparameters)
        {
            using(SqlConnection connection = GetConnectionString())
            {
                try
                {
                    command = new SqlCommand(ProcedureName, connection);
                    command.CommandType =CommandType.StoredProcedure;
                    Procedureparameters.Invoke();
                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
