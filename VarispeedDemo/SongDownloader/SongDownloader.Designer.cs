namespace VarispeedDemo.SongDownloader
{
    partial class SongDownloader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vidTitle = new System.Windows.Forms.Label();
            this.download_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.urlText = new System.Windows.Forms.TextBox();
            this.songExt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.songExt);
            this.groupBox1.Controls.Add(this.vidTitle);
            this.groupBox1.Controls.Add(this.download_btn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Controls.Add(this.urlText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Song Downloader from URL :";
            // 
            // vidTitle
            // 
            this.vidTitle.AutoSize = true;
            this.vidTitle.Location = new System.Drawing.Point(53, 122);
            this.vidTitle.Name = "vidTitle";
            this.vidTitle.Size = new System.Drawing.Size(78, 16);
            this.vidTitle.TabIndex = 5;
            this.vidTitle.Text = "Video Title :";
            // 
            // download_btn
            // 
            this.download_btn.Location = new System.Drawing.Point(571, 233);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(188, 40);
            this.download_btn.TabIndex = 4;
            this.download_btn.Text = "Download";
            this.download_btn.UseVisualStyleBackColor = true;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter URL :";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(571, 61);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(188, 32);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Search Song";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(18, 30);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(742, 22);
            this.urlText.TabIndex = 0;
            // 
            // songExt
            // 
            this.songExt.Location = new System.Drawing.Point(339, 242);
            this.songExt.Name = "songExt";
            this.songExt.Size = new System.Drawing.Size(97, 22);
            this.songExt.TabIndex = 6;
            this.songExt.Text = ".mp3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Save as (leaving it empty will default to .aac file) :";
            // 
            // SongDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 323);
            this.Controls.Add(this.groupBox1);
            this.Name = "SongDownloader";
            this.Text = "SongDownloader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button download_btn;
        private System.Windows.Forms.Label vidTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox songExt;
    }
}