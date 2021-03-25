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
    public partial class FormPembayaran : Form
    {
        public FormPembayaran()
        {
            InitializeComponent();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            string pemberitahuan;

            pemberitahuan = "Virtual Account: 01010121233445 \n" +
                "Jika sudah selesai, akan mendapat bon dan tiket dari e-mail. \n" +
                "Jika belum melakukan pembayaran dalam jangka waktu 15 menit, maka booking akan hangus. \n";

            MessageBox.Show(pemberitahuan);
        }

        private void btnTunai_Click(object sender, EventArgs e)
        {
            string pemberitahuan;

            pemberitahuan = "Metode Pembayran : tunai. \n" +
                "Pembayaran akan diserahkan kepada front-desk airport. \n" +
                "Cek bon di dalam e-mail. \n";

            MessageBox.Show(pemberitahuan);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormJadwalPenerbangan formJadwalPenerbangan = new FormJadwalPenerbangan();
            formJadwalPenerbangan.Show(); this.Hide();
        }
    }
}
