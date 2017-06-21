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
            connection.Connect();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Partij (naam, lijsttrekker) VALUES (@naam, @lijsttrekker)", connection.getConnection());

            sqlCommand.Parameters.AddWithValue("@naam", naam);
            sqlCommand.Parameters.AddWithValue("@lijsttrekker", lijsttrekker);

            sqlCommand.Connection = connection.getConnection();

            sqlCommand.ExecuteNonQuery();
        }

        public void deletePartij(string naam)
        {
            connection.Connect();
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Partij WHERE naam like @naam", connection.getConnection());

            sqlCommand.Parameters.AddWithValue("@naam", naam);

            sqlCommand.Connection = connection.getConnection();

            sqlCommand.ExecuteNonQuery();
        }

        public List<Partij> getPartij()
        {
            List<Partij> partijLijst = new List<Partij>();
            connection.Connect();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Partij", connection.getConnection());
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
                lijsttrekker = Convert.ToString(reader["lijsttrekker"])
            };
            return partij;
        }

        public void zetelUpdate(Partij partij)
        {
            SqlCommand command = new SqlCommand("UPDATE Uitslag_Partij SET votes = @votes, seats = @seats WHERE id = @id", connection.getConnection());
            command.Parameters.AddWithValue("@stem", partij.stemmers);
            command.Parameters.AddWithValue("@zetel", partij.zetels);
            command.Parameters.AddWithValue("@id", partij.id);

            command.ExecuteNonQuery();
        }

        private int AlleStemmers(int uitslagID)
        {
            connection.Connect();
            SqlCommand sqlCommand = new SqlCommand("SELECT SUM(Stemmen) FROM Uitslag_Partij INNER JOIN Uitslag u on FK_IDUitslag = u.ID WHERE u.id = @uitslagID", connection.getConnection());
            sqlCommand.Parameters.AddWithValue("@uitslagID", uitslagID);
           int result = (int)sqlCommand.ExecuteScalar();
            connection.disConnect();
            return result;
        }

        public void Zetels(int uitslagID)
        {
            int totaal_Stemmers = AlleStemmers(uitslagID);
            List<Partij> partijLijst = new List<Partij>();
            foreach (Partij partij in partijLijst)
            {
                decimal bstem = Convert.ToDecimal(partij.stemmers);
                decimal btotaalStem = Convert.ToDecimal(totaal_Stemmers);
                decimal bTotaalZetels = Convert.ToDecimal(150);

                partij.zetels = Convert.ToInt32(Math.Floor(bstem / btotaalStem * bTotaalZetels));
                zetelUpdate(partij);
            }
        }

        public List<Partij> getPartijMet(int uitslagID)
        {
            List<Partij> partijLijst = new List<Partij>();
            connection.Connect();
            SqlCommand sqlCommand = new SqlCommand("SELECT p.ID, p.Lijsttrekker, p.Naam, up.Stemmen, up.Zetels FROM Partij p INNER JOIN Uitslag_Partij up on ID = up.FK_IDPartij INNER JOIN Uitslag u on FK_IDUitslag = u.ID WHERE u.id = @uitslagID", connection.getConnection());
            sqlCommand.Parameters.AddWithValue("@uitslagID", uitslagID);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    partijLijst.Add(CreatePartijMetFromReader(reader));
                }
            }

            connection.disConnect();
            return partijLijst;
        }

        private Partij CreatePartijMetFromReader(SqlDataReader reader)
        {
            Partij partij = new Partij
            {
                id = Convert.ToInt32(reader["ID"]),
                naam = Convert.ToString(reader["naam"]),
                lijsttrekker = Convert.ToString(reader["lijsttrekker"]),
                stemmers = Convert.ToInt32(reader["Stemmen"]),
                zetels = Convert.ToInt32(reader["zetels"])
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
