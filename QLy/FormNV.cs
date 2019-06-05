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
using QLy.BS_layer;

namespace QLy
{
    public partial class FormNV : Form
    {
        DataTable dtNV = null;
        bool Them;
        string err;
        BLNhanVien dbNV = new BLNhanVien();
        string gt;
        string bDate;
        string sDate;

        public FormNV()
        {
            InitializeComponent();
            txtHoTen.Text = "";
          
            txtDT.Text = "";
            txtDC.Text = "";
            txtEmail.Text = "";
            
        }
        void LoadData()
        {
            try
            {
                dtNV = new DataTable();
                dtNV.Clear();
                DataSet ds = dbNV.LayNV();
                dtNV = ds.Tables[0];

                dgvNV.DataSource = dtNV;

                dgvNV.AutoResizeColumns();

                this.txtMaNV.ResetText();
                this.txtHoTen.ResetText();
               
                this.txtDC.ResetText();
                this.txtDT.ResetText();
               
                this.txtEmail.ResetText();

                this.txtTimkiem.ResetText();

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnLuu.Enabled = false;

                dgvNV_CellClick(null, null);

               // Sum(dtNV);

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NhanVien. Lỗi rồi!!!");
            }
        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        
        //
        //
        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // DateTime dt = DateTime.Now;
           // dateTimePickerNgSinh.Text = dt.ToString("dd/MM/yyyy");
           // dateTimePickerNgBD.Text = dt.ToString("dd/MM/yyyy");

            int r = dgvNV.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaNV.Text = dgvNV.Rows[r].Cells[0].Value.ToString();
            this.txtHoTen.Text = dgvNV.Rows[r].Cells[1].Value.ToString();
          
            this.gt = this.dgvNV.Rows[r].Cells[2].Value.ToString();
            if (gt.Trim() == "Nam") //trim() cắt khoản trắng 2 đầu
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }

          //  this.dateTimePickerNgSinh.Text = dgvNV.Rows[r].Cells[4].Value.ToString();
            this.txtDC.Text = dgvNV.Rows[r].Cells[3].Value.ToString();
            this.txtDT.Text = dgvNV.Rows[r].Cells[4].Value.ToString();
           // this.dateTimePickerNgBD.Text = dgvNV.Rows[r].Cells[7].Value.ToString();
           // this.txtCV.Text = dgvNV.Rows[r].Cells[8].Value.ToString();
           // this.txtCa.Text = dgvNV.Rows[r].Cells[9].Value.ToString();
            this.txtEmail.Text = dgvNV.Rows[r].Cells[5].Value.ToString();
        }
        //


        //
        #region btn chức năng
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            this.txtMaNV.ResetText();
            this.txtHoTen.ResetText();
          
            this.txtDC.ResetText();
            this.txtDT.ResetText();
            this.txtEmail.ResetText();
          //  this.txtCa.ResetText();
          //  this.txtLuong.ResetText();

            this.rdoNam.Checked = true;
            this.rdoNu.Checked = true;

            this.btnLuu.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtMaNV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;

            dgvNV_CellClick(null, null);

            this.btnLuu.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaNV.Enabled = false;
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
           // bDate = DateTime.Parse(dateTimePickerNgSinh.Text).ToString("yyyy-MM-dd");
           // sDate = DateTime.Parse(dateTimePickerNgBD.Text).ToString("yyyy-MM-dd");

          //  float salary = float.Parse(txtLuong.Text);

            if (Them)
            {
                try
                {
                    BLNhanVien blNV = new BLNhanVien();
                    blNV.ThemNV(this.txtMaNV.Text, this.txtHoTen.Text, this.gt,  this.txtDC.Text, this.txtDT.Text,this.txtEmail.Text, ref err);
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
                BLNhanVien blNV = new BLNhanVien();
                blNV.CapNhatNV(this.txtMaNV.Text, this.txtHoTen.Text, this.gt, this.txtDC.Text, this.txtDT.Text, this.txtEmail.Text, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvNV.CurrentCell.RowIndex;
                string strKH = dgvNV.Rows[r].Cells[0].Value.ToString();


                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbNV.XoaNV(ref err, strKH);
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
            txtTimkiem.ResetText();
            LoadData();
        }
        #endregion
        //


        //
        #region tìm kiếm
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataSet ds;

            dtNV = new DataTable();
            dtNV.Clear();



            if (rdoMaNV.Checked == true)
                ds = dbNV.TimkiemTheoMA(this.txtTimkiem.Text);
            else
            {
                if (rdoTen.Checked == true)
                    ds = dbNV.TimkiemTheoHoTen(this.txtTimkiem.Text);
                else
                {
                        ds = dbNV.TimkiemTheoGT(this.txtTimkiem.Text);
                }

            }
            dtNV = ds.Tables[0];
            dgvNV.DataSource = dtNV;
            dgvNV.AutoResizeColumns();
        }
        #endregion
        //


        //
       /* private void Sum(DataTable table)
        {
            lbTong.Text = table.Compute("sum(Luong)", string.Empty).ToString();
        }*/

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
