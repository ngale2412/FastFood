using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
namespace QLy.DB_layer
{
    class DBMain
    {
        string ConnStr = "Data Source=(local);Initial Catalog=QuanlyTiemBanh;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DBMain()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
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
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }


        public bool ExecuteReader(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            //mở ket noi
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();

            comm.CommandText = strSQL;
            comm.CommandType = ct;

            SqlCommand cmd = new SqlCommand(strSQL, conn);
            SqlDataReader dtaR = cmd.ExecuteReader();
            if (dtaR.Read() == true)
            {
                f = true;
            }
            else
            {
                f = false;
            }

            //đóng ket noi
            conn.Close();
            return f;
        }

        /*
        //ảnh
        public void StorePicture(string filename)
        {
            byte[] imageData = null;
            // Read the file into a byte array
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                imageData = new Byte[fs.Length];
                fs.Read(imageData, 0, (int)fs.Length);
            }
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                string ma;
                SqlCommand cmd = new SqlCommand("insert image",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                // Store the byte array within the image field
                cmd.Parameters["@Image"].Value = imageData;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public byte[] RetrieveImage()
        {
            byte[] imageData = null;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Image from SANPHAM", conn);
            // Assume previously established command and connection
            // The command SELECTs the IMAGE column from the table

            using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess))
            {
                reader.Read();
                // Get size of image data – pass null as the byte array parameter
                long bytesize = reader.GetBytes(0, 0, null, 0, 0);
                // Allocate byte array to hold image data
                imageData = new byte[bytesize];
                long bytesread = 0;
                int curpos = 0;
                int chunkSize = 1;
                while (bytesread < bytesize)
                {
                    // chunkSize is an arbitrary application defined value
                    bytesread += reader.GetBytes(0, curpos, imageData, curpos, chunkSize);
                    curpos += chunkSize;
                }
            }
            conn.Close();
            // byte array ‘imageData’ now contains BLOB from database
            return imageData;
        }
        */
    }
}
