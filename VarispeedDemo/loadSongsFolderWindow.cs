using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NAudio.Wave;

namespace VarispeedDemo
{
    public partial class loadSongsFolderWindow : Form
    {
        private AudioFileReader reader2;
        FolderBrowserDialog fBD = new FolderBrowserDialog();
        public Song_List.TempSongList songList1 = new Song_List.TempSongList();
        public string[] songArray;
        public string path;
        public loadSongsFolderWindow()
        {
            InitializeComponent();
            label1.Hide();
        }
        private void dot3btn_Click(object sender, EventArgs e)
        {
            if (fBD.ShowDialog() == DialogResult.OK) { path = fBD.SelectedPath; }
            else { path = null; }
            textBox1.Text = path;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mp3filechecker_Click(object sender, EventArgs e)
        {
            songsList.Items.Clear();            
            try {
                label1.Show();
                songArray = Directory.GetFiles(path, "*.mp3", SearchOption.AllDirectories);
                foreach (string files in songArray)
                {
                    songsList.Items.Add(files);
                    reader2 = new AudioFileReader(files);
                    songList1.SongSet(files, (TimeSpan.FromSeconds((int)(reader2.TotalTime.TotalSeconds + 0.5)).ToString("mm\\:ss")));
                }
                label1.Text = songsList.Items.Count.ToString() + " Songs Added";
            }
            catch (ArgumentNullException u) { MessageBox.Show(Convert.ToString(u), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (UnauthorizedAccessException t) { MessageBox.Show(Convert.ToString(t), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            
        }
    }
}
