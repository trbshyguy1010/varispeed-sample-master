namespace VarispeedDemo
{
    partial class loadSongsFolderWindow
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
            this.confirmBtn = new System.Windows.Forms.Button();
            this.songsList = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dot3btn = new System.Windows.Forms.Button();
            this.txthlp = new System.Windows.Forms.Label();
            this.mp3filechecker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(349, 290);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 0;
            this.confirmBtn.Text = "OK";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // songsList
            // 
            this.songsList.FormattingEnabled = true;
            this.songsList.Location = new System.Drawing.Point(12, 85);
            this.songsList.Name = "songsList";
            this.songsList.Size = new System.Drawing.Size(412, 199);
            this.songsList.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dot3btn
            // 
            this.dot3btn.Location = new System.Drawing.Point(397, 31);
            this.dot3btn.Name = "dot3btn";
            this.dot3btn.Size = new System.Drawing.Size(27, 21);
            this.dot3btn.TabIndex = 3;
            this.dot3btn.Text = "...";
            this.dot3btn.UseVisualStyleBackColor = true;
            this.dot3btn.Click += new System.EventHandler(this.dot3btn_Click);
            // 
            // txthlp
            // 
            this.txthlp.AutoSize = true;
            this.txthlp.Location = new System.Drawing.Point(12, 9);
            this.txthlp.Name = "txthlp";
            this.txthlp.Size = new System.Drawing.Size(92, 13);
            this.txthlp.TabIndex = 4;
            this.txthlp.Text = "Choose directory :";
            // 
            // mp3filechecker
            // 
            this.mp3filechecker.Location = new System.Drawing.Point(12, 57);
            this.mp3filechecker.Name = "mp3filechecker";
            this.mp3filechecker.Size = new System.Drawing.Size(75, 23);
            this.mp3filechecker.TabIndex = 5;
            this.mp3filechecker.Text = "Add Songs";
            this.mp3filechecker.UseVisualStyleBackColor = true;
            this.mp3filechecker.Click += new System.EventHandler(this.mp3filechecker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please Wait while its taking its sweet, sweet time...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Just don\'t make it search in the C:\\ directory okay?";
            // 
            // loadSongsFolderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 325);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mp3filechecker);
            this.Controls.Add(this.txthlp);
            this.Controls.Add(this.dot3btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.songsList);
            this.Controls.Add(this.confirmBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loadSongsFolderWindow";
            this.Text = "Choose Folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.ListBox songsList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button dot3btn;
        private System.Windows.Forms.Label txthlp;
        private System.Windows.Forms.Button mp3filechecker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}