using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


using QLy.DB_layer;

namespace QLy.BS_layer
{
    class BLDonHang
    {
        public static string madh = "MaHD";

        DBMain db = null;
        public BLDonHang()
        {
            db = new DBMain();

        }
        public DataSet LayDonHang()
        {
            return db.ExecuteQueryDataSet("select * from HOADON", CommandType.Text);
        }
        public bool ThemDonHang(string MaDH, string MaKH, string MaNV,  float tong, string NgLap, ref string err)
        {
            string sqlString = "Insert Into HOADON Values(" + "'" + MaDH + "',N'" + MaKH + "',N'" + MaNV + "',N'" + tong + "',N'" + NgLap + "')";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        public bool XoaDonHang(ref string err, string MaDH)
        {
            string sqlString = "Delete From HOADON Where MaHD='" + MaDH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatDonHang(string MaDH, string MaKH, string MaNV, float tong, string NgLap,  ref string err)
        {
            string sqlString = "Update HOADON Set MaKH=N'" + MaKH + "' ,MaNV=N'" + MaNV + "',TongTien=N'" + tong + "' ,NgayLap=N'" + NgLap + "'  Where MaHD='" + MaDH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


        //tìm kiếm
        public DataSet TimkiemTheoMaDH(string tk)
        {
            string sql = "select *from HOADON where MaHD like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public DataSet TimkiemTheoMaKH(string tk)
        {
            string sql = "select *from HOADON where MaKH like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public DataSet TimkiemTheoMaNV(string tk)
        {
            string sql = "select *from HOADON where MaNV like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        //ktra
        

    }
}
