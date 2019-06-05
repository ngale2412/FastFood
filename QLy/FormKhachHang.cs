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
    public partial class FormKhachHang : Form
    {
        DataTable dtKhachHang = null;
        bool Them;
        string err;
        BLKhachHang dbKH = new BLKhachHang();
        string gt;

        public FormKhachHang()
        {
            InitializeComponent();
            txtDC.Text = "";
            txtDT.Text = "";
        }

        void LoadData()
        {
            try
            {
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                DataSet ds = dbKH.LayKhachHang();
                dtKhachHang = ds.Tables[0];

                dgvKH.DataSource = dtKhachHang;

                dgvKH.AutoResizeColumns();

                this.txtMaKH.ResetText();
                this.txtHoTen.ResetText();
                this.txtDC.ResetText();
                this.txtDT.ResetText();

                this.txtTimkiem.ResetText();

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnLuu.Enabled = false;

                dgvKH_CellClick(null, null);

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NGUOIDUNG. Lỗi rồi!!!");
            }
        }
        //
        //

        #region btn chuc nang them sua xoa luu
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            this.txtMaKH.ResetText();
            this.txtHoTen.ResetText();
            this.txtDT.ResetText();
            this.txtDC.ResetText();
            //this.txtGT.ResetText();
            this.rdoNam.Checked = true;
            this.rdoNu.Checked = true;

            this.btnLuu.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtMaKH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;

            dgvKH_CellClick(null, null);

            this.btnLuu.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaKH.Enabled = false;
            this.txtHoTen.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (rdoNam.Checked == true)
                gt = "Nam";
            else
            {
                if (rdoNu.Checked == true)
                    gt = "Nu";
            }

            if (Them)
            {
                try
                {
                    BLKhachHang blkh = new BLKhachHang();
                    blkh.ThemKhachHang(this.txtMaKH.Text, this.txtHoTen.Text, this.txtDT.Text, this.txtDC.Text, this.gt, ref err);
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
                BLKhachHang blKh = new BLKhachHang();
                blKh.CapNhatKhachHang(this.txtMaKH.Text, this.txtHoTen.Text, this.txtDT.Text, this.txtDC.Text, this.gt, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvKH.CurrentCell.RowIndex;
                string strKH = dgvKH.Rows[r].Cells[0].Value.ToString();


                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbKH.XoaKhachHang(ref err, strKH);
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
        #endregion

        //
        //
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtTimkiem.ResetText();
            LoadData();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataSet ds;

            dtKhachHang = new DataTable();
            dtKhachHang.Clear();



            if (rdoMaKH.Checked == true)
                ds = dbKH.TimkiemTheoMaKH(this.txtTimkiem.Text);
            else
            {
                if (rdoTen.Checked == true)
                    ds = dbKH.TimkiemTheoTEN(this.txtTimkiem.Text);
                else
                {
                    ds = dbKH.TimkiemTheoGT(this.txtTimkiem.Text);
                    
                }
            }

            dtKhachHang = ds.Tables[0];
            dgvKH.DataSource = dtKhachHang;
            dgvKH.AutoResizeColumns();
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKH.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaKH.Text =
            dgvKH.Rows[r].Cells[0].Value.ToString();
            this.txtHoTen.Text =
            dgvKH.Rows[r].Cells[1].Value.ToString();
            this.txtDT.Text =
            dgvKH.Rows[r].Cells[2].Value.ToString();
            this.txtDC.Text =
            dgvKH.Rows[r].Cells[3].Value.ToString();

            this.gt = this.dgvKH.Rows[r].Cells[4].Value.ToString();
            if (gt.Trim() == "Nam") //trim() cắt khoản trắng 2 đầu
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
