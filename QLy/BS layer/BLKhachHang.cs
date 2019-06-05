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
    class BLKhachHang
    {
        public static string makh = "MaKH";

        DBMain db = null;
        public BLKhachHang()
        {
            db = new DBMain();
            
        }
        public DataSet LayKhachHang()
        {
            return db.ExecuteQueryDataSet("select * from KHACHHANG", CommandType.Text);
        }
        public bool ThemKhachHang(string MaKH, string HoTen, string DienThoai, string DiaChi, string gt, ref string err)
        {
            string sqlString = "Insert Into KHACHHANG Values(" + "'" + MaKH + "',N'" + HoTen + "',N'" + DienThoai + "',N'" + DiaChi + "',N'" + gt + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaKhachHang(ref string err, string MaKH)
        {
            string sqlString = "Delete From KHACHHANG Where MaKH='" + MaKH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatKhachHang(string MaKH, string HoTen, string DienThoai, string DiaChi, string gt, ref string err)
        { 
            string sqlString = "Update KHACHHANG Set HoTen=N'" + HoTen + "' ,DienThoai=N'" + DienThoai + "' ,DiaChi=N'" + DiaChi + "' ,GioiTinh=N'" + gt + "' Where MaKH='" + MaKH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet TimkiemTheoTEN(string tk)
        {
            string sql = "select *from KHACHHANG where HoTen like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet TimkiemTheoMaKH(string tk)
        {
            string sql = "select *from KHACHHANG where MaKH like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        
        public DataSet TimkiemTheoGT(string tk)
        {
            string sql = "select *from KHACHHANG where GioiTinh like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
    }
}
