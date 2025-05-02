namespace AppInventory
{
    partial class Inventory
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
            this.kodebarang = new System.Windows.Forms.Label();
            this.namabarang = new System.Windows.Forms.Label();
            this.kondisi = new System.Windows.Forms.Label();
            this.jumlah = new System.Windows.Forms.Label();
            this.satuan = new System.Windows.Forms.Label();
            this.textboxkodebrg = new System.Windows.Forms.TextBox();
            this.textboxnamabrg = new System.Windows.Forms.TextBox();
            this.textboxkondisi = new System.Windows.Forms.TextBox();
            this.textboxjml = new System.Windows.Forms.TextBox();
            this.textboxstn = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.tabellistbrg = new System.Windows.Forms.DataGridView();
            this.btnusermanagement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabellistbrg)).BeginInit();
            this.SuspendLayout();
            // 
            // kodebarang
            // 
            this.kodebarang.AutoSize = true;
            this.kodebarang.Location = new System.Drawing.Point(90, 39);
            this.kodebarang.Name = "kodebarang";
            this.kodebarang.Size = new System.Drawing.Size(69, 13);
            this.kodebarang.TabIndex = 0;
            this.kodebarang.Text = "Kode Barang";
            // 
            // namabarang
            // 
            this.namabarang.AutoSize = true;
            this.namabarang.Location = new System.Drawing.Point(90, 68);
            this.namabarang.Name = "namabarang";
            this.namabarang.Size = new System.Drawing.Size(72, 13);
            this.namabarang.TabIndex = 1;
            this.namabarang.Text = "Nama Barang";
            this.namabarang.Click += new System.EventHandler(this.label2_Click);
            // 
            // kondisi
            // 
            this.kondisi.AutoSize = true;
            this.kondisi.Location = new System.Drawing.Point(90, 98);
            this.kondisi.Name = "kondisi";
            this.kondisi.Size = new System.Drawing.Size(41, 13);
            this.kondisi.TabIndex = 2;
            this.kondisi.Text = "Kondisi";
            // 
            // jumlah
            // 
            this.jumlah.AutoSize = true;
            this.jumlah.Location = new System.Drawing.Point(90, 129);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(40, 13);
            this.jumlah.TabIndex = 3;
            this.jumlah.Text = "Jumlah";
            // 
            // satuan
            // 
            this.satuan.AutoSize = true;
            this.satuan.Location = new System.Drawing.Point(90, 163);
            this.satuan.Name = "satuan";
            this.satuan.Size = new System.Drawing.Size(41, 13);
            this.satuan.TabIndex = 4;
            this.satuan.Text = "Satuan";
            // 
            // textboxkodebrg
            // 
            this.textboxkodebrg.Location = new System.Drawing.Point(205, 36);
            this.textboxkodebrg.Name = "textboxkodebrg";
            this.textboxkodebrg.Size = new System.Drawing.Size(82, 20);
            this.textboxkodebrg.TabIndex = 5;
            // 
            // textboxnamabrg
            // 
            this.textboxnamabrg.Location = new System.Drawing.Point(205, 65);
            this.textboxnamabrg.Name = "textboxnamabrg";
            this.textboxnamabrg.Size = new System.Drawing.Size(163, 20);
            this.textboxnamabrg.TabIndex = 6;
            // 
            // textboxkondisi
            // 
            this.textboxkondisi.Location = new System.Drawing.Point(205, 95);
            this.textboxkondisi.Name = "textboxkondisi";
            this.textboxkondisi.Size = new System.Drawing.Size(121, 20);
            this.textboxkondisi.TabIndex = 7;
            // 
            // textboxjml
            // 
            this.textboxjml.Location = new System.Drawing.Point(205, 126);
            this.textboxjml.Name = "textboxjml";
            this.textboxjml.Size = new System.Drawing.Size(82, 20);
            this.textboxjml.TabIndex = 8;
            // 
            // textboxstn
            // 
            this.textboxstn.Location = new System.Drawing.Point(205, 160);
            this.textboxstn.Name = "textboxstn";
            this.textboxstn.Size = new System.Drawing.Size(82, 20);
            this.textboxstn.TabIndex = 9;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(84, 199);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 10;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(167, 199);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(251, 199);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 12;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(332, 199);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 13;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // tabellistbrg
            // 
            this.tabellistbrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabellistbrg.Location = new System.Drawing.Point(60, 241);
            this.tabellistbrg.Name = "tabellistbrg";
            this.tabellistbrg.Size = new System.Drawing.Size(414, 221);
            this.tabellistbrg.TabIndex = 14;
            this.tabellistbrg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabellistbrg_CellClick);
            this.tabellistbrg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabellistbrg_CellContentClick);
            // 
            // btnusermanagement
            // 
            this.btnusermanagement.Location = new System.Drawing.Point(376, 535);
            this.btnusermanagement.Name = "btnusermanagement";
            this.btnusermanagement.Size = new System.Drawing.Size(140, 38);
            this.btnusermanagement.TabIndex = 15;
            this.btnusermanagement.Text = "USER MANAGEMENT";
            this.btnusermanagement.UseVisualStyleBackColor = true;
            this.btnusermanagement.Click += new System.EventHandler(this.btnusermanagement_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 585);
            this.Controls.Add(this.btnusermanagement);
            this.Controls.Add(this.tabellistbrg);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.textboxstn);
            this.Controls.Add(this.textboxjml);
            this.Controls.Add(this.textboxkondisi);
            this.Controls.Add(this.textboxnamabrg);
            this.Controls.Add(this.textboxkodebrg);
            this.Controls.Add(this.satuan);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.kondisi);
            this.Controls.Add(this.namabarang);
            this.Controls.Add(this.kodebarang);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabellistbrg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kodebarang;
        private System.Windows.Forms.Label namabarang;
        private System.Windows.Forms.Label kondisi;
        private System.Windows.Forms.Label jumlah;
        private System.Windows.Forms.Label satuan;
        private System.Windows.Forms.TextBox textboxkodebrg;
        private System.Windows.Forms.TextBox textboxnamabrg;
        private System.Windows.Forms.TextBox textboxkondisi;
        private System.Windows.Forms.TextBox textboxjml;
        private System.Windows.Forms.TextBox textboxstn;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.DataGridView tabellistbrg;
        private System.Windows.Forms.Button btnusermanagement;
    }
}