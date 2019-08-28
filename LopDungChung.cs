using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLiNhaHang
{
    class LopDungChung
    {
        string chuoiketnoi = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Admin\Desktop\QuanLiNhaHang\QuanLiNhaHang\Database1.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(chuoiketnoi);
        }
        public void Mo()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
        }
        public void Dong()
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();
        }
        public int ThemSuaXoa(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            Mo();
            int ketqua = comm.ExecuteNonQuery();
            Dong();
            return ketqua;
        }
        public DataTable LayDuLieuBang(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
