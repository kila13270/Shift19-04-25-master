using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shift
{
    public class ApplicationDb
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=usersdb";
        public ApplicationDb()
        {

        }
        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
