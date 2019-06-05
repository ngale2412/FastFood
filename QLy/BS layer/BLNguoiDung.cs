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
        
        public DataSet layCaNhan(string ngdung, string mk, ref string err)
        {
            string sqlString = "select * from NGUOIDUNG where Username='" + ngdung + "'and Password='" + mk + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }



        public bool ThemNguoiDung(string Username, string Password, ref string err)
        {
            string sqlString = "Insert Into NGUOIDUNG Values(" + "'" + Username + "',N'" + Password + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        //xxx bỏ
        public bool XoaNguoiDung(ref string err, string Username)
        {
            string sqlString = "Delete From NGUOIDUNG Where Username='" + Username + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatNguoiDung(string Username, string Password, ref string err)
        {
            string sqlString = "Update NGUOIDUNG Set Password=N'" + Password + "' Where Username=N'" + Username + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        // 
        public bool KtraNguoiDung(string Username, string Password, ref string err)
        {
            string sqlString = "select * from NGUOIDUNG where Username=N'" + Username + "'and Password='" + Password + "'";
            return db.ExecuteReader(sqlString, CommandType.Text, ref err);
        }
    }
}
