using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLy
{
    public partial class Main : Form
    {
        public static bool bIsLogin = false;
        public Main()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(tabControl1.SelectedIndex==1)
            {
                FormNV fnv = new FormNV();
                fnv.ShowDialog();
            }
            if (tabControl1.SelectedIndex == 2)
            {
                FormKhachHang fkh = new FormKhachHang();
                fkh.ShowDialog();
            }
            if (tabControl1.SelectedIndex == 3)
            {
                FormSanPham fsp = new FormSanPham();
                fsp.ShowDialog();
            }
            if (tabControl1.SelectedIndex == 4)
            {
                FormLoaiSP f = new FormLoaiSP();
                f.ShowDialog();
            }
            if (tabControl1.SelectedIndex == 5)
            {
                FormHoaDon fdh = new FormHoaDon();
                fdh.ShowDialog();
            }
            //if(tabControl1.SelectedIndex==6)
            //{
            //    FormThongKe tk = new FormThongKe();
            //    tk.ShowDialog();
            //}
        }

        private void tabPageKho_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            DialogResult d = MessageBox.Show("Thoát đăng nhập!", "   =_=  ", MessageBoxButtons.YesNo);
            if(d==DialogResult.Yes)
            {
                this.Close();
                FormDangNhap a = new FormDangNhap();
                a.ShowDialog();
            }

       
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormCaNhan f = new FormCaNhan();
            f.ShowDialog();
        }

        private void tabPageSP_Click(object sender, EventArgs e)
        {

        }
    }
}
