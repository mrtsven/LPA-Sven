using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPA.Domain;
using System.Data.SqlClient;

namespace LPA.Repositories
{
    public class PartijRepo : IPartijRepo
    {
        IConnection connection;
        public PartijRepo(IConnection connection)
        {
            this.connection = connection;
        }

        public void createPartij(string naam, string lijsttrekker)
        {
            throw new NotImplementedException();
        }

        public void deletePartij(string naam)
        {
            throw new NotImplementedException();
        }

        public List<Partij> getPartij()
        {
            List<Partij> partijLijst = new List<Partij>();
            connection.Connect();
            SqlCommand sqlCommand = new SqlCommand("SELECT * from Partij", connection.getConnection());
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    partijLijst.Add(CreatePartijFromReader(reader));
                }
            }

            connection.disConnect();
            return partijLijst;
        }

        private Partij CreatePartijFromReader(SqlDataReader reader)
        {
            Partij partij = new Partij
            {
                id = Convert.ToInt32(reader["ID"]),
                naam = Convert.ToString(reader["naam"]),
                lijsttrekker = Convert.ToString(reader["lijsttrekker"]),
            };
            return partij;
        }

        public void updatePartij(string naam, string nieuwenaam, string nieuwelijsttrekker)
        {
            try
            {
                connection.Connect();
                SqlCommand sqlCommand = new SqlCommand("UPDATE Partij SET naam=@newnaam, lijsttrekker=@newlijsttrekker where naam like @naam", connection.getConnection());

                sqlCommand.Parameters.AddWithValue("@naam", naam);
                sqlCommand.Parameters.AddWithValue("@newnaam", nieuwenaam);
                sqlCommand.Parameters.AddWithValue("@newlijsttrekker", nieuwelijsttrekker);
                sqlCommand.Connection = connection.getConnection();

                sqlCommand.ExecuteNonQuery();
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                connection.disConnect();
            }
        }


    }
}
