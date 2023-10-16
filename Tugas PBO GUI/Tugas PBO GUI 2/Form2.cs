using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_PBO_GUI_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Label_Agrikultur_Click(object sender, EventArgs e)
        {

        }

        private void Button_Simpan_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public objek GetObjek()
        {
            objek newobjek = new objek();
            newobjek.Pemilik    = tbpemilik.Text;
            newobjek.Nomer_Id   = tbNomerID.Text;
            newobjek.Harga      = tbharga.Text;
            newobjek.Barang     = tbbarang.Text;
            newobjek.Kategori   = tbkategori.Text;

            return newobjek;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbNomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
