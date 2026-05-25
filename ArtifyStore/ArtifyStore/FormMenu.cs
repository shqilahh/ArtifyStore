using System;
using System.Windows.Forms;

namespace ArtifyStore
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            // Event button
            btnPelanggan.Click += btnPelanggan_Click;
            btnPenjualan.Click += btnPenjualan_Click;
        }

        private void btnPelanggan_Click(object sender, EventArgs e)
        {
            FormPelanggan frm = new FormPelanggan();
            frm.Show();
        }

        private void btnPenjualan_Click(object sender, EventArgs e)
        {
            FormPenjualan frm = new FormPenjualan();
            frm.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}