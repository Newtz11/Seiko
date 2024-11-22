using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        //private string connectString = @"Data Source=MING\SQLEXPRESS;Initial Catalog=QuanLiHopDong;Integrated Security=True";
        //private string connectString = @"Data Source=LAPTOP-OHHI582R;Initial Catalog=QuanLiHopDong;Integrated Security=True";
        private string connectString = @"Data Source=35.197.135.105;Initial Catalog=QuanLiHopDong;Persist Security Info=True;User ID=sqlserver;Password=DGBlx1211";

        private static DataProvider instance;

        public static DataProvider Instance
        { get { if (instance == null) instance = new DataProvider(); return instance; }
            private set => instance = value; }

        private DataProvider() { }

        public DataTable executeQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }


        public int executeNoneQuery(string query)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                rowsAffected = command.ExecuteNonQuery();
                conn.Close();
            }
            return rowsAffected;
        }

        

    }
}
