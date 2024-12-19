using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ZatcaEInvoicing
{
    public class ConnectionDB
    {
        private static String connectionString = "Data Source=AXSERVER\\SQL2016;Initial Catalog=ZatcaEInvoicing;Integrated Security=True";

        public static string connection
        {
            get
            {
                return connectionString;
            }

            set
            {
                connectionString = value;
            }

        }

    }
}
