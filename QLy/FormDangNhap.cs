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
using QLy.DB_layer;
using System.Data.SqlClient;

namespace QLy
{
    public partial class FormDangNhap : Form
    {
        string err;
        //public static string nguoidung;
        //public static string matkhau
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        BLNguoiDung db = new BLNguoiDung();
        public FormDangNhap()
        {
           
            InitializeComponent();
            
        }
        

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được trống", "", MessageBoxButtons.OK);
                return;
            }
            
            DBMain.mlogin = txtUser.Text.Trim();
            DBMain.password = txtPass.Text;
            if (DBMain.KetNoi() == 0)
                return;
            // 0 - trả về chi nhánh hiện tại
            SqlDataReader myReader;
            DBMain.mChinhanh = cbServer.SelectedIndex;
            //DBMain.bds_dspm = ds;

            DBMain.mloginDN = DBMain.mlogin;
            DBMain.passwordDN = DBMain.password;
            string strLenh = "exec KiemTraDangNhap '" + DBMain.mlogin + "'";
            myReader = DBMain.ExecSqlDataReader(strLenh);
            if (myReader == null) return;
            myReader.Read();


            DBMain.username = myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(DBMain.username))
            {
                MessageBox.Show("User không đủ quyền truy cập ! Xin vui lòng xem lại cơ sở dữ liệu.", "", MessageBoxButtons.OK);
                return;
            }
            DBMain.mHoten = myReader.GetString(1);
            DBMain.mGroup = myReader.GetString(2);
            //myReader.Close();
            //DBMain.conn.Close();
            //DBMain.frmChinh.HienThiMenu();
            MessageBox.Show("Đăng nhập thành công !!!", "", MessageBoxButtons.OK);
            if (txtUser.Text == "QuanLy01" || txtUser.Text == "QuanLy02")
            {
                FormNV frm = new FormNV();
                frm.ShowDialog();
            }
            else
            {
                Main frm = new Main();
                frm.ShowDialog();
            }
        }

       
        //BLNguoiDung blNd = new BLNguoiDung();
        //if (blNd.KtraNguoiDung(this.txtUser.Text, this.txtPass.Text, ref err))   //nguoi dung (quan ly)
        //{
        //    nguoidung = this.txtUser.Text;
        //    matkhau = this.txtPass.Text;

        //    MessageBox.Show("Đăng nhập thành công!");
        //    Main.bIsLogin = true;

        //    Main fm = new Main();
        //    fm.ShowDialog();
        //    this.Close();
        //    this.Visible = false;
        //}
        //else
        //{
        //    MessageBox.Show("Thất bại! \nMời bạn đăng nhập lại.");
        //    txtUser.ResetText();
        //    txtPass.ResetText();
        //    txtUser.Focus();
        //}
    

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
