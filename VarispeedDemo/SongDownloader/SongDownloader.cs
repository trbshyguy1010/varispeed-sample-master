using System.Data;
using VideoLibrary;
using MediaToolkit;
using MediaToolkit.Model;
using System.Diagnostics;

namespace VarispeedDemo.SongDownloader
{
    public partial class SongDownloader : Form
    {
        public SongDownloader()
        {
            InitializeComponent();
            enableControlsWhenDownloading(true);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string url = urlText.Text;
            enableControlsWhenDownloading(false);
            try
            {
                var getURL = videoExtractor(url);
                vidTitle.Text = "Video Title : " + getURL.Title;
                enableControlsWhenDownloading(true);

            } catch (Exception ex) 
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("This is not a valid URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                enableControlsWhenDownloading(true);
            }
        }
        private YouTubeVideo videoExtractor(string url)
        {
            return YouTube.Default.GetVideo(url);
        }
        private void enableControlsWhenDownloading(bool isEnabled)
        {
            search_btn.Enabled = isEnabled;
            urlText.Enabled = isEnabled;
            songExt.Enabled = isEnabled;
            download_btn.Enabled = isEnabled;
        }
        public string getFullFilePath(string filePath, List<YouTubeVideo> audio)
        {
            return filePath + "\\" + string.Join("_", audio[0].Title.Split(Path.GetInvalidFileNameChars()));
        }

        private async Task<byte[]>? DownloadSong(string url, YouTubeVideo mpAudio)
        {
            try
            {
                var getURL = await YouTube.Default.GetAllVideosAsync(url);
                MessageBox.Show("Downloading in progress...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                enableControlsWhenDownloading(false);
                return await Task.Run(mpAudio.GetBytesAsync); 
            }
            catch
            {
                MessageBox.Show("This is not a valid URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                enableControlsWhenDownloading(true);
                return null;
            }
        }
        private async void download_btn_Click(object sender, EventArgs e)
        {
            string url = urlText.Text;
            try
            {
                var getURL = YouTube.Default.GetAllVideos(url);
                var sfd = new FolderBrowserDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string dirString = sfd.SelectedPath;
                    var audio = getURL.Where(_ => _.AudioFormat == AudioFormat.Aac && _.AdaptiveKind == AdaptiveKind.Audio).ToList();
                    var mpAudio = audio.FirstOrDefault(x => x.AudioBitrate > 0);
                    string fullName = getFullFilePath(dirString, audio);
                    byte[]? bytes = await DownloadSong(url, mpAudio);

                    if (bytes is null) { 
                        MessageBox.Show("Error while downloading file...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                        return; 
                    }

                    if (songExt.Text == "")
                    {
                        File.WriteAllBytes(fullName + ".aac", bytes);
                        MessageBox.Show("Download completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        try
                        {
                            File.WriteAllBytes(fullName + ".aac", bytes);
                            var inputfile = new MediaFile { Filename = fullName + ".aac" };
                            var outputfile = new MediaFile { Filename = fullName + songExt.Text };
                            using (var engine = new Engine())
                            {
                                engine.Convert(inputfile, outputfile);
                            }
                            if (File.Exists(fullName + ".aac"))
                            {
                                File.Delete(fullName + ".aac");
                            }
                            MessageBox.Show("Download completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            enableControlsWhenDownloading(true);
                        } catch
                        {
                            MessageBox.Show("Error: Invalid audio extension", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                            enableControlsWhenDownloading(true);
                            return;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("This is not a valid URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                enableControlsWhenDownloading(true);
                return;
            }
        }
    }
}
