using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Rent_A_Car
{
    class Connection
    {
        public SqlConnection Baglanti()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ENESKIZILCA\SQLEXPRESS;
                Initial Catalog=DboRent-A-Car;Integrated Security=True");

            connection.Open();
            return connection;
        }
    }
}
