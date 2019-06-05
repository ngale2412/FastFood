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
    public partial class FormNVTim : Form
    {
        DataTable dtNhanvien = null;
        BLNhanVien dbNV = new BLNhanVien();
        public FormNVTim()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtNhanvien = new DataTable();
                dtNhanvien.Clear();
                DataSet ds = dbNV.LayNV();
                dtNhanvien = ds.Tables[0];

                dgvTimNV.DataSource = dtNhanvien;

                dgvTimNV.AutoResizeColumns();

                this.txtTimkiem.ResetText();

                dgvTimNV_CellClick(null, null);


            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NhanVien. Lỗi rồi!!!");
            }
        }

        private void dgvTimNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTimNV.CurrentCell.RowIndex;
            this.txtTimkiem.Text = dgvTimNV.Rows[r].Cells[0].Value.ToString();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataSet ds;

            dtNhanvien = new DataTable();
            dtNhanvien.Clear();



            if (rdoMaNV.Checked == true)
                ds = dbNV.TimkiemTheoMA(this.txtTimkiem.Text);
            else
            {
                if (rdoTen.Checked == true)
                    ds = dbNV.TimkiemTheoHoTen(this.txtTimkiem.Text);
                else
                {
                    if (rdoGT.Checked == true)
                        ds = dbNV.TimkiemTheoGT(this.txtTimkiem.Text);
                    else
                    {
                        if (rdoDC.Checked == true)
                            ds = dbNV.TimkiemTheoDC(this.txtTimkiem.Text);
                        else
                        {
                            if (rdoCV.Checked == true)
                                ds = dbNV.TimkiemTheoCV(this.txtTimkiem.Text);
                            else
                            {
                                float salary = float.Parse(txtTimkiem.Text);
                                ds = dbNV.TimkiemTheoLuong(salary);
                            }
                        }

                    }
                }
            }
            dtNhanvien = ds.Tables[0];

            dgvTimNV.DataSource = dtNhanvien;

            dgvTimNV.AutoResizeColumns();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTimkiem.ResetText();
            LoadData();
        }

        private void FormNVTim_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
