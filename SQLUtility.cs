using System.Data;
using System.Data.SqlClient;

namespace CPUFramework
{
    public class SQLUtility
    {
        public static string ConnectionString = "";
        public static DataTable GetDataTable(string sqlstatement)
        {
            DataTable dt = new();
            SqlConnection conn = new();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            //DisplayMessage("Connection Status", conn.State.ToString());
            var cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sqlstatement;
            var dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
    }
}
