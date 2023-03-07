using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarispeedDemo.Song_List;

namespace VarispeedDemo
{
    public partial class SongPlaylistUI : Form
    {
        public SongPlaylistUI()
        {
            InitializeComponent();
            textBox1.Text = TempSongList.path;
            LoadSongS();
        }
        private void spUI_load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var file = new OpenFileDialog();
            file.Filter = "JSON Files|*.json";
            if (file.ShowDialog() == DialogResult.OK)
            {
                string getJSONDirectory = Path.GetFullPath(file.FileName);
                if (MessageBox.Show("Are you sure you want to delete everything from this list, this action cannot be undone!!!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    
                    TempSongList.path = getJSONDirectory;
                    textBox1.Text = getJSONDirectory;
                    TempSongList.cabiste.Clear();
                    songList.Items.Clear();
                    timeTable.Items.Clear();
                    var songData = TempSongList.GetSong();
                    for (int i = 0; i < songData.Count; i++)
                    {
                        TempSongList.cabiste.Add(new DisplayModel { Name = songData[i].Name, Time = songData[i].Time });
                    }
                    LoadSongS();
                    MessageBox.Show("Songs loaded, hit Refresh Songs to show them on your drop down list", "Yay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { return; }
            }
        }
        private void LoadSongS()
        {
            ContextMenuStrip menu = new();
            menu.Items.Add("Delete",null, new EventHandler(Removesong_click));
            for (int i = 0; i < TempSongList.cabiste.Count; i++)
            {
                songList.Items.Add(TempSongList.cabiste[i].Name);
                timeTable.Items.Add(TempSongList.cabiste[i].Time);
            }
            songList.ContextMenuStrip = menu;
        }

        private void Removesong_click(object sender, EventArgs e)
        {
            try
            {
                var songToDelete = songList.SelectedItem.ToString();
                timeTable.Items.Remove(songList.SelectedIndex);
                TempSongList.SongUnset(songToDelete);
                songList.Items.Remove(songToDelete);
            } catch (NullReferenceException)
            {
                MessageBox.Show("Please select a song to delete", "Lmao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete everything from this list, this action cannot be undone!!!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                TempSongList.SongReset();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var file = new SaveFileDialog();
            file.Filter = "JSON Files|*.json";
            if (file.ShowDialog() == DialogResult.OK)
            {
                string getJSONDirectory = Path.GetFullPath(file.FileName);
                textBox1.Text = getJSONDirectory;
                TempSongList.path = getJSONDirectory;
                TempSongList.SongSet();
            }
        }
    }
}
