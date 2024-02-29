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
    public partial class FrmSanPham : Form
    {
        bool FormMenu = false;
        public FrmSanPham()
        {
            InitializeComponent();
           
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if(!FormMenu)
            {
                FrmMenu Fmenu = new FrmMenu();
                Fmenu.Show();
                
                FormMenu = true;
            }
            else
            {
                MessageBox.Show(" lỗi ","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }    
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grbNhanVien_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
