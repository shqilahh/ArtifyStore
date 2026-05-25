namespace ArtifyStore
{
    partial class FormPelanggan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtNama = new TextBox();
            txtNoHp = new TextBox();
            btnSimpan = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnClear = new Button();
            dgvPelanggan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPelanggan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 64, 0);
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(98, 20);
            label1.Name = "label1";
            label1.Size = new Size(39, 29);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 64, 0);
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(98, 63);
            label2.Name = "label2";
            label2.Size = new Size(78, 29);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 64, 0);
            label3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(98, 110);
            label3.Name = "label3";
            label3.Size = new Size(91, 29);
            label3.TabIndex = 2;
            label3.Text = "No. HP";
            // 
            // txtId
            // 
            txtId.BackColor = Color.Gold;
            txtId.Location = new Point(205, 17);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(415, 31);
            txtId.TabIndex = 3;
            txtId.UseWaitCursor = true;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtNama
            // 
            txtNama.BackColor = Color.Gold;
            txtNama.Location = new Point(205, 63);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(415, 31);
            txtNama.TabIndex = 4;
            // 
            // txtNoHp
            // 
            txtNoHp.BackColor = Color.Gold;
            txtNoHp.Location = new Point(205, 108);
            txtNoHp.Name = "txtNoHp";
            txtNoHp.Size = new Size(415, 31);
            txtNoHp.TabIndex = 5;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = SystemColors.GradientActiveCaption;
            btnSimpan.Font = new Font("Stencil", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.FromArgb(0, 64, 0);
            btnSimpan.Location = new Point(49, 165);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(140, 34);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "📁Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.GradientActiveCaption;
            btnEdit.Font = new Font("Stencil", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.FromArgb(0, 64, 0);
            btnEdit.Location = new Point(205, 165);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(140, 34);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "✏️Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = SystemColors.GradientActiveCaption;
            btnHapus.Font = new Font("Stencil", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHapus.ForeColor = Color.FromArgb(0, 64, 0);
            btnHapus.Location = new Point(392, 165);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(140, 34);
            btnHapus.TabIndex = 8;
            btnHapus.Text = "🗑️Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.GradientActiveCaption;
            btnClear.Font = new Font("Stencil", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.FromArgb(0, 64, 0);
            btnClear.Location = new Point(549, 165);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 34);
            btnClear.TabIndex = 9;
            btnClear.Text = "\U0001f9f9Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvPelanggan
            // 
            dgvPelanggan.BackgroundColor = Color.FromArgb(255, 255, 192);
            dgvPelanggan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPelanggan.Location = new Point(79, 219);
            dgvPelanggan.Name = "dgvPelanggan";
            dgvPelanggan.RowHeadersWidth = 62;
            dgvPelanggan.Size = new Size(557, 170);
            dgvPelanggan.TabIndex = 10;
            dgvPelanggan.CellClick += dgvPelanggan_CellClick;
            // 
            // FormPelanggan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__3_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(744, 424);
            Controls.Add(dgvPelanggan);
            Controls.Add(btnClear);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnSimpan);
            Controls.Add(txtNoHp);
            Controls.Add(txtNama);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPelanggan";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPelanggan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtNama;
        private TextBox txtNoHp;
        private Button btnSimpan;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnClear;
        private DataGridView dgvPelanggan;
    }
}
