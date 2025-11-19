using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Menampilkan harga berdasarkan jenis kamar yang dipilih
            if (cbJenis.SelectedItem.ToString() == "VIP")
            {
                txtHarga.Text = "750000";
            }
            else if (cbJenis.SelectedItem.ToString() == "Kelas I")
            {
                txtHarga.Text = "500000";
            }
            else if (cbJenis.SelectedItem.ToString() == "Kelas II")
            {
                txtHarga.Text = "300000";
            }
            else if (cbJenis.SelectedItem.ToString() == "Kelas III")
            {
                txtHarga.Text = "150000";
            }
        }

        private void txtLama_TextChanged(object sender, EventArgs e)
        {
            // Biaya Total dihitung berdasarkan lama menginap dan harga kamar
            if (txtLama.Text != "" && txtHarga.Text != "")
            {
                int lama = int.Parse(txtLama.Text);
                int harga = int.Parse(txtHarga.Text);
                int total = lama * harga;
                txtBiaya.Text = total.ToString();
            }
            else
            {
                txtBiaya.Text = "";
            }

        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {
            // Menghitung kembalian berdasarkan jumlah bayar dan biaya total
            if (txtJumlah.Text != "" && txtLama.Text != "")
            {
                int jumlah = int.Parse(txtJumlah.Text);
                int biaya = int.Parse(txtBiaya.Text);
                int kembalian = jumlah - biaya;
                txtKembali.Text = kembalian.ToString();
            }
            else
            {
                txtKembali.Text = "";
            }
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            // Menghitung biaya total ketika harga kamar berubah
            if (txtLama.Text != "" && txtHarga.Text != "")
            {
                int lama = int.Parse(txtLama.Text);
                int harga = int.Parse(txtHarga.Text);
                int total = lama * harga;
                txtLama.Text = total.ToString();
            }
            else
            {
                txtLama.Text = "";
            }
        }

        private void txtBiaya_TextChanged(object sender, EventArgs e)
        {
            // Menghitung kembalian ketika biaya total berubah
            if (txtJumlah.Text != "" && txtLama.Text != "")
            {
                int jumlah = int.Parse(txtJumlah.Text);
                int total = int.Parse(txtLama.Text);
                int kembalian = jumlah - total;
                txtKembali.Text = kembalian.ToString();
            }
            else
            {
                txtKembali.Text = "";
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            // Menutup aplikasi
            Application.Exit();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            // Membersihkan semua inputan pada form
            txtNama.Text = "";
            cbJenis.Text = "";
            txtHarga.Text = "";
            txtLama.Text = "";
            txtBiaya.Text = "";
            txtJumlah.Text = "";
            txtKembali.Text = "";
            txtAlamat.Text = "";
            txtNomer.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
