
namespace marathon_emergency
{
    partial class main_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.server_address_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.database_name_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.check_connection_btn = new System.Windows.Forms.Button();
            this.connect_btn = new System.Windows.Forms.Button();
            this.show_password_check = new System.Windows.Forms.CheckBox();
            this.information_txt = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.selected_database_lbl = new System.Windows.Forms.Label();
            this.check_db_status = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.database_status_lbl = new System.Windows.Forms.Label();
            this.backup_db_btn = new System.Windows.Forms.Button();
            this.backup_path_txt = new System.Windows.Forms.TextBox();
            this.fix_suspect_btn = new System.Windows.Forms.Button();
            this.fix_emergency_btn = new System.Windows.Forms.Button();
            this.open_file_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.backup_filename_txt = new System.Windows.Forms.TextBox();
            this.about_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // server_address_txt
            // 
            this.server_address_txt.Location = new System.Drawing.Point(265, 25);
            this.server_address_txt.Name = "server_address_txt";
            this.server_address_txt.Size = new System.Drawing.Size(482, 27);
            this.server_address_txt.TabIndex = 0;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(265, 91);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(482, 27);
            this.password_txt.TabIndex = 1;
            // 
            // user_txt
            // 
            this.user_txt.Location = new System.Drawing.Point(265, 58);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(482, 27);
            this.user_txt.TabIndex = 2;
            // 
            // database_name_combo
            // 
            this.database_name_combo.FormattingEnabled = true;
            this.database_name_combo.Location = new System.Drawing.Point(265, 125);
            this.database_name_combo.Name = "database_name_combo";
            this.database_name_combo.Size = new System.Drawing.Size(482, 28);
            this.database_name_combo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server namer/ IP address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Database:";
            // 
            // check_connection_btn
            // 
            this.check_connection_btn.Location = new System.Drawing.Point(265, 159);
            this.check_connection_btn.Name = "check_connection_btn";
            this.check_connection_btn.Size = new System.Drawing.Size(173, 29);
            this.check_connection_btn.TabIndex = 8;
            this.check_connection_btn.Text = "CHECK CONNECTION";
            this.check_connection_btn.UseVisualStyleBackColor = true;
            this.check_connection_btn.Click += new System.EventHandler(this.check_connection_btn_Click);
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(444, 159);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(173, 29);
            this.connect_btn.TabIndex = 9;
            this.connect_btn.Text = "CONNECT";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // show_password_check
            // 
            this.show_password_check.AutoSize = true;
            this.show_password_check.Location = new System.Drawing.Point(753, 94);
            this.show_password_check.Name = "show_password_check";
            this.show_password_check.Size = new System.Drawing.Size(75, 24);
            this.show_password_check.TabIndex = 10;
            this.show_password_check.Text = "SHOW";
            this.show_password_check.UseVisualStyleBackColor = true;
            this.show_password_check.CheckedChanged += new System.EventHandler(this.show_password_check_CheckedChanged);
            // 
            // information_txt
            // 
            this.information_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.information_txt.Location = new System.Drawing.Point(13, 357);
            this.information_txt.Name = "information_txt";
            this.information_txt.Size = new System.Drawing.Size(896, 203);
            this.information_txt.TabIndex = 11;
            this.information_txt.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Selected database:";
            // 
            // selected_database_lbl
            // 
            this.selected_database_lbl.AutoSize = true;
            this.selected_database_lbl.Location = new System.Drawing.Point(405, 195);
            this.selected_database_lbl.Name = "selected_database_lbl";
            this.selected_database_lbl.Size = new System.Drawing.Size(0, 20);
            this.selected_database_lbl.TabIndex = 13;
            // 
            // check_db_status
            // 
            this.check_db_status.Location = new System.Drawing.Point(265, 218);
            this.check_db_status.Name = "check_db_status";
            this.check_db_status.Size = new System.Drawing.Size(173, 29);
            this.check_db_status.TabIndex = 14;
            this.check_db_status.Text = "CHECK STATUS";
            this.check_db_status.UseVisualStyleBackColor = true;
            this.check_db_status.Click += new System.EventHandler(this.check_db_status_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Database status:";
            // 
            // database_status_lbl
            // 
            this.database_status_lbl.AutoSize = true;
            this.database_status_lbl.Location = new System.Drawing.Point(567, 222);
            this.database_status_lbl.Name = "database_status_lbl";
            this.database_status_lbl.Size = new System.Drawing.Size(0, 20);
            this.database_status_lbl.TabIndex = 16;
            // 
            // backup_db_btn
            // 
            this.backup_db_btn.Location = new System.Drawing.Point(265, 253);
            this.backup_db_btn.Name = "backup_db_btn";
            this.backup_db_btn.Size = new System.Drawing.Size(173, 29);
            this.backup_db_btn.TabIndex = 17;
            this.backup_db_btn.Text = "BACKUP";
            this.backup_db_btn.UseVisualStyleBackColor = true;
            this.backup_db_btn.Click += new System.EventHandler(this.backup_db_btn_Click);
            // 
            // backup_path_txt
            // 
            this.backup_path_txt.Location = new System.Drawing.Point(445, 253);
            this.backup_path_txt.Name = "backup_path_txt";
            this.backup_path_txt.Size = new System.Drawing.Size(302, 27);
            this.backup_path_txt.TabIndex = 18;
            // 
            // fix_suspect_btn
            // 
            this.fix_suspect_btn.Location = new System.Drawing.Point(265, 311);
            this.fix_suspect_btn.Name = "fix_suspect_btn";
            this.fix_suspect_btn.Size = new System.Drawing.Size(173, 29);
            this.fix_suspect_btn.TabIndex = 19;
            this.fix_suspect_btn.Text = "FIX SUSPECT";
            this.fix_suspect_btn.UseVisualStyleBackColor = true;
            this.fix_suspect_btn.Click += new System.EventHandler(this.fix_suspect_btn_Click);
            // 
            // fix_emergency_btn
            // 
            this.fix_emergency_btn.Location = new System.Drawing.Point(445, 311);
            this.fix_emergency_btn.Name = "fix_emergency_btn";
            this.fix_emergency_btn.Size = new System.Drawing.Size(173, 29);
            this.fix_emergency_btn.TabIndex = 20;
            this.fix_emergency_btn.Text = "FIX EMERGENCY";
            this.fix_emergency_btn.UseVisualStyleBackColor = true;
            this.fix_emergency_btn.Click += new System.EventHandler(this.fix_emergency_btn_Click);
            // 
            // open_file_btn
            // 
            this.open_file_btn.Location = new System.Drawing.Point(753, 253);
            this.open_file_btn.Name = "open_file_btn";
            this.open_file_btn.Size = new System.Drawing.Size(44, 29);
            this.open_file_btn.TabIndex = 21;
            this.open_file_btn.Text = "...";
            this.open_file_btn.UseVisualStyleBackColor = true;
            this.open_file_btn.Click += new System.EventHandler(this.open_file_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Filename:";
            // 
            // backup_filename_txt
            // 
            this.backup_filename_txt.Location = new System.Drawing.Point(445, 282);
            this.backup_filename_txt.Name = "backup_filename_txt";
            this.backup_filename_txt.Size = new System.Drawing.Size(302, 27);
            this.backup_filename_txt.TabIndex = 23;
            // 
            // about_btn
            // 
            this.about_btn.Location = new System.Drawing.Point(0, 25);
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(71, 29);
            this.about_btn.TabIndex = 24;
            this.about_btn.Text = "ABOUT";
            this.about_btn.UseVisualStyleBackColor = true;
            this.about_btn.Click += new System.EventHandler(this.about_btn_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(921, 572);
            this.Controls.Add(this.about_btn);
            this.Controls.Add(this.backup_filename_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.open_file_btn);
            this.Controls.Add(this.fix_emergency_btn);
            this.Controls.Add(this.fix_suspect_btn);
            this.Controls.Add(this.backup_path_txt);
            this.Controls.Add(this.backup_db_btn);
            this.Controls.Add(this.database_status_lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.check_db_status);
            this.Controls.Add(this.selected_database_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.information_txt);
            this.Controls.Add(this.show_password_check);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.check_connection_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.database_name_combo);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.server_address_txt);
            this.Name = "main_form";
            this.Text = "MARATHON EMERGENCY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox server_address_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button check_connection_btn;
        public System.Windows.Forms.ComboBox database_name_combo;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.CheckBox show_password_check;
        private System.Windows.Forms.RichTextBox information_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label selected_database_lbl;
        private System.Windows.Forms.Button check_db_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label database_status_lbl;
        private System.Windows.Forms.Button backup_db_btn;
        private System.Windows.Forms.TextBox backup_path_txt;
        private System.Windows.Forms.Button fix_suspect_btn;
        private System.Windows.Forms.Button fix_emergency_btn;
        private System.Windows.Forms.Button open_file_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox backup_filename_txt;
        private System.Windows.Forms.Button about_btn;
    }
}

