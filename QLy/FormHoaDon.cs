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
    public partial class FormHoaDon : Form
    {
        DataTable dtK = null;
        bool Them;
        string err;
        BLDonHang blDH= new BLDonHang();

        string NgLap;

        public FormHoaDon()
        {
            InitializeComponent();
            txtTong.Text = "";
        }
        void LoadData()
        {
            try
            {
                dtK = new DataTable();
                dtK.Clear();
                DataSet ds = blDH.LayDonHang();
                dtK = ds.Tables[0];

                dgvDonHang.DataSource = dtK;

                dgvDonHang.AutoResizeColumns();

                this.txtMaDH.ResetText();
                this.cbbMaKH.ResetText();
                this.cbbMaNV.ResetText();
                this.txtTong.ResetText();

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnLuu.Enabled = false;

                dgvDonHang_CellClick(null, null);

                /*
                DataTable table = new DataTable();
                table.Clear();
                BLChiTiet bl = new BLChiTiet();
                DataSet dsdh = bl.lay2cot();
                table = dsdh.Tables[0];

                dgvTien.DataSource = table;

                dgvTien.AutoResizeColumns();*/
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table DonHang. Lỗi rồi!!!");
            }
        }

        //
        //
        
        public void TinhTong(DataTable table)
        {
            //txtTong.Text = table.Compute("sum(ThanhTien)",string.Empty).ToString();
            txtTong.Text = table.Compute("sum(ThanhTien)", "MaDH").ToString();
            //txtTong.Text = table.Compute("sum(Luong)", "group by MaDH='" + txtMaDH.Text + "'").ToString();
        }
        
        //
        //

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            DateTime dt = DateTime.Now;
            dateTimePickerNGLAP.Text = dt.ToString("dd/MM/yyyy");
            
           

            int r = dgvDonHang.CurrentCell.RowIndex;

            this.txtMaDH.Text = dgvDonHang.Rows[r].Cells[0].Value.ToString();
            this.cbbMaKH.Text = dgvDonHang.Rows[r].Cells[1].Value.ToString();
            this.cbbMaNV.Text = dgvDonHang.Rows[r].Cells[2].Value.ToString();
            this.txtTong.Text = dgvDonHang.Rows[r].Cells[3].Value.ToString();
            this.dateTimePickerNGLAP.Text = dgvDonHang.Rows[r].Cells[4].Value.ToString();
            
        }
        
        private void FormDonHang_Load(object sender, EventArgs e)
        {
            LoadData();
            showCbbMaKH();
            showCbbMaNV();
        }

        //
        //
        void showCbbMaKH()
        {
            dtK = new DataTable();
            dtK.Clear();
            BLKhachHang bl = new BLKhachHang();
            DataSet ds = bl.LayKhachHang();
            dtK = ds.Tables[0];

            cbbMaKH.DataSource = dtK;
            cbbMaKH.DisplayMember = BLKhachHang.makh;
            cbbMaKH.ValueMember = BLKhachHang.makh;

        }
        void showCbbMaNV()
        {
            dtK = new DataTable();
            dtK.Clear();
            BLNhanVien bl = new BLNhanVien();
            DataSet ds = bl.LayNV();
            dtK = ds.Tables[0];

            cbbMaNV.DataSource = dtK;
            cbbMaNV.DisplayMember = BLNhanVien.manv;
            cbbMaNV.ValueMember = BLNhanVien.manv;

        }


        //
        //
        #region btn chuc nang
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            this.txtMaDH.ResetText();
            this.cbbMaKH.ResetText();
            this.cbbMaNV.ResetText();
            this.txtTong.ResetText();


            this.btnLuu.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtMaDH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;

            dgvDonHang_CellClick(null, null);

            this.btnLuu.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaDH.Enabled = false;
            this.cbbMaKH.ResetText();
            this.cbbMaNV.ResetText();
            this.txtTong.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            NgLap = DateTime.Parse(dateTimePickerNGLAP.Text).ToString("yyyy-MM-dd");

            float tien;
            if(txtTong.Text=="")
            {
                tien = 0;
            }
            else
                tien = float.Parse(txtTong.Text);


            if (Them)
            {
                try
                {
                    BLDonHang bldh = new BLDonHang();
                    bldh.ThemDonHang(this.txtMaDH.Text, this.cbbMaKH.Text, this.cbbMaNV.Text, tien, NgLap, ref err);
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
                BLDonHang bldh = new BLDonHang();
                bldh.CapNhatDonHang(this.txtMaDH.Text, this.cbbMaKH.Text, this.cbbMaNV.Text, tien, NgLap, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvDonHang.CurrentCell.RowIndex;
                string strDH = dgvDonHang.Rows[r].Cells[0].Value.ToString();


                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    blDH.XoaDonHang(ref err, strDH);
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
            showCbbMaKH();
            showCbbMaNV();


            

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
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
                if (rdoMaNV.Checked == true)
                {
                    ds = blDH.TimkiemTheoMaNV(txtTimkiem.Text);
                }
                else
                    ds = blDH.TimkiemTheoMaKH(txtTimkiem.Text);
            }

            dtK = ds.Tables[0];
            dgvDonHang.DataSource = dtK;
            dgvDonHang.AutoResizeColumns();
        }

        private void btnChitiet_Click(object sender, EventArgs e)
        {
            FormChiTiet f = new FormChiTiet();
            f.ShowDialog();
        }

        private void btnCapNhatTong_Click(object sender, EventArgs e)
        {

            //cập nhật tổng tiền
            float g;
            g= float.Parse(txtTong.Text);

            dtK.Clear();
            BLChiTiet bl = new BLChiTiet();
            DataSet dsdh = bl.ktra(txtMaDH.Text);
            dsdh = bl.lay2cot();
            dtK = dsdh.Tables[0];

            foreach (DataRow a in dtK.Rows)
            {
                if (txtMaDH.Text == a[BLDonHang.madh].ToString())
                {
                    txtTong.Text = a[BLChiTiet.money].ToString();
                    g = float.Parse(txtTong.Text);
                    blDH.CapNhatDonHang(this.txtMaDH.Text, this.cbbMaKH.Text, this.cbbMaNV.Text, g, NgLap, ref err);
                    LoadData();
                }

            }
            

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
