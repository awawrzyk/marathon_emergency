using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace marathon_emergency.Class
{
    class db_connection
    {
        
        public static string check_connection(string server_name, string username, string password)
        {
            string message;
            string connectionString="Data Source="+server_name+";User ID="+username+";Password="+password+";";
            using(SqlConnection conn=new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    message = "Connection successfull";
                }
                catch(SqlException exception)
                {
                    message = exception.ToString();
                }
            }

            return message;
        }

        public static string download_databases_list(string server_name, string username, string password)
        {
            List<string> databases_list = new List<string>();
     
            string message;
            string connectionString = "Data Source=" + server_name + ";User ID=" + username + ";Password=" + password + ";";
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "SELECT name FROM master.sys.databases";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                using (IDataReader reader=sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        databases_list.Add(reader[0].ToString());

                    }
                    reader.Close();
                }
            }
            catch(SqlException exception)
            {
                message = exception.ToString();
                MessageBox.Show(message);
            }
            foreach(string database in databases_list)
            {
                main_form.databases.Add(database);
            }
            return databases_list.ToString();
        }

        public static string connect_db(string server_name, string username, string password, string db_name)
        {
  
            string message;
            string connectionString = "Data Source=" + server_name + ";User ID=" + username + ";Password=" + password + ";Initial Catalog="+db_name+";";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    message = "Connection successfull";
                }
                catch (SqlException exception)
                {
                    message = exception.ToString();
                }
            }

            return message;
        }

        public static string check_db_status(string server_name, string username, string password, string db_name)
        {
            string status;
            
            string connectionString = "Data Source=" + server_name + ";User ID=" + username + ";Password=" + password + ";Initial Catalog=" + db_name + ";";
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "SELECT state_desc DatabaseStatus_sysDatabase FROM sys.databases WHERE name='" + db_name+"'";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            conn.Open();
            status = sqlCommand.ExecuteScalar().ToString();
            conn.Close();
            return status;
        }

        public static string backup_db(string server_name, string username, string password, string db_name, string file_path)
        {
            try
            {
                Server server = new Server(new ServerConnection(server_name, username, password));
                Backup backup = new Backup() { Action = BackupActionType.Database, Database = db_name };
                backup.Devices.AddDevice(file_path, DeviceType.File);
                backup.Initialize = true;
                backup.SqlBackup(server);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

            return " Backup";
        }

       
        
    }
}
