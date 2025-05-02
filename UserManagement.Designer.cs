namespace AppInventory
{
    partial class UserManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textboxusername = new System.Windows.Forms.TextBox();
            this.textboxnama = new System.Windows.Forms.TextBox();
            this.textboxpassword = new System.Windows.Forms.TextBox();
            this.btninput = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btntutup = new System.Windows.Forms.Button();
            this.tabellistuser = new System.Windows.Forms.DataGridView();
            this.btninventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabellistuser)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(130, 60);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(68, 13);
            this.username.TabIndex = 0;
            this.username.Text = "USERNAME";
            this.username.Click += new System.EventHandler(this.label1_Click);
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Location = new System.Drawing.Point(130, 88);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(38, 13);
            this.nama.TabIndex = 1;
            this.nama.Text = "NAMA";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(130, 117);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(70, 13);
            this.password.TabIndex = 2;
            this.password.Text = "PASSWORD";
            // 
            // textboxusername
            // 
            this.textboxusername.Location = new System.Drawing.Point(230, 53);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(126, 20);
            this.textboxusername.TabIndex = 3;
            // 
            // textboxnama
            // 
            this.textboxnama.Location = new System.Drawing.Point(230, 81);
            this.textboxnama.Name = "textboxnama";
            this.textboxnama.Size = new System.Drawing.Size(126, 20);
            this.textboxnama.TabIndex = 4;
            // 
            // textboxpassword
            // 
            this.textboxpassword.Location = new System.Drawing.Point(230, 114);
            this.textboxpassword.Name = "textboxpassword";
            this.textboxpassword.Size = new System.Drawing.Size(126, 20);
            this.textboxpassword.TabIndex = 5;
            // 
            // btninput
            // 
            this.btninput.Location = new System.Drawing.Point(160, 162);
            this.btninput.Name = "btninput";
            this.btninput.Size = new System.Drawing.Size(75, 23);
            this.btninput.TabIndex = 6;
            this.btninput.Text = "INPUT";
            this.btninput.UseVisualStyleBackColor = true;
            this.btninput.Click += new System.EventHandler(this.btninput_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(241, 162);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 7;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(322, 162);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 23);
            this.btnhapus.TabIndex = 8;
            this.btnhapus.Text = "HAPUS";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btntutup
            // 
            this.btntutup.Location = new System.Drawing.Point(403, 162);
            this.btntutup.Name = "btntutup";
            this.btntutup.Size = new System.Drawing.Size(75, 23);
            this.btntutup.TabIndex = 9;
            this.btntutup.Text = "TUTUP";
            this.btntutup.UseVisualStyleBackColor = true;
            // 
            // tabellistuser
            // 
            this.tabellistuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabellistuser.Location = new System.Drawing.Point(56, 191);
            this.tabellistuser.Name = "tabellistuser";
            this.tabellistuser.Size = new System.Drawing.Size(492, 211);
            this.tabellistuser.TabIndex = 10;
            // 
            // btninventory
            // 
            this.btninventory.Location = new System.Drawing.Point(75, 162);
            this.btninventory.Name = "btninventory";
            this.btninventory.Size = new System.Drawing.Size(79, 23);
            this.btninventory.TabIndex = 11;
            this.btninventory.Text = "INVENTORY";
            this.btninventory.UseVisualStyleBackColor = true;
            this.btninventory.Click += new System.EventHandler(this.btninventory_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 529);
            this.Controls.Add(this.btninventory);
            this.Controls.Add(this.tabellistuser);
            this.Controls.Add(this.btntutup);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btninput);
            this.Controls.Add(this.textboxpassword);
            this.Controls.Add(this.textboxnama);
            this.Controls.Add(this.textboxusername);
            this.Controls.Add(this.password);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.username);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabellistuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textboxusername;
        private System.Windows.Forms.TextBox textboxnama;
        private System.Windows.Forms.TextBox textboxpassword;
        private System.Windows.Forms.Button btninput;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btntutup;
        private System.Windows.Forms.DataGridView tabellistuser;
        private System.Windows.Forms.Button btninventory;
    }
}