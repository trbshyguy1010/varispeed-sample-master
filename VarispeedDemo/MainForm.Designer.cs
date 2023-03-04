namespace VarispeedDemo
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getSongsFromURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gettingStartedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubUwUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.controlBoxMini1 = new System.Windows.Forms.GroupBox();
            this.rebut = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxModes = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.trackBarPlaybackRate = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1Master = new System.Windows.Forms.ProgressBar();
            this.labelPlaybackSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.applyspeed = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.volumeBar1 = new System.Windows.Forms.TrackBar();
            this.playBox1 = new System.Windows.Forms.GroupBox();
            this.songWindowBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.uplabel9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.trackBarPlaybackPosition = new System.Windows.Forms.TrackBar();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.controlBoxMini1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlaybackRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar1)).BeginInit();
            this.playBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlaybackPosition)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.betaToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.getSongsFromURLToolStripMenuItem,
            this.refreshSongsToolStripMenuItem,
            this.loadFromFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.loadToolStripMenuItem.Text = "Load...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // getSongsFromURLToolStripMenuItem
            // 
            this.getSongsFromURLToolStripMenuItem.Name = "getSongsFromURLToolStripMenuItem";
            this.getSongsFromURLToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.getSongsFromURLToolStripMenuItem.Text = "Get songs from URL...";
            this.getSongsFromURLToolStripMenuItem.Click += new System.EventHandler(this.getSongsFromURLToolStripMenuItem_Click);
            // 
            // refreshSongsToolStripMenuItem
            // 
            this.refreshSongsToolStripMenuItem.Name = "refreshSongsToolStripMenuItem";
            this.refreshSongsToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.refreshSongsToolStripMenuItem.Text = "Refresh Songs";
            this.refreshSongsToolStripMenuItem.Click += new System.EventHandler(this.refreshSongsToolStripMenuItem_Click);
            // 
            // loadFromFolderToolStripMenuItem
            // 
            this.loadFromFolderToolStripMenuItem.Name = "loadFromFolderToolStripMenuItem";
            this.loadFromFolderToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.loadFromFolderToolStripMenuItem.Text = "Load from Folder...";
            this.loadFromFolderToolStripMenuItem.Click += new System.EventHandler(this.loadFromFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // betaToolStripMenuItem
            // 
            this.betaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pluginManagerToolStripMenuItem});
            this.betaToolStripMenuItem.Name = "betaToolStripMenuItem";
            this.betaToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.betaToolStripMenuItem.Text = "Song (Beta)";
            // 
            // pluginManagerToolStripMenuItem
            // 
            this.pluginManagerToolStripMenuItem.Name = "pluginManagerToolStripMenuItem";
            this.pluginManagerToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.pluginManagerToolStripMenuItem.Text = "Visualizer";
            this.pluginManagerToolStripMenuItem.Click += new System.EventHandler(this.pluginManagerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gettingStartedToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.gitHubUwUToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // gettingStartedToolStripMenuItem
            // 
            this.gettingStartedToolStripMenuItem.Name = "gettingStartedToolStripMenuItem";
            this.gettingStartedToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.gettingStartedToolStripMenuItem.Text = "Getting Started...";
            this.gettingStartedToolStripMenuItem.Click += new System.EventHandler(this.gettingStartedToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // gitHubUwUToolStripMenuItem
            // 
            this.gitHubUwUToolStripMenuItem.Name = "gitHubUwUToolStripMenuItem";
            this.gitHubUwUToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.gitHubUwUToolStripMenuItem.Text = "GitHub UwU";
            this.gitHubUwUToolStripMenuItem.Click += new System.EventHandler(this.gitHubUwUToolStripMenuItem_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // controlBoxMini1
            // 
            this.controlBoxMini1.Controls.Add(this.rebut);
            this.controlBoxMini1.Controls.Add(this.label9);
            this.controlBoxMini1.Controls.Add(this.label7);
            this.controlBoxMini1.Controls.Add(this.label8);
            this.controlBoxMini1.Controls.Add(this.comboBoxModes);
            this.controlBoxMini1.Controls.Add(this.comboBox2);
            this.controlBoxMini1.Controls.Add(this.trackBarPlaybackRate);
            this.controlBoxMini1.Controls.Add(this.label6);
            this.controlBoxMini1.Controls.Add(this.label1);
            this.controlBoxMini1.Controls.Add(this.progressBar1Master);
            this.controlBoxMini1.Controls.Add(this.labelPlaybackSpeed);
            this.controlBoxMini1.Controls.Add(this.label5);
            this.controlBoxMini1.Controls.Add(this.applyspeed);
            this.controlBoxMini1.Controls.Add(this.label4);
            this.controlBoxMini1.Controls.Add(this.volumeBar1);
            this.controlBoxMini1.Location = new System.Drawing.Point(513, 37);
            this.controlBoxMini1.Margin = new System.Windows.Forms.Padding(4);
            this.controlBoxMini1.Name = "controlBoxMini1";
            this.controlBoxMini1.Padding = new System.Windows.Forms.Padding(4);
            this.controlBoxMini1.Size = new System.Drawing.Size(460, 306);
            this.controlBoxMini1.TabIndex = 21;
            this.controlBoxMini1.TabStop = false;
            this.controlBoxMini1.Text = "Controls";
            // 
            // rebut
            // 
            this.rebut.Location = new System.Drawing.Point(345, 52);
            this.rebut.Margin = new System.Windows.Forms.Padding(4);
            this.rebut.Name = "rebut";
            this.rebut.Size = new System.Drawing.Size(100, 28);
            this.rebut.TabIndex = 36;
            this.rebut.Text = "Reset x1.0";
            this.rebut.UseVisualStyleBackColor = true;
            this.rebut.Click += new System.EventHandler(this.rebut_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 217);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 270);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Available devices :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 240);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 33;
            // 
            // comboBoxModes
            // 
            this.comboBoxModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModes.FormattingEnabled = true;
            this.comboBoxModes.Location = new System.Drawing.Point(15, 23);
            this.comboBoxModes.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxModes.Name = "comboBoxModes";
            this.comboBoxModes.Size = new System.Drawing.Size(320, 24);
            this.comboBoxModes.TabIndex = 23;
            this.comboBoxModes.SelectedIndexChanged += new System.EventHandler(this.comboBoxModes_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(147, 266);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(288, 24);
            this.comboBox2.TabIndex = 32;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // trackBarPlaybackRate
            // 
            this.trackBarPlaybackRate.Enabled = false;
            this.trackBarPlaybackRate.Location = new System.Drawing.Point(15, 89);
            this.trackBarPlaybackRate.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarPlaybackRate.Maximum = 25;
            this.trackBarPlaybackRate.Name = "trackBarPlaybackRate";
            this.trackBarPlaybackRate.Size = new System.Drawing.Size(377, 56);
            this.trackBarPlaybackRate.TabIndex = 22;
            this.trackBarPlaybackRate.Value = 5;
            this.trackBarPlaybackRate.Scroll += new System.EventHandler(this.OnTrackBarPlaybackRateScroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 241);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Master Volume Meter (Speaker)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Playback Speed";
            // 
            // progressBar1Master
            // 
            this.progressBar1Master.Enabled = false;
            this.progressBar1Master.Location = new System.Drawing.Point(52, 217);
            this.progressBar1Master.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1Master.Name = "progressBar1Master";
            this.progressBar1Master.Size = new System.Drawing.Size(384, 16);
            this.progressBar1Master.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1Master.TabIndex = 30;
            // 
            // labelPlaybackSpeed
            // 
            this.labelPlaybackSpeed.AutoSize = true;
            this.labelPlaybackSpeed.Location = new System.Drawing.Point(400, 96);
            this.labelPlaybackSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlaybackSpeed.Name = "labelPlaybackSpeed";
            this.labelPlaybackSpeed.Size = new System.Drawing.Size(30, 16);
            this.labelPlaybackSpeed.TabIndex = 25;
            this.labelPlaybackSpeed.Text = "x1.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Volume";
            // 
            // applyspeed
            // 
            this.applyspeed.Enabled = false;
            this.applyspeed.Location = new System.Drawing.Point(344, 22);
            this.applyspeed.Margin = new System.Windows.Forms.Padding(4);
            this.applyspeed.Name = "applyspeed";
            this.applyspeed.Size = new System.Drawing.Size(101, 28);
            this.applyspeed.TabIndex = 26;
            this.applyspeed.Text = "Apply";
            this.applyspeed.UseVisualStyleBackColor = true;
            this.applyspeed.Click += new System.EventHandler(this.applyspeed_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "-%";
            // 
            // volumeBar1
            // 
            this.volumeBar1.Enabled = false;
            this.volumeBar1.Location = new System.Drawing.Point(15, 162);
            this.volumeBar1.Margin = new System.Windows.Forms.Padding(4);
            this.volumeBar1.Maximum = 100;
            this.volumeBar1.Name = "volumeBar1";
            this.volumeBar1.Size = new System.Drawing.Size(377, 56);
            this.volumeBar1.TabIndex = 27;
            this.volumeBar1.Value = 100;
            this.volumeBar1.Scroll += new System.EventHandler(this.volumeBar1_Scroll);
            // 
            // playBox1
            // 
            this.playBox1.Controls.Add(this.songWindowBtn);
            this.playBox1.Controls.Add(this.label10);
            this.playBox1.Controls.Add(this.uplabel9);
            this.playBox1.Controls.Add(this.comboBox1);
            this.playBox1.Controls.Add(this.label3);
            this.playBox1.Controls.Add(this.labelPosition);
            this.playBox1.Controls.Add(this.label2);
            this.playBox1.Controls.Add(this.buttonLoad);
            this.playBox1.Controls.Add(this.trackBarPlaybackPosition);
            this.playBox1.Controls.Add(this.buttonStop);
            this.playBox1.Controls.Add(this.buttonPlay);
            this.playBox1.Location = new System.Drawing.Point(17, 37);
            this.playBox1.Margin = new System.Windows.Forms.Padding(4);
            this.playBox1.Name = "playBox1";
            this.playBox1.Padding = new System.Windows.Forms.Padding(4);
            this.playBox1.Size = new System.Drawing.Size(488, 306);
            this.playBox1.TabIndex = 22;
            this.playBox1.TabStop = false;
            this.playBox1.Text = "Playback";
            // 
            // songWindowBtn
            // 
            this.songWindowBtn.Location = new System.Drawing.Point(27, 54);
            this.songWindowBtn.Margin = new System.Windows.Forms.Padding(4);
            this.songWindowBtn.Name = "songWindowBtn";
            this.songWindowBtn.Size = new System.Drawing.Size(145, 28);
            this.songWindowBtn.TabIndex = 30;
            this.songWindowBtn.Text = "Show Playlist";
            this.songWindowBtn.UseVisualStyleBackColor = true;
            this.songWindowBtn.Click += new System.EventHandler(this.songWindowBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 240);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Song Duration : --:--";
            // 
            // uplabel9
            // 
            this.uplabel9.AutoSize = true;
            this.uplabel9.Location = new System.Drawing.Point(228, 272);
            this.uplabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uplabel9.Name = "uplabel9";
            this.uplabel9.Size = new System.Drawing.Size(47, 16);
            this.uplabel9.TabIndex = 28;
            this.uplabel9.Text = "Time : ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 26);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(333, 24);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Location = new System.Drawing.Point(27, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 65);
            this.label3.TabIndex = 26;
            this.label3.Text = "Now Playing :";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(405, 183);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(38, 16);
            this.labelPosition.TabIndex = 25;
            this.labelPosition.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Playback Position";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(369, 25);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(100, 28);
            this.buttonLoad.TabIndex = 23;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.OnButtonLoadClick);
            // 
            // trackBarPlaybackPosition
            // 
            this.trackBarPlaybackPosition.Location = new System.Drawing.Point(23, 181);
            this.trackBarPlaybackPosition.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarPlaybackPosition.Maximum = 100;
            this.trackBarPlaybackPosition.Name = "trackBarPlaybackPosition";
            this.trackBarPlaybackPosition.Size = new System.Drawing.Size(375, 56);
            this.trackBarPlaybackPosition.SmallChange = 5;
            this.trackBarPlaybackPosition.TabIndex = 22;
            this.trackBarPlaybackPosition.TickFrequency = 5;
            this.trackBarPlaybackPosition.Scroll += new System.EventHandler(this.trackBarPlaybackPosition_Scroll);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(123, 266);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(97, 28);
            this.buttonStop.TabIndex = 21;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.OnButtonStopClick);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(15, 266);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(100, 28);
            this.buttonPlay.TabIndex = 20;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(17, 351);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(956, 154);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WaveForm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(413, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Wave thingy loading brb...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(909, 113);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 511);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(992, 26);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(132, 20);
            this.toolStripStatusLabel1.Text = "Quote of the day : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 537);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.playBox1);
            this.Controls.Add(this.controlBoxMini1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "WowPlayer v2.7a";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.controlBoxMini1.ResumeLayout(false);
            this.controlBoxMini1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlaybackRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar1)).EndInit();
            this.playBox1.ResumeLayout(false);
            this.playBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlaybackPosition)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betaToolStripMenuItem;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.GroupBox controlBoxMini1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxModes;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TrackBar trackBarPlaybackRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1Master;
        private System.Windows.Forms.Label labelPlaybackSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button applyspeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar volumeBar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox playBox1;
        private System.Windows.Forms.Label uplabel9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TrackBar trackBarPlaybackPosition;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button rebut;
        private System.Windows.Forms.ToolStripMenuItem pluginManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button songWindowBtn;
        private System.Windows.Forms.ToolStripMenuItem refreshSongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getSongsFromURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gettingStartedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem gitHubUwUToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

