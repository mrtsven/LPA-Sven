using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPA.Domain;
using System.Data.SqlClient;

namespace LPA.Repositories
{
    public class UitslagRepo : IUitslagRepo
    {
        IConnection connection;
        public UitslagRepo(IConnection connection)
        {
            this.connection = connection;
        }

        // int IDPartij, int stemmen
        public void createUitslag(string uitslagNaam, string datum)
        {
            SqlCommand sqlCommand = new SqlCommand("NieuweUitslag", connection.getConnection());

            connection.Connect();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@UitslagNaam", uitslagNaam);
            sqlCommand.Parameters.AddWithValue("@Datum", datum);

            sqlCommand.Connection = connection.getConnection();

            sqlCommand.ExecuteNonQuery();
        }

        public List<Uitslag> getUitslag()
        {
            throw new NotImplementedException();
        }

        public void voegStemmenIn(int idPartij, int stemmen, string uitslagNaam)
        {
            SqlCommand sqlCommand = new SqlCommand("StemmenInvoeren", connection.getConnection());

            connection.Connect();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@IDPartij", idPartij);
            sqlCommand.Parameters.AddWithValue("@Stemmen", stemmen);
            sqlCommand.Parameters.AddWithValue("@UitslagNaam", uitslagNaam);

            sqlCommand.Connection = connection.getConnection();

            sqlCommand.ExecuteNonQuery();
        }
    }
}
