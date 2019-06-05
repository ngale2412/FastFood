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
    public partial class FormKHO : Form
    {
        DataTable dtK = null;
        bool Them;
        string err;
        BLKho dbK = new BLKho();
  
        string NSX;
        string HSD;

        public FormKHO()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtK = new DataTable();
                dtK.Clear();
                DataSet ds = dbK.LaySanPhamKho();
                dtK = ds.Tables[0];

                dgvKho.DataSource = dtK;

                dgvKho.AutoResizeColumns();

                this.cbbMaSP.ResetText();        
                this.txtTen.ResetText();               
                this.txtSoluong.ResetText();

                txtTimkiem.ResetText();

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnLuu.Enabled = false;

                dgvKho_CellClick(null, null);

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NhanVien. Lỗi rồi!!!");
            }
        }
       


        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DateTime dt = DateTime.Now;
            dateTimePickerHSD.Text = dt.ToString("dd/MM/yyyy");
            dateTimePickerNXS.Text = dt.ToString("dd/MM/yyyy");
            

            int r = dgvKho.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.cbbMaSP.Text = dgvKho.Rows[r].Cells[0].Value.ToString();
            this.txtTen.Text = dgvKho.Rows[r].Cells[1].Value.ToString();
            this.dateTimePickerNXS.Text = dgvKho.Rows[r].Cells[2].Value.ToString();         
            this.dateTimePickerHSD.Text = dgvKho.Rows[r].Cells[3].Value.ToString();
            this.txtSoluong.Text = dgvKho.Rows[r].Cells[4].Value.ToString();

        }

        //
        //
        private void FormKHO_Load(object sender, EventArgs e)
        {
            LoadData();
            showCbbMaSP();
        }
        //
        //

        #region btn chuc nang them,xoa,sua,luu
        //
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            
            this.txtTen.ResetText();
            this.txtSoluong.ResetText();


            this.btnLuu.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.cbbMaSP.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;

            dgvKho_CellClick(null, null);

            this.btnLuu.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.cbbMaSP.Enabled = false;
            this.txtTen.Enabled = false;
            this.txtSoluong.Focus();
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {

            NSX = DateTime.Parse(dateTimePickerNXS.Text).ToString("yyyy-MM-dd");
            HSD = DateTime.Parse(dateTimePickerHSD.Text).ToString("yyyy-MM-dd");

            int sl = int.Parse(txtSoluong.Text);


            if (Them)
            {
                try
                {
                    BLKho blK = new BLKho();
                    blK.ThemSanPhamKho(this.cbbMaSP.Text, this.txtTen.Text, NSX, HSD, sl, ref err);
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
                BLKho blK = new BLKho();
                blK.CapNhatSanPhamKho(this.cbbMaSP.Text, this.txtTen.Text, NSX, HSD, sl, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvKho.CurrentCell.RowIndex;
                string strKho = dgvKho.Rows[r].Cells[0].Value.ToString();


                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbK.XoaSanPhamKho(ref err, strKho);
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
            showCbbMaSP();
            LoadData();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataSet ds;

            dtK = new DataTable();
            dtK.Clear();

            if (rdonxs.Checked == true)
            {
                NSX = DateTime.Parse(txtTimkiem.Text).ToString("yyyy-MM-dd");
                ds = dbK.TimkiemTheoNSX(NSX);
            }

            else
            {
                if (rdohsd.Checked == true)
                {
                    HSD = DateTime.Parse(txtTimkiem.Text).ToString("yyyy-MM-dd");
                    ds = dbK.TimkiemTheoHSD(HSD);
                }
                else
                    ds = dbK.TimkiemTheoTENSP(txtTimkiem.Text);
            }

            dtK = ds.Tables[0];
            dgvKho.DataSource = dtK;
            dgvKho.AutoResizeColumns();
        }


        //
        //
        #region load vào combobox và đổ ra textbox
        void showCbbMaSP()
        {
            dtK = new DataTable();
            dtK.Clear();
            BLSanPham bl = new BLSanPham();
            DataSet ds = bl.LaySanPham();
            dtK = ds.Tables[0];

            cbbMaSP.DataSource = dtK;
            cbbMaSP.DisplayMember = BLSanPham.masp;
            cbbMaSP.ValueMember = BLSanPham.masp;

        }
        private void cbbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLSanPham blsp = new BLSanPham();
            dtK = new DataTable();
            dtK.Clear();

            DataSet ds = blsp.ktra(cbbMaSP.Text); ;
            dtK = ds.Tables[0];
            foreach (DataRow a in dtK.Rows)
            {
                txtTen.Text = a[BLSanPham.ten].ToString();
            }

            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
        //
        //
    }
}
