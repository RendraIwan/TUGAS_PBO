namespace Tugas_PBO_GUI_2
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Agrikultur = new System.Windows.Forms.Label();
            this.tbpariwisata = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNomerID = new System.Windows.Forms.TextBox();
            this.tbbarang = new System.Windows.Forms.TextBox();
            this.tbharga = new System.Windows.Forms.TextBox();
            this.Button_Simpan = new System.Windows.Forms.Button();
            this.Button_Batal = new System.Windows.Forms.Button();
            this.tbpemilik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbkategori = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entri Data Objek";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_Agrikultur
            // 
            this.Label_Agrikultur.AutoSize = true;
            this.Label_Agrikultur.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Agrikultur.Location = new System.Drawing.Point(53, 121);
            this.Label_Agrikultur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Agrikultur.Name = "Label_Agrikultur";
            this.Label_Agrikultur.Size = new System.Drawing.Size(113, 19);
            this.Label_Agrikultur.TabIndex = 1;
            this.Label_Agrikultur.Text = "Nama Barang";
            this.Label_Agrikultur.Click += new System.EventHandler(this.Label_Agrikultur_Click);
            // 
            // tbpariwisata
            // 
            this.tbpariwisata.AutoSize = true;
            this.tbpariwisata.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpariwisata.Location = new System.Drawing.Point(53, 243);
            this.tbpariwisata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tbpariwisata.Name = "tbpariwisata";
            this.tbpariwisata.Size = new System.Drawing.Size(74, 19);
            this.tbpariwisata.TabIndex = 2;
            this.tbpariwisata.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pemilik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Harga";
            // 
            // tbNomerID
            // 
            this.tbNomerID.AccessibleName = "";
            this.tbNomerID.Location = new System.Drawing.Point(172, 84);
            this.tbNomerID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNomerID.Name = "tbNomerID";
            this.tbNomerID.Size = new System.Drawing.Size(276, 20);
            this.tbNomerID.TabIndex = 5;
            this.tbNomerID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbbarang
            // 
            this.tbbarang.Location = new System.Drawing.Point(172, 123);
            this.tbbarang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbbarang.Name = "tbbarang";
            this.tbbarang.Size = new System.Drawing.Size(276, 20);
            this.tbbarang.TabIndex = 6;
            this.tbbarang.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbharga
            // 
            this.tbharga.Location = new System.Drawing.Point(172, 162);
            this.tbharga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbharga.Name = "tbharga";
            this.tbharga.Size = new System.Drawing.Size(276, 20);
            this.tbharga.TabIndex = 7;
            this.tbharga.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Button_Simpan
            // 
            this.Button_Simpan.BackColor = System.Drawing.Color.Lime;
            this.Button_Simpan.Location = new System.Drawing.Point(290, 301);
            this.Button_Simpan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_Simpan.Name = "Button_Simpan";
            this.Button_Simpan.Size = new System.Drawing.Size(67, 28);
            this.Button_Simpan.TabIndex = 10;
            this.Button_Simpan.Text = "Simpan";
            this.Button_Simpan.UseVisualStyleBackColor = false;
            this.Button_Simpan.Click += new System.EventHandler(this.Button_Simpan_Click);
            // 
            // Button_Batal
            // 
            this.Button_Batal.BackColor = System.Drawing.Color.Red;
            this.Button_Batal.Location = new System.Drawing.Point(381, 301);
            this.Button_Batal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_Batal.Name = "Button_Batal";
            this.Button_Batal.Size = new System.Drawing.Size(67, 28);
            this.Button_Batal.TabIndex = 11;
            this.Button_Batal.Text = "Batal";
            this.Button_Batal.UseVisualStyleBackColor = false;
            this.Button_Batal.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbpemilik
            // 
            this.tbpemilik.AccessibleName = "";
            this.tbpemilik.Location = new System.Drawing.Point(172, 202);
            this.tbpemilik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpemilik.Name = "tbpemilik";
            this.tbpemilik.Size = new System.Drawing.Size(276, 20);
            this.tbpemilik.TabIndex = 8;
            this.tbpemilik.TextChanged += new System.EventHandler(this.tbNomerID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nomer ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbkategori
            // 
            this.tbkategori.FormattingEnabled = true;
            this.tbkategori.Items.AddRange(new object[] {
            "Pertanian",
            "Peternakan",
            "Perkebunan",
            "Perikanan",
            "Lain Lain"});
            this.tbkategori.Location = new System.Drawing.Point(172, 243);
            this.tbkategori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbkategori.Name = "tbkategori";
            this.tbkategori.Size = new System.Drawing.Size(276, 21);
            this.tbkategori.TabIndex = 9;
            this.tbkategori.Text = "Pilih Salah Satu";
            this.tbkategori.SelectedIndexChanged += new System.EventHandler(this.tbkategori_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Rendra Iwan Tri Meidiansyah(222410101021)",
            "Satria Belva Nararya(222410101052)",
            "Arief Rachman Hakim(222410101076)",
            "Divo Tahta Imannulloh(222410101083)",
            "Mohammad Haikal Al Kamily(222410101092)"});
            this.listBox1.Location = new System.Drawing.Point(12, 287);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 69);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbkategori);
            this.Controls.Add(this.tbpemilik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Button_Batal);
            this.Controls.Add(this.Button_Simpan);
            this.Controls.Add(this.tbharga);
            this.Controls.Add(this.tbbarang);
            this.Controls.Add(this.tbNomerID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbpariwisata);
            this.Controls.Add(this.Label_Agrikultur);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Entri Data Baru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Agrikultur;
        private System.Windows.Forms.Label tbpariwisata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNomerID;
        private System.Windows.Forms.TextBox tbbarang;
        private System.Windows.Forms.TextBox tbharga;
        private System.Windows.Forms.Button Button_Simpan;
        private System.Windows.Forms.Button Button_Batal;
        private System.Windows.Forms.TextBox tbpemilik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tbkategori;
        private System.Windows.Forms.ListBox listBox1;
    }
}