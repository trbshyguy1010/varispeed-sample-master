using DiscordRpcDemo;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VarispeedDemo.e;
using VarispeedDemo.SoundTouch;

namespace VarispeedDemo
{
    //to add : BPM Detector, visualiser, Discord Rich Presence   
    public partial class MainForm : Form
    {
        Song_List.TempSongList tempSong = new Song_List.TempSongList();
        static Data.datasdfg verylongname = new Data.datasdfg();
        public DeviceChange change = new DeviceChange();
        public int[] waveOutID;
        public string[] songNames;
        string ID = verylongname.DiscordID;
        param param = new param();
        int time = 0;
        sbyte pBr = 2;
        sbyte pBy = 3;
        sbyte pBg = 1;
        private IWavePlayer wavePlayer;
        private VarispeedSampleProvider speedControl;
        private AudioFileReader reader;
        public string songpath;
        private MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
        public DRPC dRPC = new DRPC();
        public MainForm()
        {
            InitializeComponent();
            getDevices();
            dRPC.downText = "";
            dRPC.upText = "Idle";
            dRPC.DRPCEnable();
            timer1.Interval = 500;
            timer1.Start();
            timer3.Start();
            timer4.Start();
            Closing += OnMainFormClosing;
            MMDeviceCollection devices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            comboBoxModes.Items.Add("Speed");
            comboBoxModes.Items.Add("Tempo");
            comboBoxModes.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0; // By Default it selects the first item in the list, this is intentional and will not change
            change.DeviceSet(comboBox2.SelectedIndex);
            EnableControls(false);
        }
        private void getDevices()
        {
            for (int n = 0; n < WaveOut.DeviceCount; n++)
            {
                var caps = WaveOut.GetCapabilities(n);
                comboBox2.Items.Add(caps.ProductName);
                List<int> list = new List<int>();
                waveOutID = list.ToArray();
            }
        }
        private void getDevice()
        {
            if (comboBox2.SelectedItem != null)
            {
                MMDevice devices2 = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
                var volume = devices2.AudioMeterInformation.MasterPeakValue;
                var scale = (int)Math.Floor(volume * 100);
                progressBar1Master.Value = scale;
                label9.Text = scale.ToString();
                if (progressBar1Master.Value > 50 && progressBar1Master.Value < 90) { ModifyProgressBarColor.SetState(progressBar1Master, pBy); }
                else if (progressBar1Master.Value > 90) { ModifyProgressBarColor.SetState(progressBar1Master, pBr); }
                else { ModifyProgressBarColor.SetState(progressBar1Master, pBg); }
            }
        }
        private void OnMainFormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var chromeDriverProcesses = Process.GetProcesses().
    Where(pr => pr.ProcessName == "CSAudioVisualizationExample"); // without '.exe'

            foreach (var process in chromeDriverProcesses)
            {
                process.Kill();
            }
            PluginDisposal();
            tempSong.SongUnset();
        }
        public void PluginDisposal()
        {
            change.wasabi?.Dispose();
            speedControl?.Dispose();
            dRPC?.DRPCEnable();
        }

        private void WavePlayerOnPlaybackStopped(object sender, StoppedEventArgs stoppedEventArgs)
        {
            if (stoppedEventArgs.Exception != null)
            {
                MessageBox.Show(stoppedEventArgs.Exception.Message, "Playback Stopped Unexpectedly");
            }
            EnableControls(false);
        }

        private void EnableControls(bool isPlaying)
        {
            buttonPlay.Enabled = !isPlaying;
            buttonLoad.Enabled = !isPlaying;
            loadToolStripMenuItem.Enabled = !isPlaying;
            loadFromFolderToolStripMenuItem.Enabled = !isPlaying;
            buttonStop.Enabled = isPlaying;
            comboBoxModes.Enabled = !isPlaying;
            comboBox2.Enabled = !isPlaying;
            progressBar1Master.Enabled = isPlaying;
        }

