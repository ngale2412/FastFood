using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLy.BS_layer;

namespace QLy
{
    public partial class FormDangNhap : Form
    {
        string err;
        public static string nguoidung;
        public static string matkhau;

        public FormDangNhap()
        {
           
            InitializeComponent();
            
        }
        

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            BLNguoiDung blNd = new BLNguoiDung();
            if (blNd.KtraNguoiDung(this.txtUser.Text, this.txtPass.Text, ref err))   //nguoi dung (quan ly)
            {
                nguoidung = this.txtUser.Text;
                matkhau = this.txtPass.Text;

                MessageBox.Show("Đăng nhập thành công!");
                Main.bIsLogin = true;

                Main fm = new Main();
                fm.ShowDialog();
                this.Close();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Thất bại! \nMời bạn đăng nhập lại.");
                txtUser.ResetText();
                txtPass.ResetText();
                txtUser.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Close();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                txtPass.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
            if(this.txtPass.UseSystemPasswordChar == true)
            {
                this.txtPass.UseSystemPasswordChar = false;
                label2.Text = "Hide";
            }
            else
                this.txtPass.UseSystemPasswordChar = true;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void load()
        {
            txtUser.ResetText();
            txtPass.ResetText();
        }
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
