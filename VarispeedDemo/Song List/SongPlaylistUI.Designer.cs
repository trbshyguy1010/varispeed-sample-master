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
            this.songList = new System.Windows.Forms.ListBox();
            this.timeTable = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Playlist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(565, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(21, 57);
            this.label125.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(179, 16);
            this.label125.TabIndex = 3;
            this.label125.Text = "Your songs will appear here :\r\n";
            // 
            // songList
            // 
            this.songList.FormattingEnabled = true;
            this.songList.ItemHeight = 16;
            this.songList.Location = new System.Drawing.Point(16, 92);
            this.songList.Margin = new System.Windows.Forms.Padding(4);
            this.songList.Name = "songList";
            this.songList.Size = new System.Drawing.Size(567, 452);
            this.songList.TabIndex = 8;
            // 
            // timeTable
            // 
            this.timeTable.FormattingEnabled = true;
            this.timeTable.ItemHeight = 16;
            this.timeTable.Location = new System.Drawing.Point(592, 92);
            this.timeTable.Margin = new System.Windows.Forms.Padding(4);
            this.timeTable.Name = "timeTable";
            this.timeTable.Size = new System.Drawing.Size(133, 452);
            this.timeTable.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 551);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 41);
            this.button3.TabIndex = 10;
            this.button3.Text = "Clear Everything";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(546, 551);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 41);
            this.button4.TabIndex = 11;
            this.button4.Text = "Save Playlist";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SongPlaylistUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 604);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.timeTable);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.label125);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SongPlaylistUI";
            this.Text = "SongPlaylistUI";
            this.Load += new System.EventHandler(this.spUI_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.ListBox timeTable;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}