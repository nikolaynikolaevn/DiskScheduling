namespace DiskScheduling
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
            this.gbStrategy = new System.Windows.Forms.GroupBox();
            this.rbtnSCAN = new System.Windows.Forms.RadioButton();
            this.rbtnSSTF = new System.Windows.Forms.RadioButton();
            this.rbtnFCFS = new System.Windows.Forms.RadioButton();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbSectors = new System.Windows.Forms.ListBox();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.trackBarSectors = new System.Windows.Forms.TrackBar();
            this.timerRequests = new System.Windows.Forms.Timer(this.components);
            this.gbStrategy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSectors)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStrategy
            // 
            this.gbStrategy.Controls.Add(this.rbtnSCAN);
            this.gbStrategy.Controls.Add(this.rbtnSSTF);
            this.gbStrategy.Controls.Add(this.rbtnFCFS);
            this.gbStrategy.Location = new System.Drawing.Point(180, 41);
            this.gbStrategy.Name = "gbStrategy";
            this.gbStrategy.Size = new System.Drawing.Size(200, 91);
            this.gbStrategy.TabIndex = 0;
            this.gbStrategy.TabStop = false;
            this.gbStrategy.Text = "Strategy";
            // 
            // rbtnSCAN
            // 
            this.rbtnSCAN.AutoSize = true;
            this.rbtnSCAN.Location = new System.Drawing.Point(6, 64);
            this.rbtnSCAN.Name = "rbtnSCAN";
            this.rbtnSCAN.Size = new System.Drawing.Size(125, 17);
            this.rbtnSCAN.TabIndex = 2;
            this.rbtnSCAN.Text = "SCAN Disk (elevator)";
            this.rbtnSCAN.UseVisualStyleBackColor = true;
            // 
            // rbtnSSTF
            // 
            this.rbtnSSTF.AutoSize = true;
            this.rbtnSSTF.Location = new System.Drawing.Point(6, 41);
            this.rbtnSSTF.Name = "rbtnSSTF";
            this.rbtnSSTF.Size = new System.Drawing.Size(176, 17);
            this.rbtnSSTF.TabIndex = 1;
            this.rbtnSSTF.Text = "Shortest Seek Time First (SSTF)";
            this.rbtnSSTF.UseVisualStyleBackColor = true;
            this.rbtnSSTF.CheckedChanged += new System.EventHandler(this.rbtnSSTF_CheckedChanged);
            // 
            // rbtnFCFS
            // 
            this.rbtnFCFS.AutoSize = true;
            this.rbtnFCFS.Checked = true;
            this.rbtnFCFS.Location = new System.Drawing.Point(6, 18);
            this.rbtnFCFS.Name = "rbtnFCFS";
            this.rbtnFCFS.Size = new System.Drawing.Size(162, 17);
            this.rbtnFCFS.TabIndex = 0;
            this.rbtnFCFS.TabStop = true;
            this.rbtnFCFS.Text = "First Come First Serve (FCFS)";
            this.rbtnFCFS.UseVisualStyleBackColor = true;
            this.rbtnFCFS.CheckedChanged += new System.EventHandler(this.rbtnFCFS_CheckedChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(180, 138);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(261, 138);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbSectors
            // 
            this.lbSectors.FormattingEnabled = true;
            this.lbSectors.Location = new System.Drawing.Point(110, 68);
            this.lbSectors.Name = "lbSectors";
            this.lbSectors.Size = new System.Drawing.Size(35, 251);
            this.lbSectors.TabIndex = 3;
            // 
            // tbCurrent
            // 
            this.tbCurrent.Location = new System.Drawing.Point(110, 42);
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.Size = new System.Drawing.Size(35, 20);
            this.tbCurrent.TabIndex = 4;
            // 
            // trackBarSectors
            // 
            this.trackBarSectors.Location = new System.Drawing.Point(25, 41);
            this.trackBarSectors.Maximum = 100;
            this.trackBarSectors.Name = "trackBarSectors";
            this.trackBarSectors.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarSectors.Size = new System.Drawing.Size(45, 278);
            this.trackBarSectors.TabIndex = 6;
            // 
            // timerRequests
            // 
            this.timerRequests.Interval = 500;
            this.timerRequests.Tick += new System.EventHandler(this.timerRequests_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 357);
            this.Controls.Add(this.trackBarSectors);
            this.Controls.Add(this.tbCurrent);
            this.Controls.Add(this.lbSectors);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.gbStrategy);
            this.Name = "MainForm";
            this.Text = "Disk Scheduling";
            this.gbStrategy.ResumeLayout(false);
            this.gbStrategy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSectors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStrategy;
        private System.Windows.Forms.RadioButton rbtnSCAN;
        private System.Windows.Forms.RadioButton rbtnSSTF;
        private System.Windows.Forms.RadioButton rbtnFCFS;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox lbSectors;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.TrackBar trackBarSectors;
        private System.Windows.Forms.Timer timerRequests;
    }
}

