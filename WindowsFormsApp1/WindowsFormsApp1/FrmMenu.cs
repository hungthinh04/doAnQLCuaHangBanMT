using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
           
            FrmMenu FMenu = new FrmMenu();
            FMenu.Show();

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            FrmSanPham frmSanPham = new FrmSanPham();
            frmSanPham.Show();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            FrmNhanVien frmNhanVien = new FrmNhanVien();
            frmNhanVien.Show();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap frm = new FrmNhaCungCap();
            frm.Show();
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            FrmTonKho frmTonKho = new FrmTonKho();
            frmTonKho.Show();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            FrmHoaDon frm = new FrmHoaDon();
            frm.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
        }
        public int i = 8;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblBanner.Left += i;
            if (lblBanner.Left >= this.Width - lblBanner.Width || lblBanner.Left <= 0)
                i = -i;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(" Bạn có muốn đăng xuất ?","thông báo",MessageBoxButtons.YesNo);
            if(dr==DialogResult.Yes)
            {
                FrmLogin frm = new FrmLogin();
                this.Hide();
                frm.Show();
                
            }
        }

        private void lblBanner_Click(object sender, EventArgs e)
        {

        }
    }
}
