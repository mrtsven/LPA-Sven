using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPA.Repositories
{
    public interface IConnection
    {
        void Connect();
        void disConnect();
        SqlConnection getConnection();
    }
}
