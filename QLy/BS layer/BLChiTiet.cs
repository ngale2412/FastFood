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
            return db.ExecuteQueryDataSet("select * from CT_HOADON", CommandType.Text);
        }
        public bool ThemChitiet(string MaDH, string MaSp,  int sl, float gia,float tien, ref string err)
        {
            string sqlString = "Insert Into CT_HOADON Values(" + "'" + MaDH + "',N'" + MaSp + "',N'" + sl + "',N'" + gia + "',N'" + tien + "')";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        public bool XoaChiTiet(ref string err, string MaSP)
        {
            string sqlString = "Delete From CT_HOADON Where MaSP='" + MaSP + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatChitiet(string MaDH, string MaSp,  int sl, float gia, float tien, ref string err)
        {
            string sqlString = "Update CT_HOADON Set MaSP=N'" + MaSp + "' ,SoLuong=N'" + sl + "' ,Gia=N'" + gia + "' ,ThanhTien=N'" + tien + "' Where MaDH='" + MaDH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


        //tìm kiếm
        public DataSet TimkiemTheoMaDH(string tk)
        {
            string sql = "select *from CT_HOADON where MaHD like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        //public DataSet TimkiemTheoMaKH(string tk)
        //{
        //    string sql = "select *from CT_HOADON where MaKH like N'%" + tk + "%'";
        //    return db.ExecuteQueryDataSet(sql, CommandType.Text);
        //}

        public DataSet TimkiemTheoMaSP(string tk)
        {
            string sql = "select *from CT_HOADON where MaSP like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // đổ vào combobox
        public DataSet ktra(string ma)
        {
            string sqlString = "select * from HOADON where MaHD=N'" + ma + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        
        //
        
        public DataSet lay2cot()
        {
            string sql = "select MaHD,MaSP,sum(ThanhTien) as TONG from CT_HOADON  group by MaSP,MaHD";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        

    }
}
