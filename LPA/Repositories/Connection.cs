using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPA.Repositories
{
    public class Connection : IConnection
    {
        public SqlConnection databaseConnection;
        public void Connect()
        {
            databaseConnection = new SqlConnection("Server=mssql.fhict.local;Database=dbi376400;User Id=dbi376400;Password=qazqaz2;");
            try
            {
                databaseConnection.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void disConnect()
        {
            databaseConnection.Close();
        }

        public SqlConnection getConnection()
        {
            return databaseConnection;
        }
    }
}
