using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;

namespace QLSV
{
    class KNCSDL
    {
        SqlConnection sqlketnoi;
        SqlCommand sqllenh;
        public KNCSDL()
        {
            sqlketnoi = new SqlConnection();
            string chuoiketnoi = "Data Source=LAPTOP-TUAN\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
            sqlketnoi.ConnectionString = chuoiketnoi;
            sqllenh = new SqlCommand();
        }
        public bool Moketnoi()
        {
            try
            {
                sqlketnoi.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Dongketnoi()
        {
            sqlketnoi.Close();
        }
        public bool CapnhatCSDL(string str)
        {
            try
            {
                sqllenh.Connection = sqlketnoi;
                sqllenh.CommandText = str;
                sqllenh.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable LayBang(string str)
        {
            SqlDataAdapter bodocghi = new SqlDataAdapter(str, sqlketnoi);
            DataTable bang = new DataTable();
            bodocghi.Fill(bang);
            return bang;
        }

    }
}
