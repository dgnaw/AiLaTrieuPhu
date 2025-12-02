using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace AiLaTrieuPhu
{
    class C_KetNoi
    {
        private static OleDbConnection con;

        public static void ketNoi()
        {
            string chuoiKetNoi = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Data\CauHoiAiLaTrieuPhu.accdb";
            con = new OleDbConnection(chuoiKetNoi);
            con.Open();

        }

        public static void dongKetNoi()
        {
            string chuoiKetNoi = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Data\CauHoiAiLaTrieuPhu.accdb";
            con = new OleDbConnection(chuoiKetNoi);
            //đóng kết nối
            con.Close();
            //giải phóng bộ nhớ
            con.Dispose();
            con = null;
        }

        /// <summary>
        /// lấy dữ liệu từ một ô
        /// </summary>
        /// <param name="sql">câu lệnh truy vấn</param>
        /// <param name="cot">tên cột cần lấy dữ liệu</param>
        /// <param name="i">vị trí dòng cần lấy dữ liệu</param>
        /// <returns>trả về dữ liệu kiểu string</returns>
        public static string layDuLieu(string sql, string cot, int i)
        {
            //tạo câu lệnh truy vấn
            OleDbCommand cm = new OleDbCommand(sql, con);

            //lưu dữ liệu sau khi truy vấn vào data
            OleDbDataAdapter data = new OleDbDataAdapter(cm);
            
            DataTable tbl = new DataTable();
            //đổ dữ liệu từ data vào bảng tbl
            data.Fill(tbl);

            //trả về dữ liệu tại dòng thứ i trong cột cot
            return tbl.Rows[i][cot].ToString();

        }


    }
}
