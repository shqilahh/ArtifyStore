namespace ArtifyStore
{
    partial class FormMenu
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
            btnPelanggan = new Button();
            btnPenjualan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Vladimir Script", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(63, 52);
            label1.Name = "label1";
            label1.Size = new Size(608, 54);
            label1.TabIndex = 0;
            label1.Text = "Artify Store Traditional Anime Art";
            // 
            // btnPelanggan
            // 
            btnPelanggan.BackColor = Color.OliveDrab;
            btnPelanggan.BackgroundImageLayout = ImageLayout.None;
            btnPelanggan.FlatStyle = FlatStyle.Flat;
            btnPelanggan.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPelanggan.ForeColor = Color.Gold;
            btnPelanggan.Location = new Point(220, 174);
            btnPelanggan.Name = "btnPelanggan";
            btnPelanggan.Size = new Size(261, 39);
            btnPelanggan.TabIndex = 1;
            btnPelanggan.Text = "Data Pelanggan\r\n";
            btnPelanggan.UseVisualStyleBackColor = false;
            // 
            // btnPenjualan
            // 
            btnPenjualan.BackColor = Color.OliveDrab;
            btnPenjualan.BackgroundImageLayout = ImageLayout.None;
            btnPenjualan.FlatStyle = FlatStyle.Flat;
            btnPenjualan.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPenjualan.ForeColor = Color.Gold;
            btnPenjualan.Location = new Point(220, 262);
            btnPenjualan.Name = "btnPenjualan";
            btnPenjualan.Size = new Size(261, 39);
            btnPenjualan.TabIndex = 2;
            btnPenjualan.Text = "Data Penjualan";
            btnPenjualan.UseVisualStyleBackColor = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources._Cutscene__Cookie_run_Ovenbreak__Curse_of_the_Sacred_Forest;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(735, 422);
            Controls.Add(btnPenjualan);
            Controls.Add(btnPelanggan);
            Controls.Add(label1);
            Name = "FormMenu";
            Text = "FormMenu";
            Load += FormMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPelanggan;
        private Button btnPenjualan;
    }
}