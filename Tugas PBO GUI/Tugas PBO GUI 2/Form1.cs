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
    public partial class Form1 : Form
    {
        List<objek> listobjek = new List<objek>();
        public Form1()
        {
            InitializeComponent();

            objek row1 = new objek();
            row1.Nomer_Id   = "22241011";
            row1.Barang     = "Cangkul";
            row1.Harga      = "150000";
            row1.Pemilik    = "Bejo";
            row1.Kategori   = "Pertanian";


            objek row2 = new objek();
            row2.Nomer_Id = "22241010";
            row2.Barang = "Ransum";
            row2.Harga = "300000";
            row2.Pemilik = "Haikal";
            row2.Kategori   = "Peternakan";

            listobjek.Add(row1);
            listobjek.Add(row2);
            dataGridView1.DataSource = listobjek;
        }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_Tambah_Click(object sender, EventArgs e)
        {
            using (Form2 formDataBaru = new Form2())
                if (formDataBaru.ShowDialog() == DialogResult.OK)
                {
                    objek newobjek = formDataBaru.GetObjek();
                    listobjek.Add(newobjek);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listobjek;

                    formDataBaru.Close();
                }
        }
    }
}
