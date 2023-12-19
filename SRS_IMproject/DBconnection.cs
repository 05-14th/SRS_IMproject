using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SRS_IMproject
{
    internal class DBconnection
    {
        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;database=Srsproject;user=root;password=");

        MySqlCommand cmd;
        MySqlDataAdapter adapt;

        public MySqlConnection GetConnection()
        {
            return connect;
        }

        public void OpenConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }

        public void CloseConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }
    }
}
