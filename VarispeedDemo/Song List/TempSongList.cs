using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace VarispeedDemo.Song_List
{
    public class TempSongList
    {
        SqlConnection conn;
        public void SongSet(string name, string time)
        {
            string connectionString1 = ConfigurationManager.ConnectionStrings["VarispeedDemo.Properties.Settings.PlaylistDBConnectionString"].ConnectionString;
            string queryn = "INSERT INTO SimpleSongDatabase VALUES (@songName, @songLength)";
            using (conn = new SqlConnection(connectionString1))
            using (SqlCommand commn = new SqlCommand(queryn, conn))
            {
                conn.Open();
                commn.Parameters.AddWithValue("@songName", name);
                commn.Parameters.AddWithValue("@songLength", time);
                commn.ExecuteScalar();
            }
        }
        public void SongUnset()
        {
            string connectionString1 = ConfigurationManager.ConnectionStrings["VarispeedDemo.Properties.Settings.PlaylistDBConnectionString"].ConnectionString;
            string queryn = "DELETE FROM SimpleSongDatabase";
            using (conn = new SqlConnection(connectionString1))
            using (SqlCommand commn = new SqlCommand(queryn, conn))
            {
                conn.Open();
                commn.ExecuteNonQuery();
            }
        }
        
    }
}
