using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Backup_Thanh
{
    static class Program
    {

        public static SqlDataAdapter da;
        public static SqlConnection conn = new SqlConnection();
        public static SqlDataReader myreader;
        public static String serverName = "";
        public static String username = "";
        public static String passWord = "";
        public static String database = "tempdb";
        public static String mlogin = "";
        public static string connstr = "";
        public static String Db;
        public static String defaultDeviceFilePath = "D:/Project MonHoc/Backup/Backup_Restore/";
        public static String device_type = "Disk";
        public static int KetNoi() //null thì lỗi, không null thì chạy
        {
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.serverName + ";User ID=" + Program.username + ";password=" + Program.passWord;
                //Program.conn.ConnectionString = connstr;
                Program.conn = new SqlConnection(Program.connstr);
                Program.conn.Open();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. \nBạn xem lại username và password.\n" + ex.Message, "Lỗi kết nối!", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static int ExecSqlNonQuery(String str, String connectionString, string errstr)
        {
            conn = new SqlConnection(connectionString);
            SqlCommand sqlcmd = new SqlCommand(str, conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                int loi = sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException EX)
            {
                if (EX.Message.Contains("Lỗi chuyển dữ liệu từ varchar sang int"))
                    MessageBox.Show("");
                else
                    MessageBox.Show(errstr + EX.Message);
                conn.Close();
                return 1;

            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader reader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300; // Đợi lệnh chạy. đơn vị: giây.

            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                reader = sqlcmd.ExecuteReader();
                return reader;
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
