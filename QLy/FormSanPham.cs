using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using QLy.BS_layer;
using System.Data.SqlClient;

namespace QLy
{
    public partial class FormSanPham : Form
    {
        DataTable dtSp = null;
        bool Them;
        string err;
        BLSanPham dbSP = new BLSanPham();

        public FormSanPham()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtSp = new DataTable();
                dtSp.Clear();
                DataSet ds = dbSP.LaySanPham();
                dtSp = ds.Tables[0];

                dgvSP.DataSource = dtSp;

                dgvSP.AutoResizeColumns();

                this.txtMasp.ResetText();
                this.txtTen.ResetText();
                
               
                this.txtSoLuong.ResetText();
                this.txtGia.ResetText();
                this.txtLoaiSP.ResetText();
                this.txtTimkiem.ResetText();

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnLuu.Enabled = false;

                dgvSP_CellClick(null, null);

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NGUOIDUNG. Lỗi rồi!!!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            this.txtMasp.ResetText();
            this.txtTen.ResetText();
            this.txtSoLuong.ResetText();
            this.txtGia.ResetText();
            this.txtLoaiSP.ResetText();

            this.btnLuu.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtMasp.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;

            dgvSP_CellClick(null, null);

            this.btnLuu.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMasp.Enabled = false;
            this.txtTen.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float gia = float.Parse(txtGia.Text);
            float SL = float.Parse(txtSoLuong.Text);
            if (Them)
            {
                try
                {
                    BLSanPham blsp = new BLSanPham();
                    //blsp.ThemSanPham(this.txtMasp.Text, this.txtTen.Text, gia,SL, ref err);
                    blsp.ThemSanPham(this.txtMasp.Text, this.txtTen.Text, SL, gia,this.txtLoaiSP.Text, ref err);
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                BLSanPham blsp = new BLSanPham();
                blsp.CapNhatSanPham(this.txtMasp.Text, this.txtTen.Text, SL,gia,this.txtLoaiSP.Text, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvSP.CurrentCell.RowIndex;
                string strSP = dgvSP.Rows[r].Cells[0].Value.ToString();


                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbSP.XoaSanPham(ref err, strSP);
                    LoadData();
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataSet ds;

            dtSp = new DataTable();
            dtSp.Clear();



            if (rdotensp.Checked == true)
                ds = dbSP.TimkiemTheoTENSP(this.txtTimkiem.Text);
            else
            {
                float gia = float.Parse(txtTimkiem.Text);
                ds = dbSP.TimkiemTheoGia(gia);
            }

            dtSp = ds.Tables[0];
            dgvSP.DataSource = dtSp;
            dgvSP.AutoResizeColumns();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvSP.CurrentCell.RowIndex;
            // Chuyển  thông tin lên panel
            this.txtMasp.Text =
            dgvSP.Rows[r].Cells[0].Value.ToString();
            this.txtTen.Text =
            dgvSP.Rows[r].Cells[1].Value.ToString();
            this.txtSoLuong.Text =
            dgvSP.Rows[r].Cells[2].Value.ToString();
            this.txtGia.Text =
           dgvSP.Rows[r].Cells[3].Value.ToString();
            this.txtLoaiSP.Text =
           dgvSP.Rows[r].Cells[5].Value.ToString();
        } 

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
 