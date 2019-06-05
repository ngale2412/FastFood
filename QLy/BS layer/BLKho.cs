using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLy.DB_layer;

namespace QLy.BS_layer
{
    class BLKho
    {
        DBMain db = null;
        public BLKho()
        {
            db = new DBMain();

        }
        public DataSet LaySanPhamKho()
        {
            return db.ExecuteQueryDataSet("select * from KHO", CommandType.Text);
        }
        public bool ThemSanPhamKho(string MaSp, string Tensp, string nxs, string hsd, int sl, ref string err)
        {
            string sqlString = "Insert Into KHO Values(" + "'" + MaSp + "',N'" + Tensp + "',N'" + nxs + "',N'" + hsd + "',N'" + sl + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        public bool XoaSanPhamKho(ref string err, string MaSP)
        {
            string sqlString = "Delete From KHO Where MaSP='" + MaSP + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatSanPhamKho(string MaSp, string Tensp, string nxs, string hsd, int sl, ref string err)
        {
            string sqlString = "Update KHO Set TenSP=N'" + Tensp + "' ,NXS=N'" + nxs + "' ,HSD=N'" + hsd + "' ,SoLuong=N'" + sl + "' Where MaSP='" + MaSp + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


        //tìm kiếm
        public DataSet TimkiemTheoTENSP(string tk)
        {
            string sql = "select *from KHO where TenSP like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
       
        public DataSet TimkiemTheoHSD(string tk)
        {
            string sql = "select *from KHO where HSD like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public DataSet TimkiemTheoNSX(string tk)
        {
            string sql = "select *from KHO where NSX like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        
        
    }
}
