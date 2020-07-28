using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Launcher.encryption;

namespace Launcher
{
    class login
    {
        public static string MySqlresult;
        public static string usernameresult = string.Empty;
        public static string passwordresult = string.Empty;
        public static bool Auth(string username, string password)
        {
            string usercrypt = sha256_hash(username);
            string passcrypt = password = sha256_hash(password);
            string systemname = string.Empty;
            string driveid = string.Empty;
            string cpuid = string.Empty;
            string motherboardid = string.Empty;

            systemname = Environment.MachineName;
            driveid = Driveid();
            cpuid = Cpuid();
            motherboardid = Motherboardid();
            //MessageBox.Show("user " + usercrypt);
            //MessageBox.Show("pass " + passcrypt);
            Selectsql("SELECT * FROM users WHERE username = '" + usercrypt + "';", 0);
            //MessageBox.Show("user result " + MySqlresult);
            Selectsql("SELECT * FROM users WHERE password = '" + passcrypt + "';", 1);
            //MessageBox.Show("pass result " + MySqlresult);
            //MessageBox.Show("user input " + usercrypt + " user result " + usernameresult + " pass input " + passcrypt + " pass database " + passwordresult);
            if (usernameresult == usercrypt)
            {
                if (passwordresult == passcrypt)
                {
                    //MessageBox.Show("authed");
                    return true;
                }
                else
                {
                    //MessageBox.Show("password wrong");
                    return false;
                }
            }
            else
            {
                //MessageBox.Show("username wrong");
                return false;
            }
            // insert account into database for testing purposes
            /*username = sha256_hash(username);
            password = sha256_hash(password);
            systemname = sha256_hash(systemname);
            driveid = sha256_hash(driveid);
            cpuid = sha256_hash(cpuid);
            motherboardid = sha256_hash(motherboardid);
            Insertsql("INSERT INTO users (username, password, systemname, diskid, cpuid, motherboardid, permission_level, user_active) VALUES ('" + username + "','" + password + "','" + systemname + "','" + driveid + "','" + cpuid + "','" + motherboardid + "', '1', '0');");
            MessageBox.Show("injected");
            return false;*/
        }

        private static string Driveid()
        {
            ManagementObject dsk = new ManagementObject(@"win32_logicaldisk.deviceid=""c:""");
            string driveid = "";
            dsk.Get();
            driveid = dsk["VolumeSerialNumber"].ToString();
            return driveid;
        }

        private static string Cpuid()
        {
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_processor");
            mbsList = mbs.Get();
            string cpuid = "";
            foreach (ManagementObject mo in mbsList)
            {
                cpuid = mo["ProcessorID"].ToString();
            }
            return cpuid;
        }
        private static string Motherboardid()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection moc = mos.Get();
            string motherboardid = "";
            foreach (ManagementObject mo in moc)
            {
                motherboardid = (string)mo["SerialNumber"];
            }
            return motherboardid;
        }
        private static MySqlConnection dbconnection;
        private static string server;
        private static string database;
        private static string user;
        private static string password;
        private static string port;
        private static string sslM;

        private static void Selectsql(string task, int column)
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
                    usernameresult = reader.GetString("username");
                    passwordresult = reader.GetString("password");
                    //MessageBox.Show(MySqlresult, "Selectsql result");
                }

                reader.Close();

                dbconnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }
        private static void Insertsql(string task)
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

                cmd.ExecuteNonQuery();

                dbconnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
