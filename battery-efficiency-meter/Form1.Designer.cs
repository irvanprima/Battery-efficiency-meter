namespace battery_efficiency_meter
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.PercentageBar = new System.Windows.Forms.ProgressBar();
            this.Percentage = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.Start_But = new System.Windows.Forms.Button();
            this.Lap_But = new System.Windows.Forms.Button();
            this.Reset_But = new System.Windows.Forms.Button();
            this.Stop_But = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(5, 8);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(331, 29);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "Remaining Time = 00 : 00 : 00";
            // 
            // PercentageBar
            // 
            this.PercentageBar.Location = new System.Drawing.Point(11, 42);
            this.PercentageBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PercentageBar.Name = "PercentageBar";
            this.PercentageBar.Size = new System.Drawing.Size(809, 34);
            this.PercentageBar.TabIndex = 1;
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Percentage.Location = new System.Drawing.Point(838, 42);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(47, 32);
            this.Percentage.TabIndex = 2;
            this.Percentage.Text = "0%";
            this.Percentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lbl_Time.Location = new System.Drawing.Point(60, 81);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(314, 54);
            this.lbl_Time.TabIndex = 3;
            this.lbl_Time.Text = "00 : 00 : 00 : 000";
            // 
            // Start_But
            // 
            this.Start_But.Location = new System.Drawing.Point(10, 149);
            this.Start_But.Name = "Start_But";
            this.Start_But.Size = new System.Drawing.Size(194, 38);
            this.Start_But.TabIndex = 4;
            this.Start_But.Text = "Start";
            this.Start_But.UseVisualStyleBackColor = true;
            // 
            // Lap_But
            // 
            this.Lap_But.Location = new System.Drawing.Point(10, 193);
            this.Lap_But.Name = "Lap_But";
            this.Lap_But.Size = new System.Drawing.Size(194, 38);
            this.Lap_But.TabIndex = 5;
            this.Lap_But.Text = "Lap";
            this.Lap_But.UseVisualStyleBackColor = true;
            // 
            // Reset_But
            // 
            this.Reset_But.Location = new System.Drawing.Point(214, 193);
            this.Reset_But.Name = "Reset_But";
            this.Reset_But.Size = new System.Drawing.Size(194, 38);
            this.Reset_But.TabIndex = 7;
            this.Reset_But.Text = "Reset";
            this.Reset_But.UseVisualStyleBackColor = true;
            // 
            // Stop_But
            // 
            this.Stop_But.Location = new System.Drawing.Point(214, 149);
            this.Stop_But.Name = "Stop_But";
            this.Stop_But.Size = new System.Drawing.Size(194, 38);
            this.Stop_But.TabIndex = 6;
            this.Stop_But.Text = "Stop";
            this.Stop_But.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(11, 238);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(397, 228);
            this.listBox1.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart1.Legends.Add(legend11);
            this.chart1.Location = new System.Drawing.Point(447, 149);
            this.chart1.Name = "chart1";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chart1.Series.Add(series11);
            this.chart1.Size = new System.Drawing.Size(472, 317);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 1000;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 512);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Reset_But);
            this.Controls.Add(this.Stop_But);
            this.Controls.Add(this.Lap_But);
            this.Controls.Add(this.Start_But);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.PercentageBar);
            this.Controls.Add(this.TimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.ProgressBar PercentageBar;
        private System.Windows.Forms.Label Percentage;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Button Start_But;
        private System.Windows.Forms.Button Lap_But;
        private System.Windows.Forms.Button Reset_But;
        private System.Windows.Forms.Button Stop_But;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer UpdateTimer;
    }
}

