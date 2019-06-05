using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using QLy.DB_layer;

namespace QLy.BS_layer
{
    class BLChiTiet
    {
        public static string money = "TONG";

        DBMain db = null;
        public BLChiTiet()
        {
            db = new DBMain();

        }
        public DataSet LayChiTietDH()
        {
            return db.ExecuteQueryDataSet("select * from CHITIET", CommandType.Text);
        }
        public bool ThemChitiet(string MaDH, string MaSp, string MaKh, int sl, float gia,float tien, ref string err)
        {
            string sqlString = "Insert Into CHITIET Values(" + "'" + MaDH + "',N'" + MaSp + "',N'" + MaKh + "',N'" + sl + "',N'" + gia + "',N'" + tien + "')";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        public bool XoaChiTiet(ref string err, string MaSP)
        {
            string sqlString = "Delete From CHITIET Where MaSP='" + MaSP + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatChitiet(string MaDH, string MaSp, string MaKh, int sl, float gia, float tien, ref string err)
        {
            string sqlString = "Update CHITIET Set MaSP=N'" + MaSp + "' ,MaKH=N'" + MaKh + "' ,SoLuong=N'" + sl + "' ,Gia=N'" + gia + "' ,ThanhTien=N'" + tien + "' Where MaDH='" + MaDH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


        //tìm kiếm
        public DataSet TimkiemTheoMaDH(string tk)
        {
            string sql = "select *from CHITIET where MaDH like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public DataSet TimkiemTheoMaKH(string tk)
        {
            string sql = "select *from CHITIET where MaKH like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public DataSet TimkiemTheoMaSP(string tk)
        {
            string sql = "select *from CHITIET where MaSP like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // đổ vào combobox
        public DataSet ktra(string ma)
        {
            string sqlString = "select * from DONHANG where MaDH=N'" + ma + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        
        //
        
        public DataSet lay2cot()
        {
            string sql = "select MaDH,MaKH,sum(ThanhTien) as TONG from CHITIET  group by MaKH,MaDH";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        

    }
}
