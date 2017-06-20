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
            databaseConnection = new SqlConnection("Server=127.0.0.1;Database=LPA;User Id=lpa;Password=qazqaz2;");
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
