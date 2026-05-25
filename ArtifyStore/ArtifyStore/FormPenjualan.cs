using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using ArtifyStore.Database;

namespace ArtifyStore
{
    public partial class FormPenjualan : Form
    {
        NpgsqlConnection conn;

        public FormPenjualan()
        {
            InitializeComponent();

            conn = Koneksi.GetConnection();

            TampilData();
        }

        void TampilData()
        {
            conn.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(
                "SELECT * FROM penjualan ORDER BY id_penjualan ASC", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvPenjualan.DataSource = dt;

            conn.Close();
        }

        void Clear()
        {
            txtIdPenjualan.Text = "";
            txtIdPelanggan.Text = "";
            txtGambar.Text = "";
            txtTotal.Text = "";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtIdPelanggan.Text.Trim() == "" ||
                txtGambar.Text.Trim() == "" ||
                txtTotal.Text.Trim() == "")
            {
                MessageBox.Show("Data tidak boleh kosong!");
                return;
            }

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "INSERT INTO penjualan(id_pelanggan,gambar,total) VALUES(@idpel,@gambar,@total)", conn);

            cmd.Parameters.AddWithValue("@idpel", int.Parse(txtIdPelanggan.Text));
            cmd.Parameters.AddWithValue("@gambar", txtGambar.Text);
            cmd.Parameters.AddWithValue("@total", int.Parse(txtTotal.Text));

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Data berhasil disimpan");

            TampilData();
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "UPDATE penjualan SET id_pelanggan=@idpel, gambar=@gambar, total=@total WHERE id_penjualan=@id", conn);

            cmd.Parameters.AddWithValue("@id", int.Parse(txtIdPenjualan.Text));
            cmd.Parameters.AddWithValue("@idpel", int.Parse(txtIdPelanggan.Text));
            cmd.Parameters.AddWithValue("@gambar", txtGambar.Text);
            cmd.Parameters.AddWithValue("@total", int.Parse(txtTotal.Text));

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Data berhasil diupdate");

            TampilData();
            Clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "DELETE FROM penjualan WHERE id_penjualan=@id", conn);

            cmd.Parameters.AddWithValue("@id", int.Parse(txtIdPenjualan.Text));

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Data berhasil dihapus");

            TampilData();
            Clear();
        }

        private void dgvPenjualan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPenjualan.Text = dgvPenjualan.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtIdPelanggan.Text = dgvPenjualan.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtGambar.Text = dgvPenjualan.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTotal.Text = dgvPenjualan.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}