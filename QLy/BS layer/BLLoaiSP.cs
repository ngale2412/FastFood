using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLy.DB_layer;

namespace QLy.BS_layer
{
    class BLLoaiSP
    {
        DBMain db = null;
        public BLLoaiSP()
        {
            db = new DBMain();

        }
        public DataTable Load()
        {
            return db.ExecuteQueryDataSet("exec HienThiThongTinLoaiMonAn", CommandType.Text).Tables[0];
        }

        public bool ThemLoaiMonAn(ref string err, string MaLoaiSP, string TenLoaiSP)
        {
            return db.MyExecuteNonQuery("ThemLoaiMonAn", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLoaiSP", MaLoaiSP),
                new SqlParameter("@TenLoaiSP", TenLoaiSP));
               
        }
        public bool SuaLoaiMonAn(ref string err, string MaLoaiSP, string TenLoaiSP)
        {
            return db.MyExecuteNonQuery("ThemLoaiMonAn", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLoaiSP", MaLoaiSP),
                new SqlParameter("@TenLoaiSP", TenLoaiSP));

        }
        public bool XoaLoaiMonAn(ref string err, String MaLoaiSP)
        {
            return db.MyExecuteNonQuery("XoaLoaiMonAn", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLoaiSP", MaLoaiSP));
        }
        //public DataSet LayLoaiSanPham()
        //{
        //    return db.ExecuteQueryDataSet("select * from LOAISP", CommandType.Text);
        //}
        //public bool ThemLoaiSanPham(string MaLoaiSp, string TenLoaisp, ref string err)
        //{
        //    string sqlString = "Insert Into LOAISP Values(" + "'" + MaLoaiSp + "',N'" + TenLoaisp + "')";
        //    return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        //}
        //public bool XoaLoaiSanPham(ref string err, string MaloaiSP)
        //{
        //    string sqlString = "Delete From LOAISP Where MaLoai='" + MaloaiSP + "'";
        //    return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        //}
        //public bool CapNhatLoaiSanPham(string MaLoaiSp, string TenLoaisp, ref string err)
        //{
        //    string sqlString = "Update KHO Set TenSP=N'" + TenLoaisp + "'";
        //    return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        //}


        ////tìm kiếm
        //public DataSet TimkiemTheoMALOAISP(string tk)
        //{
        //    string sql = "select *from LOAISP where MaLoai like N'%" + tk + "%'";
        //    return db.ExecuteQueryDataSet(sql, CommandType.Text);
        //}


        //public DataSet TimkiemTheoTENLOAISP(string tk)
        //{
        //    string sql = "select *from LOAISP where TenLoai like N'%" + tk + "%'";
        //    return db.ExecuteQueryDataSet(sql, CommandType.Text);
        //}




    }
}
