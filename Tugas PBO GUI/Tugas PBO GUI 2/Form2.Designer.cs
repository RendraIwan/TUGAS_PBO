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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entri Data Objek";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_Agrikultur
            // 
            this.Label_Agrikultur.AutoSize = true;
            this.Label_Agrikultur.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Agrikultur.Location = new System.Drawing.Point(71, 149);
            this.Label_Agrikultur.Name = "Label_Agrikultur";
            this.Label_Agrikultur.Size = new System.Drawing.Size(137, 24);
            this.Label_Agrikultur.TabIndex = 1;
            this.Label_Agrikultur.Text = "Nama Barang";
            this.Label_Agrikultur.Click += new System.EventHandler(this.Label_Agrikultur_Click);
            // 
            // tbpariwisata
            // 
            this.tbpariwisata.AutoSize = true;
            this.tbpariwisata.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpariwisata.Location = new System.Drawing.Point(71, 299);
            this.tbpariwisata.Name = "tbpariwisata";
            this.tbpariwisata.Size = new System.Drawing.Size(90, 24);
            this.tbpariwisata.TabIndex = 2;
            this.tbpariwisata.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pemilik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Harga";
            // 
            // tbNomerID
            // 
            this.tbNomerID.AccessibleName = "";
            this.tbNomerID.Location = new System.Drawing.Point(229, 104);
            this.tbNomerID.Name = "tbNomerID";
            this.tbNomerID.Size = new System.Drawing.Size(366, 22);
            this.tbNomerID.TabIndex = 5;
            this.tbNomerID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbbarang
            // 
            this.tbbarang.Location = new System.Drawing.Point(229, 151);
            this.tbbarang.Name = "tbbarang";
            this.tbbarang.Size = new System.Drawing.Size(366, 22);
            this.tbbarang.TabIndex = 6;
            this.tbbarang.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbharga
            // 
            this.tbharga.Location = new System.Drawing.Point(229, 199);
            this.tbharga.Name = "tbharga";
            this.tbharga.Size = new System.Drawing.Size(366, 22);
            this.tbharga.TabIndex = 7;
            this.tbharga.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Button_Simpan
            // 
            this.Button_Simpan.BackColor = System.Drawing.Color.Lime;
            this.Button_Simpan.Location = new System.Drawing.Point(250, 370);
            this.Button_Simpan.Name = "Button_Simpan";
            this.Button_Simpan.Size = new System.Drawing.Size(89, 35);
            this.Button_Simpan.TabIndex = 10;
            this.Button_Simpan.Text = "Simpan";
            this.Button_Simpan.UseVisualStyleBackColor = false;
            this.Button_Simpan.Click += new System.EventHandler(this.Button_Simpan_Click);
            // 
            // Button_Batal
            // 
            this.Button_Batal.BackColor = System.Drawing.Color.Red;
            this.Button_Batal.Location = new System.Drawing.Point(380, 370);
            this.Button_Batal.Name = "Button_Batal";
            this.Button_Batal.Size = new System.Drawing.Size(89, 35);
            this.Button_Batal.TabIndex = 11;
            this.Button_Batal.Text = "Batal";
            this.Button_Batal.UseVisualStyleBackColor = false;
            this.Button_Batal.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbpemilik
            // 
            this.tbpemilik.AccessibleName = "";
            this.tbpemilik.Location = new System.Drawing.Point(229, 249);
            this.tbpemilik.Name = "tbpemilik";
            this.tbpemilik.Size = new System.Drawing.Size(366, 22);
            this.tbpemilik.TabIndex = 8;
            this.tbpemilik.TextChanged += new System.EventHandler(this.tbNomerID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
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
            this.tbkategori.Location = new System.Drawing.Point(229, 299);
            this.tbkategori.Name = "tbkategori";
            this.tbkategori.Size = new System.Drawing.Size(366, 24);
            this.tbkategori.TabIndex = 9;
            this.tbkategori.Text = "Pilih Salah Satu";
            this.tbkategori.SelectedIndexChanged += new System.EventHandler(this.tbkategori_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
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
    }
}