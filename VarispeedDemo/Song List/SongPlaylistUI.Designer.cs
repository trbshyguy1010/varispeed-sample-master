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
            this.button2 = new System.Windows.Forms.Button();
            this.songList = new System.Windows.Forms.ListBox();
            this.timeTable = new System.Windows.Forms.ListBox();
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
            this.label125.Location = new System.Drawing.Point(16, 46);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(233, 13);
            this.label125.TabIndex = 3;
            this.label125.Text = "Your songs will appear here, you have n songs :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Refresh Song Database";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // songList
            // 
            this.songList.FormattingEnabled = true;
            this.songList.Location = new System.Drawing.Point(12, 75);
            this.songList.Name = "songList";
            this.songList.Size = new System.Drawing.Size(303, 368);
            this.songList.TabIndex = 8;
            // 
            // timeTable
            // 
            this.timeTable.FormattingEnabled = true;
            this.timeTable.Location = new System.Drawing.Point(321, 75);
            this.timeTable.Name = "timeTable";
            this.timeTable.Size = new System.Drawing.Size(101, 368);
            this.timeTable.TabIndex = 9;
            // 
            // SongPlaylistUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.timeTable);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label125);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.ListBox timeTable;
    }
}