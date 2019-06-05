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
        public bool ThemNV(string MaNV, string HoTenDem, string Ten, string GT, string Ngsinh,string DC,string DT, string NgBD, string CV,string Ca, float Luong, ref string err)
        {
            string sqlString = "Insert Into NHANVIEN Values(" + "'" + MaNV + "',N'" + HoTenDem + "',N'" + Ten + "',N'" + GT + "',N'" + Ngsinh + "',N'" + DC + "',N'" + DT + "',N'" + NgBD + "',N'" + CV + "',N'" + Ca + "',N'" + Luong + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNV(ref string err, string MaNV)
        {
            string sqlString = "Delete From NHANVIEN Where MaNV='" + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatNV(string MaNV, string HoTenDem, string Ten, string GT, string Ngsinh, string DC, string DT, string NgBD, string CV, string Ca, float Luong, ref string err)
        {
            string sqlString = "Update NHANVIEN Set HoTenDem=N'" + HoTenDem + "' ,Ten=N'" + Ten + "' ,GioiTinh=N'" + GT + "' ,NgSinh=N'" + Ngsinh + "' ,DiaChi=N'" + DC + "' ,DienThoai=N'" + DT + "' ,NgayBatdau=N'" + NgBD + "' ,CongViec=N'" + CV + "' ,Ca=N'" + Ca + "' ,Luong=N'" +Luong + "' Where MaNV='" + MaNV + "'";
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
            string sql = "select *from NHANVIEN where Ten like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet TimkiemTheoDC(string tk)
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
        }

    }
}
