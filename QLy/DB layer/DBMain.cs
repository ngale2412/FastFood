using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;
namespace QLy.DB_layer
{
    class DBMain
    {
        string ConnStr = "Data Source=DESKTOP-SLNDDHO;Initial Catalog=QuanLyFastFood;Integrated Security=True";
        //SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public static SqlConnection conn = new SqlConnection();
        public static SqlCommand sqlcmd;
        public static String connstr;

        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "QuanLyFastFood";
        public static String remotelogin = "Support";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChinhanh = 0; // xác định chi nhánh
        public static String tenChiNhanh = "";
        public static String maCN = "";
        public static BindingSource bds_dspm = new BindingSource();
        // public static FormMain frmChinh;

        public static int checkDangNhap = 0;
        public static int KetNoi()
        {
            if (DBMain.conn != null && DBMain.conn.State == ConnectionState.Open)
                DBMain.conn.Close();
            try
            {
                DBMain.connstr = "Data Source=" + DBMain.servername + ";Initial Catalog=" +
                      DBMain.database + ";User ID=" +
                      DBMain.mlogin + ";password=" + DBMain.password;
                DBMain.conn.ConnectionString = DBMain.connstr;
                DBMain.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, DBMain.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (DBMain.conn.State == ConnectionState.Closed) DBMain.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                DBMain.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd, string connstr)
        {
            DataTable dt = new DataTable();
            if (DBMain.conn.State == ConnectionState.Closed) DBMain.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }
    }
    //    string ConnStr = "Data Source=DESKTOP-SLNDDHO;Initial Catalog=QuanLyFastFood;Integrated Security=True";
    //    SqlConnection conn = null;
    //    SqlCommand comm = null;
    //    SqlDataAdapter da = null;
    //    public DBMain()
    //    {
    //        conn = new SqlConnection(ConnStr);
    //        comm = conn.CreateCommand();
    //    }
    //    public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] p)
    //    {
    //        if (conn.State == ConnectionState.Open)
    //            conn.Close();
    //        conn.Open();
    //        comm.CommandText = strSQL;
    //        comm.CommandType = ct;
    //        da = new SqlDataAdapter(comm);
    //        DataSet ds = new DataSet();
    //        da.Fill(ds);
    //        return ds;
    //    }
    //    public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
    //    {
    //        bool f = false;
    //        if (conn.State == ConnectionState.Open)
    //            conn.Close();
    //        conn.Open();
    //        comm.CommandText = strSQL;
    //        comm.CommandType = ct;
    //        foreach (SqlParameter p in param)
    //            comm.Parameters.Add(p);
    //        try
    //        {
    //            comm.ExecuteNonQuery();
    //            f = true;
    //        }
    //        catch (SqlException ex)
    //        {
    //            error = ex.Message;
    //        }
    //        finally
    //        {
    //            conn.Close();
    //        }
    //        return f;
    //    }


    //    public bool ExecuteReader(string strSQL, CommandType ct, ref string error)
    //    {
    //        bool f = false;
    //        //mở ket noi
    //        if (conn.State == ConnectionState.Open)
    //            conn.Close();
    //        conn.Open();

    //        comm.CommandText = strSQL;
    //        comm.CommandType = ct;

    //        SqlCommand cmd = new SqlCommand(strSQL, conn);
    //        SqlDataReader dtaR = cmd.ExecuteReader();
    //        if (dtaR.Read() == true)
    //        {
    //            f = true;
    //        }
    //        else
    //        {
    //            f = false;
    //        }

    //        //đóng ket noi
    //        conn.Close();
    //        return f;
    //    }

    //    /*
    //    //ảnh
    //    public void StorePicture(string filename)
    //    {
    //        byte[] imageData = null;
    //        // Read the file into a byte array
    //        using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
    //        {
    //            imageData = new Byte[fs.Length];
    //            fs.Read(imageData, 0, (int)fs.Length);
    //        }
    //        using (SqlConnection conn = new SqlConnection(ConnStr))
    //        {
    //            string ma;
    //            SqlCommand cmd = new SqlCommand("insert image",conn);
    //            cmd.CommandType = CommandType.StoredProcedure;
    //            // Store the byte array within the image field
    //            cmd.Parameters["@Image"].Value = imageData;
    //            conn.Open();
    //            cmd.ExecuteNonQuery();
    //        }
    //    }

    //    public byte[] RetrieveImage()
    //    {
    //        byte[] imageData = null;
    //        conn.Open();
    //        SqlCommand cmd = new SqlCommand("select Image from SANPHAM", conn);
    //        // Assume previously established command and connection
    //        // The command SELECTs the IMAGE column from the table

    //        using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess))
    //        {
    //            reader.Read();
    //            // Get size of image data – pass null as the byte array parameter
    //            long bytesize = reader.GetBytes(0, 0, null, 0, 0);
    //            // Allocate byte array to hold image data
    //            imageData = new byte[bytesize];
    //            long bytesread = 0;
    //            int curpos = 0;
    //            int chunkSize = 1;
    //            while (bytesread < bytesize)
    //            {
    //                // chunkSize is an arbitrary application defined value
    //                bytesread += reader.GetBytes(0, curpos, imageData, curpos, chunkSize);
    //                curpos += chunkSize;
    //            }
    //        }
    //        conn.Close();
    //        // byte array ‘imageData’ now contains BLOB from database
    //        return imageData;
    //    }
    //    */
    //}
}
