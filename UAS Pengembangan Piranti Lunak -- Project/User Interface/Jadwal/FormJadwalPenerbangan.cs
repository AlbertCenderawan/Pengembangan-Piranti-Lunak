using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerjalananPenerbangan
{
    public partial class FormJadwalPenerbangan : Form
    {
        public FormJadwalPenerbangan()
        {
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show(); this.Hide();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            FormPembayaran formPembayaran = new FormPembayaran();
            formPembayaran.Show(); this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCariMaskapaiPenerbangan.Text = txtDestinasi.Text = txtJamKetibaan.Text = txtJamPenerbangan.Text = txtKotaAsal.Text = txtTanggal.Text = String.Empty;
        }

        //MessageBox.Show("Anda sudah booking. Tolong cek e-mail untuk tiket dan bonnya.");
    }
}
