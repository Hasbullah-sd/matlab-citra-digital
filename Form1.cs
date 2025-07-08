using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarisBarang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaximizedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            NavigatorPanel.Height = DashboardBtn.Height;
            NavigatorPanel.Top = DashboardBtn.Top;
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            NavigatorPanel.Height = PrintReportNavBtn.Height;
            NavigatorPanel.Top = PrintReportNavBtn.Top;
            MessageBox.Show("Pengaturan akan segera tersedia.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pengaturan akan segera tersedia.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
          
            bool IsOpen = false;
            foreach (Form  hp in Application.OpenForms) {
                if (hp.Name == "HelpPage")
                {
                    IsOpen = true;
                    hp.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                HelpPage Halbantuan = new HelpPage();
                Halbantuan.Show();
                MessageBox.Show("Hubungi admin untuk bantuan lebih lanjut.", "Bantuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
  
        }

        private void PembelianNavBtn_Click(object sender, EventArgs e)
        {
            // Buka Form Pembelian
            Pembelian formPembelian = new Pembelian();
            formPembelian.Show();
        }

        private void BarangNavBtn_Click(object sender, EventArgs e)
        {
            // Buka Form Barang
            FormBarang formBarang = new FormBarang();
            formBarang.Show();
        }

        private void ProdukNavBtn_Click(object sender, EventArgs e)
        {
            // Buka Form Produk
            Produk formProduk = new Produk();
            formProduk.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
