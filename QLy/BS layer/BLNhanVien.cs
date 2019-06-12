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
    class BLNhanVien
    {
        //public static string manv = "MaNV";

        DBMain db = null;
        public BLNhanVien()
        {
            db = new DBMain();

        }
        public DataTable Load()
        {
            return db.ExecuteQueryDataSet("exec HienThiThongTinNhanVien", CommandType.Text).Tables[0];
        }
        public bool ThemNhanVien(ref string err, string MaNV, string HoTen, string GioiTinh,
                                  string DiaChi, string DienThoai, string Email,string TenDN, string MaCN)
        {
            return db.MyExecuteNonQuery("ThemNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@HoTen", HoTen),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@DienThoai", DienThoai),
                new SqlParameter("@Email", Email),
                new SqlParameter("@TenDN", TenDN),
                new SqlParameter("@MaCN", MaCN));
                
        }
        public bool SuaNhanVien(ref string err, string MaNV, string HoTen, string GioiTinh,
                                  string DiaChi, string DienThoai, string Email,string TenDN, string MaCN)
        {
            return db.MyExecuteNonQuery("SuaNhanVien", CommandType.StoredProcedure, ref err,
               new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@HoTen", HoTen),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@DienThoai", DienThoai),
                new SqlParameter("@Email", Email),
                new SqlParameter("@TenDN", TenDN),
                new SqlParameter("@MaCN", MaCN));
        }
        public bool XoaNhanVien(ref string err, string MaNV)
        {
            return db.MyExecuteNonQuery("XoaNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", MaNV));
        }
        public DataSet TimKiemNVTheoMaNV(string MaNV)
        {
            return db.ExecuteQueryDataSet("exec TimKiemNVTheoMaNV '" + MaNV + "'", CommandType.Text, null);
        }
        //public DataSet LayNV()
        //{
        //    return db.ExecuteQueryDataSet("select * from NHANVIEN", CommandType.Text);
        //}
        //public bool ThemNV(string MaNV, string HoTen,  string GT, string DC,string DT,string Email,  ref string err)
        //{
        //    string sqlString = "Insert Into NHANVIEN Values(" + "'" + MaNV + "',N'" + HoTen + "',N'" + GT + "',N'" + DC + "',N'" + DT + "',N'" + Email + "')";
        //    return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        //}
        //public bool XoaNV(ref string err, string MaNV)
        //{
        //    string sqlString = "Delete From NHANVIEN Where MaNV='" + MaNV + "'";
        //    return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        //}
        //public bool CapNhatNV(string MaNV, string HoTen, string GT,  string DC, string DT,string Email, ref string err)
        //{
        //    string sqlString = "Update NHANVIEN Set HoTen=N'" + HoTen + "' ,GioiTinh=N'" + GT + "',DiaChi=N'" + DC + "' ,DienThoai=N'" + DT + "' ,Email=N'" + Email + "' Where MaNV='" + MaNV + "'";
        //    return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        //}

        //public DataSet TimkiemTheoGT(string tk)
        //{
        //    string sql = "select *from NHANVIEN where GioiTinh like N'%" + tk + "%'";
        //    return db.ExecuteQueryDataSet(sql, CommandType.Text);
        //}
        //public DataSet TimkiemTheoMA(string tk)
        //{
        //    string sql = "select *from NHANVIEN where MaNV like N'%" + tk + "%'";
        //    return db.ExecuteQueryDataSet(sql, CommandType.Text);
        //}
        //public DataSet TimkiemTheoHoTen(string tk)
        //{
        //    string sql = "select *from NHANVIEN where HoTen like N'%" + tk + "%'";
        //    return db.ExecuteQueryDataSet(sql, CommandType.Text);
        //}
        /* public DataSet TimkiemTheoDC(string tk)
         {
             string sql = "select *from NHANVIEN where DiaChi like N'%" + tk + "%'";
             return db.ExecuteQueryDataSet(sql, CommandType.Text);
         }
         public DataSet TimkiemTheoCV(string tk)
         {
             string sql = "select *from NHANVIEN where CongViec like N'%" + tk + "%'";
             return db.ExecuteQueryDataSet(sql, CommandType.Text);
         }
         public DataSet TimkiemTheoLuong(float tk)
         {
             string sql = "select *from NHANVIEN where Luong='" + tk + "'";
             return db.ExecuteQueryDataSet(sql, CommandType.Text);
         }*/

    }
}
