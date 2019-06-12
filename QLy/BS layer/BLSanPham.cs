using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLy.DB_layer;

using System.Data.SqlClient;
namespace QLy.BS_layer
{
    class BLSanPham
    {
       // public static string masp = "MaSP";
       // public static string ten = "TenSP";
       // public static string gia = "GiaBan";

       //public static string LoaiSP = "MaLoai";

        DBMain db = null;
        public BLSanPham()
        {
            db = new DBMain();

        }
        public DataTable Load()
        {
            return db.ExecuteQueryDataSet("exec HienThiThongTinMonAn", CommandType.Text).Tables[0];
        }
        public DataTable LoadTenLoaiMonAn()
        {
            return db.ExecuteQueryDataSet("exec HienThiTenLoaiMonAn", CommandType.Text).Tables[0];
        }
        public bool ThemSanPham(ref string err, string MaSP, string TenSP, string Gia)
        {
            return db.MyExecuteNonQuery("ThemMonAn", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaSP", MaSP),
                new SqlParameter("@TenSP", TenSP),
                new SqlParameter("@Gia", Gia));
               
        }
        public bool SuaSanPham(ref string err, string MaSP, string TenSP, string Gia)
        {
            return db.MyExecuteNonQuery("SuaSanPham", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaSP", MaSP),
                new SqlParameter("@TenSP", TenSP),
                new SqlParameter("@Gia", Gia));

        }
        public bool XoaSP(ref string err, String MaSP)
        {
            return db.MyExecuteNonQuery("XoaSP", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaSP", MaSP));
        }
        public DataTable TimKiemThongTinMonAn(string TenSP)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM  dbo.TimKiemThongTinMonAn(N'" + TenSP + "')", CommandType.Text).Tables[0];
        }
        //public DataSet LaySanPham()
        //{
        //    return db.ExecuteQueryDataSet("select * from SANPHAM", CommandType.Text);
        //}
        //public bool ThemSanPham(string MaSp, string Tensp, float gia, float SoLuong,   string LoaiSP, ref string err)
        //{
        //    string sqlString = "Insert Into SANPHAM Values(" + "'" + MaSp + "',N'" + Tensp + "',N'" + SoLuong + "',N'" + gia + "',N'" + LoaiSP + "')";

        //    return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        //}
        //public bool XoaSanPham(ref string err, string MaSP)
        //{
        //    string sqlString = "Delete From SANPHAM Where MaSP='" + MaSP + "'";
        //    return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        //}
        //public bool CapNhatSanPham(string MaSp, string Tensp, float gia,float SoLuong,string LoaiSP,  ref string err)
        //{
        //    string sqlString = "Update SANPHAM Set TenSP=N'" + Tensp + "' ,SoLuong=N'" + SoLuong + "',GiaBan=N'" + gia + "',MaLoai=N'" + LoaiSP + "' Where MaSP='" + MaSp + "'";
        //    return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        //}

        //public DataSet TimkiemTheoMA(string tk)
        //{
        //    string sql = "select *from SANPHAM where MaSP like N'%" + tk + "%'";
        //    return db.ExecuteQueryDataSet(sql, CommandType.Text);
        //}
        //public DataSet TimkiemTheoTENSP(string tk)
        //{
        //    string sql = "select *from SANPHAM where TenSP like N'%" + tk + "%'";
        //    return db.ExecuteQueryDataSet(sql, CommandType.Text);
        //}
        //public DataSet TimkiemTheoGia(float tk)
        //{
        //    string sql = "select *from SANPHAM where GiaBan='" + tk + "'";
        //    return db.ExecuteQueryDataSet(sql, CommandType.Text);
        //}

        ////ktra
        //public DataSet ktra(string ma)
        //{
        //    string sqlString = "select * from SANPHAM where MaSP=N'" + ma + "'";
        //    return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        //}
    }
}
