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
            List<Uitslag> uitslagLijst = new List<Uitslag>();
            connection.Connect();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Uitslag", connection.getConnection());
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    uitslagLijst.Add(CreateUitslagFromReader(reader));
                }
            }

            connection.disConnect();
            return uitslagLijst;
        }

        private Uitslag CreateUitslagFromReader(SqlDataReader reader)
        {
            Uitslag uitslag = new Uitslag
            {
                id = Convert.ToInt32(reader["ID"]),
                naam = Convert.ToString(reader["uitslagnaam"]),
                datum = Convert.ToString(reader["datum"])

            };
            return uitslag;
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
