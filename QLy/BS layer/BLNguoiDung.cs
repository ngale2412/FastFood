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
    class BLNguoiDung
    {
        
        DBMain db = null;
        public BLNguoiDung()
        {
            db = new DBMain();
        }
        
        public DataTable LoadDanhSachChiNhanh()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM V_DS_PhanManh", CommandType.Text).Tables[0];
        }
        //public DataSet layACCOUNT(string ngdung, string mk, ref string err)
        //{
        //    string sqlString = "select * from ACCOUNT where TenDN='" + ngdung + "'and MatKhau='" + mk + "'";
        //    return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        //}



        //public bool ThemNguoiDung(string Username, string Password, ref string err)
        //{
        //    string sqlString = "Insert Into ACCOUNT Values(" + "'" + Username + "',N'" + Password + "')";
        //    return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        //}

        ////xxx bỏ
        //public bool XoaNguoiDung(ref string err, string Username)
        //{
        //    string sqlString = "Delete From ACCOUNT Where TenDN='" + Username + "'";
        //    return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        //}

        //public bool CapNhatNguoiDung(string Username, string Password, ref string err)
        //{
        //    string sqlString = "Update ACCOUNT Set MatKhau=N'" + Password + "' Where TenDN=N'" + Username + "'";
        //    return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        //}

        //// 
        //public bool KtraNguoiDung(string Username, string Password, ref string err)
        //{
        //    string sqlString = "select * from ACCOUNT where TenDN=N'" + Username + "'and MatKhau='" + Password + "'";
        //    return db.ExecuteReader(sqlString, CommandType.Text, ref err);
        //}
    }

}
