using LPA.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPA.Repositories
{
    public class PartijRepo : IPartijRepo
    {
        IConnection connection;
        public PartijRepo(IConnection connection)
        {
            this.connection = connection;
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
    }
}
