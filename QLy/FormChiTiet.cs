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
    public partial class FormChiTiet : Form
    {
        public static string bTien;

        DataTable dtK = null;
        bool Them;
        string err;
        BLChiTiet blDH = new BLChiTiet();

        public FormChiTiet()
        {
            InitializeComponent();
            this.txtTien.Enabled = true;
        }

        void LoadData()
        {
            try
            {
                dtK = new DataTable();
                dtK.Clear();
                DataSet ds = blDH.LayChiTietDH();
                dtK = ds.Tables[0];

                dgvCT.DataSource = dtK;

                dgvCT.AutoResizeColumns();

                this.cbbMaDH.ResetText();
               // this.txtMaKH.ResetText();
                this.cbbMaSP.ResetText();
                this.txtSL.ResetText();
                this.txtGia.ResetText();
                
              
                this.txtTien.ResetText();

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnLuu.Enabled = false;

                dgvCT_CellClick(null, null);
                

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table ChiTiet. Lỗi rồi!!!");
            }
        }

        //
        #region btn chuc nang
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            this.cbbMaDH.ResetText();
           // this.txtMaKH.ResetText();
            this.cbbMaSP.ResetText();
            this.txtSL.ResetText();
            this.txtGia.ResetText();
            this.txtTien.ResetText();

            this.txtTien.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.cbbMaDH.Focus();

            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;

            dgvCT_CellClick(null, null);

            this.txtTien.Enabled = false;
            this.btnLuu.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.cbbMaDH.Enabled = false;
           // this.txtMaKH.Enabled = false;
            this.cbbMaSP.ResetText();
            this.txtSL.ResetText();
            this.txtGia.ResetText();
            this.txtTien.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(txtSL.Text);
            float gia = float.Parse(txtGia.Text);

            float g;
            float t;
            g = float.Parse(txtGia.Text);
            t = g * sl;
            txtTien.Text = t.ToString();
            dtK = new DataTable();
            dtK.Clear();
            DataSet ds = blDH.LayChiTietDH();
            dtK = ds.Tables[0];
            foreach (DataRow a in dtK.Rows)
            {
                txtTien.Text = t.ToString();
            }


            
            if (Them)
            {
                try
                {
                    BLChiTiet bldh = new BLChiTiet();
                    bldh.ThemChitiet(this.cbbMaDH.Text, this.cbbMaSP.Text, sl, gia, t, ref err);
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
                BLChiTiet bldh = new BLChiTiet();
                bldh.CapNhatChitiet(this.cbbMaDH.Text, this.cbbMaSP.Text,  sl, gia, t, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
            bTien = txtTien.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvCT.CurrentCell.RowIndex;
                string strDH = dgvCT.Rows[r].Cells[1].Value.ToString();


                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    blDH.XoaChiTiet(ref err, strDH);
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


        private void dgvCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCT.CurrentCell.RowIndex;

            this.cbbMaDH.Text = dgvCT.Rows[r].Cells[0].Value.ToString();
           // this.txtMaKH.Text = dgvCT.Rows[r].Cells[2].Value.ToString();
            this.cbbMaSP.Text = dgvCT.Rows[r].Cells[1].Value.ToString();
            
            this.txtSL.Text = dgvCT.Rows[r].Cells[3].Value.ToString();
            this.txtGia.Text = dgvCT.Rows[r].Cells[4].Value.ToString();
            this.txtTien.Text = dgvCT.Rows[r].Cells[5].Value.ToString();
        }

        private void FormChiTiet_Load(object sender, EventArgs e)
        {
            LoadData();
            showCbbMaDH();
            showCbbMaSp();
           
        }

        
        //
        //
        #region xử lý combobox load lên textbox
        //load vào combobox đơn hàng
        void showCbbMaDH()
        {
            dtK = new DataTable();
            dtK.Clear();
            BLDonHang bl = new BLDonHang();
            DataSet ds = bl.LayDonHang();
            dtK = ds.Tables[0];

            cbbMaDH.DataSource = dtK;
            cbbMaDH.DisplayMember = BLDonHang.madh;
            cbbMaDH.ValueMember = BLDonHang.madh;
        }
        //load vào combobox sản phẩm
        void showCbbMaSp()
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

        //private void cbbMaDH_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    dtK = new DataTable();
        //    dtK.Clear();
        //    DataSet ds = blDH.ktra(cbbMaDH.Text); ;
        //    dtK = ds.Tables[0];
        //    foreach (DataRow a in dtK.Rows)
        //    {
        //        txtMaKH.Text = a[BLKhachHang.makh].ToString();
        //    }
       
        //}

        private void cbbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLSanPham blsp = new BLSanPham();
            dtK = new DataTable();
            dtK.Clear();
            DataSet ds = blsp.ktra(cbbMaSP.Text); ;
            dtK = ds.Tables[0];
            float g;

            foreach (DataRow a in dtK.Rows)
            {
                txtGia.Text = a[BLSanPham.gia].ToString();
                g = float.Parse(txtGia.Text);
            }

        }




        #endregion
        //

        //
        //
        #region Tìm Kiếm+ Cập Nhật
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtTimkiem.ResetText();
            LoadData();
            showCbbMaDH();
            showCbbMaSp();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataSet ds;

            dtK = new DataTable();
            dtK.Clear();

            if (rdoMaDH.Checked == true)
            {
                ds = blDH.TimkiemTheoMaDH(txtTimkiem.Text);
            }

            else
            {
                //if (rdoMakh.Checked == true)
                //{
                //    ds = blDH.TimkiemTheoMaKH(txtTimkiem.Text);
                //}
                //else
                    ds = blDH.TimkiemTheoMaSP(txtTimkiem.Text);
            }

            dtK = ds.Tables[0];
            dgvCT.DataSource = dtK;
            dgvCT.AutoResizeColumns();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        //

    }
}
