using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace marathon_emergency.Class
{
    class fix_db
    {
        public static string fix_emergency(string server_name, string username, string password, string db_name)
        {
            List<string> messages = new List<string>();

            string connectionString = "Data Source=" + server_name + ";User ID=" + username + ";Password=" + password + ";Initial Catalog=" + db_name + ";";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();


            string check_db_query = "DBCC CHECKDB('" + db_name + "')";
            SqlCommand cmd_check_db = new SqlCommand(check_db_query, conn);
            cmd_check_db.ExecuteNonQuery();
            messages.Add("Check db "+db_name);

            string set_single_user_query = "ALTER DATABASE " + db_name + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
            SqlCommand cmd_set_single_user = new SqlCommand(set_single_user_query, conn);
            cmd_set_single_user.ExecuteNonQuery();
            messages.Add("Database "+db_name+" set single user access");

            string repair_allow_data_loss_query = "DBCC CHECKDB('" + db_name + "',REPAIR_ALLOW_DATA_LOSS)";
            SqlCommand cmd_repair_allow_data_loss = new SqlCommand(repair_allow_data_loss_query, conn);
            cmd_repair_allow_data_loss.ExecuteNonQuery();
            messages.Add("Database " + db_name + "Try repair allow data");

            string repair_rebuild_query = "DBCC CHECKDB('" + db_name + "', REPAIR_REBUILD)";
            SqlCommand cmd_repair_rebuild = new SqlCommand(repair_rebuild_query, conn);
            cmd_repair_rebuild.ExecuteNonQuery();
            messages.Add("Database " + db_name + " Try rebuild data");

            string set_multi_user_query = "ALTER DATABASE " + db_name + " SET MULTI_USER";
            SqlCommand cmd_set_multi_user = new SqlCommand(set_multi_user_query, conn);
            cmd_set_multi_user.ExecuteNonQuery();
            messages.Add("Database " + db_name + " set multi user access");

            foreach(string message in messages)
            {
                main_form.fix_emergency_messages.Add(message);
            }


            return messages.ToString();
        }

        public static string fix_suspect(string server_name, string username, string password, string db_name)
        {
            List<string> messages = new List<string>();

            string connectionString = "Data Source=" + server_name + ";User ID=" + username + ";Password=" + password + ";Initial Catalog=" + db_name + ";";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string resetstatus_query = "EXEC sp_resetstatus '" + db_name + "'";
            SqlCommand cmd_resetstatus = new SqlCommand(resetstatus_query, conn);
            cmd_resetstatus.ExecuteNonQuery();
            messages.Add("Reset status of database "+db_name);

            string set_emergency_query = "ALTER DATABASE " + db_name + " SET EMERGENCY";
            SqlCommand cmd_set_emergency = new SqlCommand(set_emergency_query, conn);
            cmd_set_emergency.ExecuteNonQuery();
            messages.Add("Set emergency database " + db_name);

            string check_db_query = "DBCC CHECKDB('" + db_name + "')";
            SqlCommand cmd_check_db = new SqlCommand(check_db_query, conn);
            cmd_check_db.ExecuteNonQuery();
            messages.Add("Check db " + db_name);

            string set_single_user_query = "ALTER DATABASE " + db_name + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
            SqlCommand cmd_set_single_user = new SqlCommand(set_single_user_query, conn);
            cmd_set_single_user.ExecuteNonQuery();
            messages.Add("Database " + db_name + " set single user access");

            string repair_allow_data_loss_query = "DBCC CHECKDB('" + db_name + "',REPAIR_ALLOW_DATA_LOSS)";
            SqlCommand cmd_repair_allow_data_loss = new SqlCommand(repair_allow_data_loss_query, conn);
            cmd_repair_allow_data_loss.ExecuteNonQuery();
            messages.Add("Database " + db_name + "Try repair allow data");

            string repair_rebuild_query = "DBCC CHECKDB('" + db_name + "', REPAIR_REBUILD)";
            SqlCommand cmd_repair_rebuild = new SqlCommand(repair_rebuild_query, conn);
            cmd_repair_rebuild.ExecuteNonQuery();
            messages.Add("Database " + db_name + " Try rebuild data");

            string set_multi_user_query = "ALTER DATABASE " + db_name + " SET MULTI_USER";
            SqlCommand cmd_set_multi_user = new SqlCommand(set_multi_user_query, conn);
            cmd_set_multi_user.ExecuteNonQuery();
            messages.Add("Database " + db_name + " set multi user access");

            foreach (string message in messages)
            {
                main_form.fix_suspect_messages.Add(message);
            }


            return messages.ToString();
        }
    }
}
