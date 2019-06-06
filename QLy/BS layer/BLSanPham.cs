using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLy.DB_layer;


namespace QLy.BS_layer
{
    class BLSanPham
    {
        public static string masp = "MaSP";
        public static string ten = "TenSP";
        public static string gia = "Gia";

        DBMain db = null;
        public BLSanPham()
        {
            db = new DBMain();

        }
        public DataSet LaySanPham()
        {
            return db.ExecuteQueryDataSet("select * from SANPHAM", CommandType.Text);
        }
        public bool ThemSanPham(string MaSp, string Tensp, float SoLuong, float gia,string LoaiSP, ref string err)
        {
            string sqlString = "Insert Into SANPHAM Values(" + "'" + MaSp + "',N'" + Tensp + "',N'" + gia + "',N'" + SoLuong + "',N'" + LoaiSP + "')";
           
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
            
        }
        public bool XoaSanPham(ref string err, string MaSP)
        {
            string sqlString = "Delete From SANPHAM Where MaSP='" + MaSP + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatSanPham(string MaSp, string Tensp, float gia,float SoLuong,string LoaiSP,  ref string err)
        {
            string sqlString = "Update SANPHAM Set TenSP=N'" + Tensp + "' ,GiaBan=N'" + gia + "',SoLuong=N'" + SoLuong + "',MaLoai=N'" + LoaiSP + "' Where MaSP='" + MaSp + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet TimkiemTheoMA(string tk)
        {
            string sql = "select *from SANPHAM where MaSP like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet TimkiemTheoTENSP(string tk)
        {
            string sql = "select *from SANPHAM where TenSP like N'%" + tk + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet TimkiemTheoGia(float tk)
        {
            string sql = "select *from SANPHAM where GiaBan='" + tk + "'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        //ktra
        public DataSet ktra(string ma)
        {
            string sqlString = "select * from SANPHAM where MaSP=N'" + ma + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
