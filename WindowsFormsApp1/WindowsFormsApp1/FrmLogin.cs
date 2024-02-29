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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            tmTimeNow.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tmTimeNow.Tick += timer1_Tick;

            DateTime time = DateTime.Now;
            lblTime.Text = "Ngày và giờ hiện tại: " + time.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void txtDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)&& !char.IsLetter(e.KeyChar) && e.KeyChar != ('\b'))
            {
                e.Handled = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string name = txtDangNhap.Text;
            string pass = txtMatKhau.Text;

            if(name=="hungthinh"&&pass=="123")
            {
                MessageBox.Show(" Đăng nhập thành công", "thông báo", MessageBoxButtons.OK);
            }
            
            else
            {
                MessageBox.Show(" Đăng nhập thất bại ","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(" Bạn có muốn thoát ? ", "thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                e.Cancel= true;
            }
        }
    }

       
    
}