        private string SelectFile()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "MP3 Files|*.mp3";
            return ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : null;
        }

        private void OnButtonStopClick(object sender, EventArgs e)
        {
            EnableControls(false);
            change.wasabi?.Stop();
            timer4.Interval = 999999999;
            dRPC.upText = "Idle";
            dRPC.downText = "";
            dRPC.DRPCEnable();
        }

        private void speedchange()
        {
            speedControl.PlaybackRate = 0.5f + trackBarPlaybackRate.Value * 0.1f;
            labelPlaybackSpeed.Text = $"x{speedControl.PlaybackRate:F1}";
            applyspeed.Enabled = false;
        }
        private void OnTrackBarPlaybackRateScroll(object sender, EventArgs e)
        {
            applyspeed.Enabled = true;
        }

        private void OnButtonLoadClick(object sender, EventArgs e)
        {
            LoadFile();
        }
        private void WaveLoader()
        {
            var wf = new Waveform();
            wf.SetWave(songpath);
            pictureBox1.Image = wf.image;
        }
        private void LoadFile()
        {
            reader?.Dispose();
            speedControl?.Dispose();
            change.wasabi?.Dispose();
            reader = null;
            speedControl = null;
            trackBarPlaybackRate.Enabled = true;
            volumeBar1.Enabled = true;
            var file = SelectFile();
            songpath = file;
            if (file == null) return;
            comboBox1.Items.Add(file);
            // songNames
            WaveLoader();
        }
        private void LoadSong()
        {
            label3.Text = "Now Playing : " + songpath;
            if (songpath == null) { LoadFile(); }
            if (songpath == null) { return; }
            reader = new AudioFileReader(songpath);
            DisplayPosition();
            tempSong.SongSet(songpath, (TimeSpan.FromSeconds((int)(reader.TotalTime.TotalSeconds + 0.5)).ToString("mm\\:ss")));
            volumeBar1.Value = 100;
            label4.Text = volumeBar1.Value + "%";
            var useTempo = comboBoxModes.SelectedIndex == 1;
            speedControl = new VarispeedSampleProvider(reader, 100, new SoundTouchProfile(useTempo, false));
            change.DeviceSet(comboBox2.SelectedIndex);
            speedchange();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (reader != null)
            {
                trackBarPlaybackPosition.Value = (int)reader.CurrentTime.TotalSeconds;
                DisplayPosition();
            }
        }

        private void DisplayPosition()
        {
            labelPosition.Text = reader.CurrentTime.ToString("mm\\:ss");
        }

        private void trackBarPlaybackPosition_Scroll(object sender, EventArgs e)
        {
            if (reader != null)
            {
                reader.CurrentTime = TimeSpan.FromSeconds(trackBarPlaybackPosition.Value);
                speedControl.Reposition();
            }
        }

        private void comboBoxModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (speedControl != null)
            {
                var useTempo = comboBoxModes.SelectedIndex == 1;
                speedControl.SetSoundTouchProfile(new SoundTouchProfile(useTempo, false));
            }
        }

        private void applyspeed_Click(object sender, EventArgs e)
        {
            speedchange();
            label10.Text = "Song Duration : " + TimeSpan.FromSeconds((int)(reader.TotalTime.TotalSeconds + 0.5)).ToString("mm\\:ss") + "-> " + TimeSpan.FromSeconds((int)(reader.TotalTime.TotalSeconds + 0.5) / speedControl.PlaybackRate).ToString("mm\\:ss");
        }

        private void volumeBar1_Scroll(object sender, EventArgs e)
        {
            if (wavePlayer != null && volumeBar1 != null)
            {
                wavePlayer.Volume = (volumeBar1.Value / 10) * 0.1f;
                label4.Text = $"{(wavePlayer.Volume) * 100}%";
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            getDevice();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                songpath = comboBox1.SelectedItem.ToString();
                if (change.wasabi != null)
                {
                    change.wasabi.Stop();
                }
                LoadSong();
                WaveLoader();
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PluginDisposal();
            this.Close();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            time++;
            string uptime = DateTime.Now.ToString("HH:mm:ss");
            uplabel9.Text = "Time : " + uptime;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (wavePlayer != null)
            {
                dRPC.upText = "Playing a song at " + labelPlaybackSpeed.Text;
                dRPC.downText = labelPosition.Text + " Elapsed | Songs : " + (comboBox1.SelectedIndex + 1).ToString() + "/" + comboBox1.Items.Count.ToString();
                dRPC.DRPCEnable();
            }
            else
            {
                dRPC.upText = "Idle";
                dRPC.downText = "";
                dRPC.DRPCEnable();
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (change.wasabi == null)
            {
                change.wasabi.PlaybackStopped += WavePlayerOnPlaybackStopped;
            }
            if (wavePlayer == null)
            {
                wavePlayer = new WaveOutEvent();
                wavePlayer.PlaybackStopped += WavePlayerOnPlaybackStopped;
            }
            if (speedControl == null)
            {
                LoadSong();
                if (speedControl == null) return;
            }
            change.DeviceSet(comboBox2.SelectedIndex);
            wavePlayer.Init(speedControl);
            change.wasabi.Init(speedControl);
            timer2.Start();
            label3.Text = "Now Playing : " + songpath;
            trackBarPlaybackPosition.Value = 0;
            trackBarPlaybackPosition.Maximum = (int)(reader.TotalTime.TotalSeconds + 0.5);
            label10.Text = "Song Duration : " + TimeSpan.FromSeconds((int)(reader.TotalTime.TotalSeconds + 0.5)).ToString("mm\\:ss");
            change.wasabi.Play();
            change.wasabi.Volume = (volumeBar1.Value / 10) * 0.1f;
            timer4.Interval = 1;
            EnableControls(true);
        }

        private void rebut_Click(object sender, EventArgs e)
        {
            speedControl.PlaybackRate = 1.0f;
            trackBarPlaybackRate.Value = (int)(speedControl.PlaybackRate + 4);
            labelPlaybackSpeed.Text = $"x{speedControl.PlaybackRate:F1}";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            change.DeviceSet(comboBox2.SelectedIndex);
        }

        private void loadFromFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadSongsFolderWindow lsfw = new loadSongsFolderWindow();
            lsfw.ShowDialog();
            /*
            try { comboBox1.Items.AddRange(lsfw.songArray); }
            catch (ArgumentNullException) { MessageBox.Show("No songs specified", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }*/
            trackBarPlaybackRate.Enabled = true;
            volumeBar1.Enabled = true;
        }

        private void pluginManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"VisualizerCSCore\CSAudioVisualizationExample.exe");
            }
            catch (Exception r)
            {
                MessageBox.Show(r.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void songWindowBtn_Click(object sender, EventArgs e)
        {
            SongPlaylistUI spUI = new SongPlaylistUI();
            spUI.Show();
        }
    }
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
    public class DRPC
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public string upText;
        public string downText;
        public void DRPCEnable()
        {
            try
            {
                param main = new param();
                this.handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize("840249670059556934", ref this.handlers, true, null);
                this.handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize("840249670059556934", ref this.handlers, true, null);
                this.presence.details = upText;
                this.presence.state = downText;
                this.presence.largeImageKey = "bigicon";
                this.presence.smallImageKey = "bigicon";
                this.presence.largeImageText = "WowPlayer v2.7b";
                this.presence.smallImageText = upText;
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            catch (DllNotFoundException r)
            {
                MessageBox.Show(r.ToString(), "Discord RPC Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

        }
    }
    public class param : Form
    {
        public string upText;
        public string downText;
    }
}
