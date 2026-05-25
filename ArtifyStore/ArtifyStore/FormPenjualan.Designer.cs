namespace ArtifyStore
{
    partial class FormPenjualan
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIdPenjualan = new TextBox();
            txtIdPelanggan = new TextBox();
            txtGambar = new TextBox();
            txtTotal = new TextBox();
            btnSimpan = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnClear = new Button();
            dgvPenjualan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPenjualan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(5, 25);
            label1.Name = "label1";
            label1.Size = new Size(147, 24);
            label1.TabIndex = 0;
            label1.Text = "ID Penjualan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 64, 0);
            label2.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(5, 59);
            label2.Name = "label2";
            label2.Size = new Size(146, 24);
            label2.TabIndex = 1;
            label2.Text = "ID Pelanggan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 64, 0);
            label3.Location = new Point(6, 94);
            label3.Name = "label3";
            label3.Size = new Size(89, 24);
            label3.TabIndex = 2;
            label3.Text = "Gambar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 64, 0);
            label4.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(7, 127);
            label4.Name = "label4";
            label4.Size = new Size(140, 24);
            label4.TabIndex = 3;
            label4.Text = "Total Harga";
            // 
            // txtIdPenjualan
            // 
            txtIdPenjualan.BackColor = Color.Gold;
            txtIdPenjualan.Location = new Point(182, 20);
            txtIdPenjualan.Name = "txtIdPenjualan";
            txtIdPenjualan.ReadOnly = true;
            txtIdPenjualan.Size = new Size(266, 31);
            txtIdPenjualan.TabIndex = 4;
            // 
            // txtIdPelanggan
            // 
            txtIdPelanggan.BackColor = Color.OliveDrab;
            txtIdPelanggan.Location = new Point(182, 54);
            txtIdPelanggan.Name = "txtIdPelanggan";
            txtIdPelanggan.Size = new Size(266, 31);
            txtIdPelanggan.TabIndex = 5;
            // 
            // txtGambar
            // 
            txtGambar.BackColor = Color.Gold;
            txtGambar.Location = new Point(182, 87);
            txtGambar.Name = "txtGambar";
            txtGambar.Size = new Size(266, 31);
            txtGambar.TabIndex = 6;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.OliveDrab;
            txtTotal.Location = new Point(182, 120);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(266, 31);
            txtTotal.TabIndex = 7;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = SystemColors.GradientActiveCaption;
            btnSimpan.Font = new Font("Stencil", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.FromArgb(0, 64, 0);
            btnSimpan.Location = new Point(454, 37);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(128, 34);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "📁Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.GradientActiveCaption;
            btnEdit.Font = new Font("Stencil", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.FromArgb(0, 64, 0);
            btnEdit.Location = new Point(454, 87);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(128, 34);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "✏️Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = SystemColors.GradientActiveCaption;
            btnHapus.Font = new Font("Stencil", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHapus.ForeColor = Color.FromArgb(0, 64, 0);
            btnHapus.Location = new Point(586, 37);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(128, 34);
            btnHapus.TabIndex = 10;
            btnHapus.Text = "🗑️Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.GradientActiveCaption;
            btnClear.Font = new Font("Stencil", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.FromArgb(0, 64, 0);
            btnClear.Location = new Point(586, 88);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(128, 34);
            btnClear.TabIndex = 11;
            btnClear.Text = "\U0001f9f9Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvPenjualan
            // 
            dgvPenjualan.BackgroundColor = Color.FromArgb(255, 255, 192);
            dgvPenjualan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPenjualan.Location = new Point(36, 180);
            dgvPenjualan.Name = "dgvPenjualan";
            dgvPenjualan.RowHeadersWidth = 62;
            dgvPenjualan.Size = new Size(653, 198);
            dgvPenjualan.TabIndex = 12;
            dgvPenjualan.CellClick += dgvPenjualan_CellClick;
            // 
            // FormPenjualan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__3_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(726, 390);
            Controls.Add(dgvPenjualan);
            Controls.Add(btnClear);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnSimpan);
            Controls.Add(txtTotal);
            Controls.Add(txtGambar);
            Controls.Add(txtIdPelanggan);
            Controls.Add(txtIdPenjualan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPenjualan";
            Text = "FormPenjualan";
            ((System.ComponentModel.ISupportInitialize)dgvPenjualan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIdPenjualan;
        private TextBox txtIdPelanggan;
        private TextBox txtGambar;
        private TextBox txtTotal;
        private Button btnSimpan;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnClear;
        private DataGridView dgvPenjualan;
    }
}