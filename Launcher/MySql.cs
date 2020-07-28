using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

/*namespace Launcher
{
    public class MySql
    {
        private static MySqlConnection dbconnection;
        private static string server;
        private static string database;
        private static string user;
        private static string password;
        private static string port;
        private static string sslM;
        public static string result;

        public static string Selectsql(string task)
        {
            server = "localhost";
            database = "launchertest";
            user = "root";
            password = "";
            port = "3306";
            sslM = "none";
            string connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

        string query = string.Format(task);
            dbconnection = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, dbconnection);
            try
            {
                dbconnection.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    result = reader.GetString(0);
                    //MessageBox.Show(result);
                    return result;
                }

                reader.Close();

                dbconnection.Close();
                result = null;
                return result;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "error");
                return result;
            }
        }
    }
}*/
