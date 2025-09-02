using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA101
{
    public static class DbConnectionHelper
    {
        private static readonly string connectionString =
            "Data Source=JONATHANNIEZ\\SQLEXPRESS;Initial Catalog=SA101;Integrated Security=True;Encrypt=False";

        public static string GetConnectionString()
        {
            return connectionString;
        }
    }
}
