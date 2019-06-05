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
using System.Data.SqlClient;

namespace QLy
{
    public partial class FormCaNhan : Form
    {
        private string err;
        DataTable dtCaNhan = null;
        BLNguoiDung blnd = new BLNguoiDung();
        FormDangNhap fdn = new FormDangNhap();
        

        public FormCaNhan()
        {
            InitializeComponent();
            
        }

        void load()
        {
            BLNguoiDung blNd = new BLNguoiDung();
            if (blNd.KtraNguoiDung(FormDangNhap.nguoidung, FormDangNhap.matkhau, ref err))
            {

                this.txtShowPass.ResetText();
                this.txtShowUser.ResetText();
                this.txtNhapPass.ResetText();
                this.txtNhaplaiPass.ResetText();

                this.lbUser.Text = FormDangNhap.nguoidung;
                this.lbPass.Text = FormDangNhap.matkhau;
               
            }
            
        }

        private void FormCaNhan_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtNhapPass.Text.Trim()==txtNhaplaiPass.Text.Trim())
            {
                BLNguoiDung blnd = new BLNguoiDung();
                blnd.CapNhatNguoiDung(lbUser.Text, txtNhaplaiPass.Text, ref err);
                MessageBox.Show("Đã sửa xong!");
            }
            else
            {
                MessageBox.Show("Nhập sai!");
                txtNhaplaiPass.Focus();
            }
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtShowPass.Text.Trim() == txtShowPassRe.Text.Trim())
            {
                try
                {
                    BLNguoiDung blnd = new BLNguoiDung();
                    blnd.ThemNguoiDung(txtShowUser.Text, txtShowPass.Text, ref err);

                    dtCaNhan = new DataTable();
                    dtCaNhan.Clear();
                    DataSet ds = blnd.layCaNhan(txtShowUser.Text, txtShowPass.Text, ref err);
                    dtCaNhan = ds.Tables[0];
                    dgvCaNhan.DataSource = dtCaNhan;
                    dgvCaNhan.AutoResizeColumns();

                    MessageBox.Show("Đã thêm xong!");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                MessageBox.Show("Nhập lại!");
            }
                
        }
    }
}
