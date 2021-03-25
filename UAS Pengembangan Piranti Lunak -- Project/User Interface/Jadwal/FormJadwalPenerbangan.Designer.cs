namespace PerjalananPenerbangan
{
    partial class FormJadwalPenerbangan
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
            this.lblCariMaskapaiPenerbangan = new System.Windows.Forms.Label();
            this.dgvJadwalPenerbangan = new System.Windows.Forms.DataGridView();
            this.lblJamPenerbangan = new System.Windows.Forms.Label();
            this.lblJamKetibaan = new System.Windows.Forms.Label();
            this.lblDestinasi = new System.Windows.Forms.Label();
            this.lblKotaAsal = new System.Windows.Forms.Label();
            this.txtCariMaskapaiPenerbangan = new System.Windows.Forms.TextBox();
            this.txtJamPenerbangan = new System.Windows.Forms.TextBox();
            this.txtJamKetibaan = new System.Windows.Forms.TextBox();
            this.txtKotaAsal = new System.Windows.Forms.TextBox();
            this.txtDestinasi = new System.Windows.Forms.TextBox();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.MaskapaiPenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JamPenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JamKetibaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KotaAsal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destinasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTanggal = new System.Windows.Forms.TextBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwalPenerbangan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCariMaskapaiPenerbangan
            // 
            this.lblCariMaskapaiPenerbangan.AutoSize = true;
            this.lblCariMaskapaiPenerbangan.Location = new System.Drawing.Point(43, 19);
            this.lblCariMaskapaiPenerbangan.Name = "lblCariMaskapaiPenerbangan";
            this.lblCariMaskapaiPenerbangan.Size = new System.Drawing.Size(187, 17);
            this.lblCariMaskapaiPenerbangan.TabIndex = 0;
            this.lblCariMaskapaiPenerbangan.Text = "Cari Maskapai Penerbangan";
            // 
            // dgvJadwalPenerbangan
            // 
            this.dgvJadwalPenerbangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJadwalPenerbangan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaskapaiPenerbangan,
            this.JamPenerbangan,
            this.JamKetibaan,
            this.KotaAsal,
            this.Destinasi,
            this.Tanggal});
            this.dgvJadwalPenerbangan.Location = new System.Drawing.Point(36, 207);
            this.dgvJadwalPenerbangan.Name = "dgvJadwalPenerbangan";
            this.dgvJadwalPenerbangan.RowHeadersWidth = 51;
            this.dgvJadwalPenerbangan.RowTemplate.Height = 24;
            this.dgvJadwalPenerbangan.Size = new System.Drawing.Size(808, 118);
            this.dgvJadwalPenerbangan.TabIndex = 1;
            // 
            // lblJamPenerbangan
            // 
            this.lblJamPenerbangan.AutoSize = true;
            this.lblJamPenerbangan.Location = new System.Drawing.Point(106, 54);
            this.lblJamPenerbangan.Name = "lblJamPenerbangan";
            this.lblJamPenerbangan.Size = new System.Drawing.Size(124, 17);
            this.lblJamPenerbangan.TabIndex = 2;
            this.lblJamPenerbangan.Text = "Jam Penerbangan";
            // 
            // lblJamKetibaan
            // 
            this.lblJamKetibaan.AutoSize = true;
            this.lblJamKetibaan.Location = new System.Drawing.Point(136, 85);
            this.lblJamKetibaan.Name = "lblJamKetibaan";
            this.lblJamKetibaan.Size = new System.Drawing.Size(94, 17);
            this.lblJamKetibaan.TabIndex = 3;
            this.lblJamKetibaan.Text = "Jam Ketibaan";
            // 
            // lblDestinasi
            // 
            this.lblDestinasi.AutoSize = true;
            this.lblDestinasi.Location = new System.Drawing.Point(164, 140);
            this.lblDestinasi.Name = "lblDestinasi";
            this.lblDestinasi.Size = new System.Drawing.Size(66, 17);
            this.lblDestinasi.TabIndex = 4;
            this.lblDestinasi.Text = "Destinasi";
            // 
            // lblKotaAsal
            // 
            this.lblKotaAsal.AutoSize = true;
            this.lblKotaAsal.Location = new System.Drawing.Point(162, 113);
            this.lblKotaAsal.Name = "lblKotaAsal";
            this.lblKotaAsal.Size = new System.Drawing.Size(68, 17);
            this.lblKotaAsal.TabIndex = 5;
            this.lblKotaAsal.Text = "Kota Asal";
            // 
            // txtCariMaskapaiPenerbangan
            // 
            this.txtCariMaskapaiPenerbangan.Location = new System.Drawing.Point(236, 19);
            this.txtCariMaskapaiPenerbangan.Name = "txtCariMaskapaiPenerbangan";
            this.txtCariMaskapaiPenerbangan.Size = new System.Drawing.Size(268, 22);
            this.txtCariMaskapaiPenerbangan.TabIndex = 6;
            // 
            // txtJamPenerbangan
            // 
            this.txtJamPenerbangan.Location = new System.Drawing.Point(236, 47);
            this.txtJamPenerbangan.Name = "txtJamPenerbangan";
            this.txtJamPenerbangan.Size = new System.Drawing.Size(268, 22);
            this.txtJamPenerbangan.TabIndex = 7;
            // 
            // txtJamKetibaan
            // 
            this.txtJamKetibaan.Location = new System.Drawing.Point(236, 82);
            this.txtJamKetibaan.Name = "txtJamKetibaan";
            this.txtJamKetibaan.ReadOnly = true;
            this.txtJamKetibaan.Size = new System.Drawing.Size(268, 22);
            this.txtJamKetibaan.TabIndex = 8;
            // 
            // txtKotaAsal
            // 
            this.txtKotaAsal.Location = new System.Drawing.Point(236, 113);
            this.txtKotaAsal.Name = "txtKotaAsal";
            this.txtKotaAsal.Size = new System.Drawing.Size(268, 22);
            this.txtKotaAsal.TabIndex = 9;
            // 
            // txtDestinasi
            // 
            this.txtDestinasi.Location = new System.Drawing.Point(236, 141);
            this.txtDestinasi.Name = "txtDestinasi";
            this.txtDestinasi.Size = new System.Drawing.Size(268, 22);
            this.txtDestinasi.TabIndex = 10;
            // 
            // btnBooking
            // 
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(121, 332);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(221, 60);
            this.btnBooking.TabIndex = 11;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(371, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(220, 60);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(547, 61);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(173, 68);
            this.btnSignOut.TabIndex = 13;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // MaskapaiPenerbangan
            // 
            this.MaskapaiPenerbangan.HeaderText = "Maskapai Penerbangan";
            this.MaskapaiPenerbangan.MinimumWidth = 6;
            this.MaskapaiPenerbangan.Name = "MaskapaiPenerbangan";
            this.MaskapaiPenerbangan.Width = 125;
            // 
            // JamPenerbangan
            // 
            this.JamPenerbangan.HeaderText = "Jam Penerbangan";
            this.JamPenerbangan.MinimumWidth = 6;
            this.JamPenerbangan.Name = "JamPenerbangan";
            this.JamPenerbangan.Width = 125;
            // 
            // JamKetibaan
            // 
            this.JamKetibaan.HeaderText = "Jam Ketibaan";
            this.JamKetibaan.MinimumWidth = 6;
            this.JamKetibaan.Name = "JamKetibaan";
            this.JamKetibaan.Width = 125;
            // 
            // KotaAsal
            // 
            this.KotaAsal.HeaderText = "Kota Asal";
            this.KotaAsal.MinimumWidth = 6;
            this.KotaAsal.Name = "KotaAsal";
            this.KotaAsal.Width = 125;
            // 
            // Destinasi
            // 
            this.Destinasi.HeaderText = "Destinasi";
            this.Destinasi.MinimumWidth = 6;
            this.Destinasi.Name = "Destinasi";
            this.Destinasi.Width = 125;
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.MinimumWidth = 6;
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Width = 125;
            // 
            // txtTanggal
            // 
            this.txtTanggal.Location = new System.Drawing.Point(236, 179);
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Size = new System.Drawing.Size(268, 22);
            this.txtTanggal.TabIndex = 15;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(164, 178);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(60, 17);
            this.lblTanggal.TabIndex = 14;
            this.lblTanggal.Text = "Tanggal";
            // 
            // FormJadwalPenerbangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 414);
            this.Controls.Add(this.txtTanggal);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.txtDestinasi);
            this.Controls.Add(this.txtKotaAsal);
            this.Controls.Add(this.txtJamKetibaan);
            this.Controls.Add(this.txtJamPenerbangan);
            this.Controls.Add(this.txtCariMaskapaiPenerbangan);
            this.Controls.Add(this.lblKotaAsal);
            this.Controls.Add(this.lblDestinasi);
            this.Controls.Add(this.lblJamKetibaan);
            this.Controls.Add(this.lblJamPenerbangan);
            this.Controls.Add(this.dgvJadwalPenerbangan);
            this.Controls.Add(this.lblCariMaskapaiPenerbangan);
            this.Name = "FormJadwalPenerbangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jadwal Penerbangan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwalPenerbangan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCariMaskapaiPenerbangan;
        private System.Windows.Forms.DataGridView dgvJadwalPenerbangan;
        private System.Windows.Forms.Label lblJamPenerbangan;
        private System.Windows.Forms.Label lblJamKetibaan;
        private System.Windows.Forms.Label lblDestinasi;
        private System.Windows.Forms.Label lblKotaAsal;
        private System.Windows.Forms.TextBox txtCariMaskapaiPenerbangan;
        private System.Windows.Forms.TextBox txtJamPenerbangan;
        private System.Windows.Forms.TextBox txtJamKetibaan;
        private System.Windows.Forms.TextBox txtKotaAsal;
        private System.Windows.Forms.TextBox txtDestinasi;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaskapaiPenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn JamPenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn JamKetibaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn KotaAsal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destinasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.TextBox txtTanggal;
        private System.Windows.Forms.Label lblTanggal;
    }
}