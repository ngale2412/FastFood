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
    public partial class FormKHOtim : Form
    {
        DataTable dt = null;
        BLKho db = new BLKho();
        string NSX;
        string HSD;

        public FormKHOtim()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dt = new DataTable();
                dt.Clear();
                DataSet ds = db.LaySanPhamKho();
                dt = ds.Tables[0];

                dgvTimKho.DataSource = dt;
                dgvTimKho.AutoResizeColumns();

                this.txtTimkiem.ResetText();

                dgvTimKho_CellClick(null, null);


            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Kho. Lỗi rồi!!!");
            }
        }

        private void dgvTimKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTimKho.CurrentCell.RowIndex;
            this.txtTimkiem.Text = dgvTimKho.Rows[r].Cells[0].Value.ToString();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataSet ds;

            dt = new DataTable();
            dt.Clear();

            if (rdonxs.Checked == true)
            {
                NSX = DateTime.Parse(txtTimkiem.Text).ToString("yyyy-MM-dd");
                ds = db.TimkiemTheoNSX(NSX);
            }

            else
            {
                if (rdohsd.Checked == true)
                {
                    HSD = DateTime.Parse(txtTimkiem.Text).ToString("yyyy-MM-dd");
                    ds = db.TimkiemTheoHSD(HSD);
                }
                else
                    ds = db.TimkiemTheoTENSP(txtTimkiem.Text);
            }

            dt = ds.Tables[0];
            dgvTimKho.DataSource = dt;
            dgvTimKho.AutoResizeColumns();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTimkiem.ResetText();
            LoadData();

        }

        private void FormKHOtim_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
