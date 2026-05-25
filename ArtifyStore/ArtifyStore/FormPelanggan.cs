using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using ArtifyStore.Database;

namespace ArtifyStore
{
    public partial class FormPelanggan : Form
    {
        NpgsqlConnection conn;

        public FormPelanggan()
        {
            InitializeComponent();
            conn = Koneksi.GetConnection();
            TampilData();
        }

        void TampilData()
        {
            conn.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(
                "SELECT * FROM pelanggan ORDER BY id_pelanggan ASC", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvPelanggan.DataSource = dt;

            conn.Close();
        }

        void Clear()
        {
            txtId.Text = "";
            txtNama.Text = "";
            txtNoHp.Text = "";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            {
                if (txtNama.Text.Trim() == "" || txtNoHp.Text.Trim() == "")
                {
                    MessageBox.Show("Data tidak boleh kosong!");
                    return;
                }

                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(
                    "INSERT INTO pelanggan(nama,no_hp) VALUES(@nama,@hp)", conn);

                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@hp", txtNoHp.Text);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Data berhasil disimpan");

                TampilData();
                Clear();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            conn.Open();


            NpgsqlCommand cmd = new NpgsqlCommand(
                "UPDATE pelanggan SET nama=@nama, no_hp=@hp WHERE id_pelanggan=@id", conn);

            cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            cmd.Parameters.AddWithValue("@nama", txtNama.Text);
            cmd.Parameters.AddWithValue("@hp", txtNoHp.Text);

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
                "DELETE FROM pelanggan WHERE id_pelanggan=@id", conn);

            cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Data berhasil dihapus");

            TampilData();
            Clear();
        }

        private void dgvPelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvPelanggan.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNama.Text = dgvPelanggan.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNoHp.Text = dgvPelanggan.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}