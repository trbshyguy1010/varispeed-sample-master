using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VarispeedDemo
{
    public partial class SongPlaylistUI : Form
    {
        loadSongsFolderWindow lsfz = new loadSongsFolderWindow();
        string[] songArr1 { get; }
        public SongPlaylistUI()
        {
            InitializeComponent();
            songArr1 = lsfz.songArray;
            try
            {
                foreach (var t in songArr1)
                {
                    songList.Items.Add(t);
                }
            }
            catch (NullReferenceException h) { MessageBox.Show(h.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }            
        }
        public void songListGetter(string[] d)
        {
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
