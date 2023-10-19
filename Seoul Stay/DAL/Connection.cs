using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seoul_Stay.DAL
{
    internal static class Connection
    {
        private static readonly string ConnectionString = "server=Fabrica1\\SQLEXPRESS;Initial Catalog=Sesion1;Integrated Security=true;";
        public static SqlConnection GetConnection()=> new SqlConnection(ConnectionString);
    }
}
