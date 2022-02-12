namespace VarispeedDemo
{
    partial class SongPlaylistUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label125 = new System.Windows.Forms.Label();
            this.songLoadingProgress = new System.Windows.Forms.ProgressBar();
            this.percentage = new System.Windows.Forms.Label();
            this.songList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Playlist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(16, 56);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(233, 13);
            this.label125.TabIndex = 3;
            this.label125.Text = "Your songs will appear here, you have n songs :";
            // 
            // songLoadingProgress
            // 
            this.songLoadingProgress.Location = new System.Drawing.Point(13, 40);
            this.songLoadingProgress.Name = "songLoadingProgress";
            this.songLoadingProgress.Size = new System.Drawing.Size(409, 13);
            this.songLoadingProgress.TabIndex = 4;
            // 
            // percentage
            // 
            this.percentage.AutoSize = true;
            this.percentage.Location = new System.Drawing.Point(386, 56);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(21, 13);
            this.percentage.TabIndex = 5;
            this.percentage.Text = "--%";
            this.percentage.Visible = false;
            // 
            // songList
            // 
            this.songList.HideSelection = false;
            this.songList.Location = new System.Drawing.Point(13, 72);
            this.songList.Name = "songList";
            this.songList.Size = new System.Drawing.Size(409, 649);
            this.songList.TabIndex = 6;
            this.songList.UseCompatibleStateImageBehavior = false;
            // 
            // SongPlaylistUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 733);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.songLoadingProgress);
            this.Controls.Add(this.label125);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "SongPlaylistUI";
            this.Text = "SongPlaylistUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.ProgressBar songLoadingProgress;
        private System.Windows.Forms.Label percentage;
        private System.Windows.Forms.ListView songList;
    }
}