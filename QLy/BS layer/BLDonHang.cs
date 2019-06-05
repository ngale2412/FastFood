using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using QLy.DB_layer;

namespace QLy.BS_layer
{
    class BLDonHang
    {
        public static string madh = "MaDH";

        DBMain db = null;
        public BLDonHang()
        {
            db = new DBMain();

        }
        public DataSet LayDonHang()
        {
            return db.ExecuteQueryDataSet("select * from DONHANG", CommandType.Text);
        }
        public bool ThemDonHang(string MaDH, string MaKH, string MaNV, string NgLap, float tong, ref string err)
        {
            string sqlString = "Insert Into DONHANG Values(" + "'" + MaDH + "',N'" + MaKH + "',N'" + MaNV + "',N'" + NgLap + "',N'" + tong + "')";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        public bool XoaDonHang(ref string err, string MaDH)
        {
            string sqlString = "Delete From DONHANG Where MaDH='" + MaDH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatDonHang(string MaDH, string MaKH, string MaNV, string NgLap, float tong, ref string err)
        {
            string sqlString = "Update DONHANG Set MaKH=N'" + MaKH + "' ,MaNV=N'" + MaNV + "' ,NgayLap=N'" + NgLap + "' ,TongTien=N'" + tong + "' Where MaDH='" + MaDH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


        //tìm kiếm
        public DataSet TimkiemTheoMaDH(string tk)
        {
            string sql = "select *from DONHANG where MaDH like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public DataSet TimkiemTheoMaKH(string tk)
        {
            string sql = "select *from DONHANG where MaKH like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public DataSet TimkiemTheoMaNV(string tk)
        {
            string sql = "select *from DONHANG where MaNV like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        //ktra
        

    }
}
