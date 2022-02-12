using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VarispeedDemo
{
    public partial class SongPlaylistUI : Form
    {
        SqlConnection conn;
        string connectionString;
        public SongPlaylistUI()
        {
            InitializeComponent();
        }
        private void spUI_load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["VarispeedDemo.Properties.Settings.PlaylistDBConnectionString"].ConnectionString;
            DBLoader(connectionString);
        }
        private void DBLoader(string connectionString1)
        {
            using (conn = new SqlConnection(connectionString1))
            using (SqlDataAdapter adapt = new SqlDataAdapter("SELECT DISTINCT * FROM SimpleSongDatabase", conn))
            {
                DataTable reciptab = new DataTable();
                adapt.Fill(reciptab);

                // song names
                songList.DataSource = reciptab;
                songList.DisplayMember = "SongName";
                songList.ValueMember = "SongID";

                // times
                timeTable.DataSource = reciptab;
                timeTable.DisplayMember = "SongLength";
                timeTable.ValueMember = "SongID";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // wip
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["VarispeedDemo.Properties.Settings.PlaylistDBConnectionString"].ConnectionString;
            DBLoader(connectionString);
        }
    }
}
