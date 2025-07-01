using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AppInventory
{
    public partial class Form1
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
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textboxusename = new System.Windows.Forms.TextBox();
            this.textboxpassword = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(103, 87);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(68, 13);
            this.Username.TabIndex = 1;
            this.Username.Text = "USERNAME";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(103, 133);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(70, 13);
            this.Password.TabIndex = 2;
            this.Password.Text = "PASSWORD";
            // 
            // textboxusename
            // 
            this.textboxusename.Location = new System.Drawing.Point(203, 87);
            this.textboxusename.Name = "textboxusename";
            this.textboxusename.Size = new System.Drawing.Size(155, 20);
            this.textboxusename.TabIndex = 3;
            // 
            // textboxpassword
            // 
            this.textboxpassword.Location = new System.Drawing.Point(203, 130);
            this.textboxpassword.Name = "textboxpassword";
            this.textboxpassword.Size = new System.Drawing.Size(155, 20);
            this.textboxpassword.TabIndex = 4;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(203, 176);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 5;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(284, 176);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 325);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.login);
            this.Controls.Add(this.textboxpassword);
            this.Controls.Add(this.textboxusename);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textboxusename;
        private System.Windows.Forms.TextBox textboxpassword;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button cancel;
    }

}

