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
        public static string manv = "MaNV";

        DBMain db = null;
        public BLNhanVien()
        {
            db = new DBMain();

        }
        public DataSet LayNV()
        {
            return db.ExecuteQueryDataSet("select * from NHANVIEN", CommandType.Text);
        }
        public bool ThemNV(string MaNV, string HoTen,  string GT, string DC,string DT,string Email,  ref string err)
        {
            string sqlString = "Insert Into NHANVIEN Values(" + "'" + MaNV + "',N'" + HoTen + "',N'" + GT + "',N'" + DC + "',N'" + DT + "',N'" + Email + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNV(ref string err, string MaNV)
        {
            string sqlString = "Delete From NHANVIEN Where MaNV='" + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatNV(string MaNV, string HoTen, string GT,  string DC, string DT,string Email, ref string err)
        {
            string sqlString = "Update NHANVIEN Set HoTen=N'" + HoTen + "' ,GioiTinh=N'" + GT + "',DiaChi=N'" + DC + "' ,DienThoai=N'" + DT + "' ,Email=N'" + Email + "' Where MaNV='" + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet TimkiemTheoGT(string tk)
        {
            string sql = "select *from NHANVIEN where GioiTinh like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet TimkiemTheoMA(string tk)
        {
            string sql = "select *from NHANVIEN where MaNV like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet TimkiemTheoHoTen(string tk)
        {
            string sql = "select *from NHANVIEN where HoTen like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
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
