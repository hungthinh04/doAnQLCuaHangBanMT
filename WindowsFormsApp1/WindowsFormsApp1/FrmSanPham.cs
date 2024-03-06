using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        

        private void FrmSanPham_Load(object sender, EventArgs e)
        {

        }
    }
}
