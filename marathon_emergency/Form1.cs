using marathon_emergency.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace marathon_emergency
{
    public partial class main_form : Form
    {
        public static List<string> databases = new List<string>();
        public static List<string> fix_emergency_messages = new List<string>();
        public static List<string> fix_suspect_messages = new List<string>();
        public main_form()
        {
            InitializeComponent();
            

            
        }

        private void check_connection_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(db_connection.check_connection(server_address_txt.Text, user_txt.Text, password_txt.Text));
            information_txt.Text += db_connection.check_connection(server_address_txt.Text, user_txt.Text, password_txt.Text).ToString()+Environment.NewLine;
            db_connection.download_databases_list(server_address_txt.Text, user_txt.Text, password_txt.Text).ToString();
            foreach(string database in databases)
            {
                database_name_combo.Items.Add(database);
            }
           
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                db_connection.connect_db(server_address_txt.Text, user_txt.Text, password_txt.Text, database_name_combo.SelectedItem.ToString());
                selected_database_lbl.Text = database_name_combo.SelectedItem.ToString();
                information_txt.Text += "Successfully selected and connection "+Environment.NewLine;
                information_txt.Text += "Selected database: " + selected_database_lbl.Text + Environment.NewLine;

            }
            catch(Exception exception)
            {
                MessageBox.Show("Select a database");
                information_txt.Text += exception.ToString()+Environment.NewLine;
            }
        }

        private void check_db_status_Click(object sender, EventArgs e)
        {
            try
            {
                database_status_lbl.Text=db_connection.check_db_status(server_address_txt.Text, user_txt.Text, password_txt.Text, database_name_combo.SelectedItem.ToString());
                information_txt.Text += db_connection.check_db_status(server_address_txt.Text, user_txt.Text, password_txt.Text, database_name_combo.SelectedItem.ToString()) + Environment.NewLine;
            }
            catch(Exception exception)
            {
                information_txt.Text += exception.ToString() + Environment.NewLine;
            }
        }

        private void backup_db_btn_Click(object sender, EventArgs e)
        {
            db_connection.backup_db(server_address_txt.Text, user_txt.Text, password_txt.Text, database_name_combo.SelectedItem.ToString(), backup_path_txt.Text+@"\"+backup_filename_txt.Text);
            information_txt.Text += "Backup started" + Environment.NewLine;
        }

        private void fix_emergency_btn_Click(object sender, EventArgs e)
        {
            fix_db.fix_emergency(server_address_txt.Text, user_txt.Text, password_txt.Text, database_name_combo.SelectedItem.ToString());

            foreach(string message in fix_emergency_messages)
            {
                information_txt.Text += message + Environment.NewLine;
            }
            information_txt.Text += "Action end. Check database status" + Environment.NewLine;
        }

        private void fix_suspect_btn_Click(object sender, EventArgs e)
        {
            fix_db.fix_suspect(server_address_txt.Text, user_txt.Text, password_txt.Text, database_name_combo.SelectedItem.ToString());

            foreach(string message in fix_suspect_messages)
            {
                information_txt.Text += message + Environment.NewLine;
            }
            information_txt.Text += "Action end. Check database status" + Environment.NewLine;
        }

        private void show_password_check_CheckedChanged(object sender, EventArgs e)
        {
            if(show_password_check.Checked==true)
            {
                password_txt.PasswordChar = '\0';
            }
            else
            {
                password_txt.PasswordChar = '*';
            }
        }

        private void open_file_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog backup_browser_dialog = new FolderBrowserDialog();
            if(backup_browser_dialog.ShowDialog()==DialogResult.OK)
            {
                backup_path_txt.Text = backup_browser_dialog.SelectedPath;
            }
            
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            about_form about = new about_form();
            about.Show();
        }
    }
}
