namespace PengukurBaterai
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PercentageBar = new System.Windows.Forms.ProgressBar();
            this.Percentage = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeLeft = new System.Windows.Forms.Timer(this.components);
            this.Reset_But = new System.Windows.Forms.Button();
            this.Stop_But = new System.Windows.Forms.Button();
            this.Start_But = new System.Windows.Forms.Button();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Lap_But = new System.Windows.Forms.Button();
            this.Stopwatch_Timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Metering = new System.Windows.Forms.TabPage();
            this.Chart = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Metering.SuspendLayout();
            this.SuspendLayout();
            // 
            // PercentageBar
            // 
            this.PercentageBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PercentageBar.Location = new System.Drawing.Point(11, 42);
            this.PercentageBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PercentageBar.Name = "PercentageBar";
            this.PercentageBar.Size = new System.Drawing.Size(809, 34);
            this.PercentageBar.TabIndex = 0;
            // 
            // Percentage
            // 
            this.Percentage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Percentage.AutoSize = true;
            this.Percentage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Percentage.Location = new System.Drawing.Point(872, 41);
            this.Percentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(47, 32);
            this.Percentage.TabIndex = 1;
            this.Percentage.Text = "0%";
            this.Percentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.Location = new System.Drawing.Point(5, 8);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(343, 29);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "Remaining Time = 00 : 00 : 00";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeLeft
            // 
            this.TimeLeft.Enabled = true;
            this.TimeLeft.Interval = 1000;
            this.TimeLeft.Tick += new System.EventHandler(this.SisaWaktu_Tick);
            // 
            // Reset_But
            // 
            this.Reset_But.Location = new System.Drawing.Point(214, 191);
            this.Reset_But.Name = "Reset_But";
            this.Reset_But.Size = new System.Drawing.Size(194, 38);
            this.Reset_But.TabIndex = 29;
            this.Reset_But.Text = "Reset";
            this.Reset_But.UseVisualStyleBackColor = true;
            this.Reset_But.Click += new System.EventHandler(this.Reset_But_Click);
            // 
            // Stop_But
            // 
            this.Stop_But.Location = new System.Drawing.Point(214, 149);
            this.Stop_But.Name = "Stop_But";
            this.Stop_But.Size = new System.Drawing.Size(194, 38);
            this.Stop_But.TabIndex = 26;
            this.Stop_But.Text = "Stop";
            this.Stop_But.UseVisualStyleBackColor = true;
            this.Stop_But.Click += new System.EventHandler(this.Stop_But_Click);
            // 
            // Start_But
            // 
            this.Start_But.Location = new System.Drawing.Point(11, 149);
            this.Start_But.Name = "Start_But";
            this.Start_But.Size = new System.Drawing.Size(194, 38);
            this.Start_But.TabIndex = 25;
            this.Start_But.Text = "Start";
            this.Start_But.UseVisualStyleBackColor = true;
            this.Start_But.Click += new System.EventHandler(this.Start_But_Click);
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Time.Location = new System.Drawing.Point(60, 81);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(314, 54);
            this.lbl_Time.TabIndex = 22;
            this.lbl_Time.Text = "00 : 00 : 00 : 000";
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(11, 238);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(397, 228);
            this.listBox1.TabIndex = 21;
            // 
            // Lap_But
            // 
            this.Lap_But.Location = new System.Drawing.Point(11, 191);
            this.Lap_But.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Lap_But.Name = "Lap_But";
            this.Lap_But.Size = new System.Drawing.Size(194, 38);
            this.Lap_But.TabIndex = 20;
            this.Lap_But.Text = "Lap";
            this.Lap_But.UseVisualStyleBackColor = true;
            this.Lap_But.UseWaitCursor = true;
            this.Lap_But.Click += new System.EventHandler(this.Lap_But_Click);
            // 
            // Stopwatch_Timer
            // 
            this.Stopwatch_Timer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Metering);
            this.tabControl1.Controls.Add(this.Chart);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(940, 510);
            this.tabControl1.TabIndex = 36;
            // 
            // Metering
            // 
            this.Metering.Controls.Add(this.PercentageBar);
            this.Metering.Controls.Add(this.Percentage);
            this.Metering.Controls.Add(this.TimeLabel);
            this.Metering.Controls.Add(this.listBox1);
            this.Metering.Controls.Add(this.Lap_But);
            this.Metering.Controls.Add(this.lbl_Time);
            this.Metering.Controls.Add(this.Start_But);
            this.Metering.Controls.Add(this.Reset_But);
            this.Metering.Controls.Add(this.Stop_But);
            this.Metering.Location = new System.Drawing.Point(4, 34);
            this.Metering.Name = "Metering";
            this.Metering.Padding = new System.Windows.Forms.Padding(3);
            this.Metering.Size = new System.Drawing.Size(932, 472);
            this.Metering.TabIndex = 0;
            this.Metering.Text = "Metering";
            this.Metering.UseVisualStyleBackColor = true;
            // 
            // Chart
            // 
            this.Chart.Location = new System.Drawing.Point(4, 34);
            this.Chart.Name = "Chart";
            this.Chart.Padding = new System.Windows.Forms.Padding(3);
            this.Chart.Size = new System.Drawing.Size(932, 472);
            this.Chart.TabIndex = 1;
            this.Chart.Text = "Chart";
            this.Chart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 512);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Metering.ResumeLayout(false);
            this.Metering.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ProgressBar PercentageBar;
        private Label Percentage;
        private Label TimeLabel;
        private System.Windows.Forms.Timer TimeLeft;
        private Button Reset_But;
        private Button Stop_But;
        private Button Start_But;
        private Label lbl_Time;
        private ListBox listBox1;
        private Button Lap_But;
        private System.Windows.Forms.Timer Stopwatch_Timer;
        private TabControl tabControl1;
        private TabPage Metering;
        private TabPage Chart;
    }
}