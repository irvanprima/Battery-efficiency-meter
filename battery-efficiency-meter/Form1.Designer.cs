﻿namespace battery_efficiency_meter
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.PercentageBar = new System.Windows.Forms.ProgressBar();
            this.Percentage = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.Start_But = new System.Windows.Forms.Button();
            this.Lap_But = new System.Windows.Forms.Button();
            this.Reset_But = new System.Windows.Forms.Button();
            this.Pause_But = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Remaining_Timer = new System.Windows.Forms.Timer(this.components);
            this.Stopwatch_Timer = new System.Windows.Forms.Timer(this.components);
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.write_data = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(6, 5);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(218, 20);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "Remaining Time = 00 : 00 : 00";
            // 
            // PercentageBar
            // 
            this.PercentageBar.Location = new System.Drawing.Point(10, 27);
            this.PercentageBar.Name = "PercentageBar";
            this.PercentageBar.Size = new System.Drawing.Size(557, 22);
            this.PercentageBar.TabIndex = 1;
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Percentage.Location = new System.Drawing.Point(572, 27);
            this.Percentage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(32, 21);
            this.Percentage.TabIndex = 2;
            this.Percentage.Text = "0%";
            this.Percentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lbl_Time.Location = new System.Drawing.Point(191, 53);
            this.lbl_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(212, 37);
            this.lbl_Time.TabIndex = 3;
            this.lbl_Time.Text = "00 : 00 : 00 : 000";
            // 
            // Start_But
            // 
            this.Start_But.Location = new System.Drawing.Point(10, 96);
            this.Start_But.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start_But.Name = "Start_But";
            this.Start_But.Size = new System.Drawing.Size(109, 25);
            this.Start_But.TabIndex = 4;
            this.Start_But.Text = "Start";
            this.Start_But.UseVisualStyleBackColor = true;
            this.Start_But.Click += new System.EventHandler(this.Start_But_Click);
            // 
            // Lap_But
            // 
            this.Lap_But.Enabled = false;
            this.Lap_But.Location = new System.Drawing.Point(238, 96);
            this.Lap_But.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Lap_But.Name = "Lap_But";
            this.Lap_But.Size = new System.Drawing.Size(109, 25);
            this.Lap_But.TabIndex = 5;
            this.Lap_But.Text = "Record";
            this.Lap_But.UseVisualStyleBackColor = true;
            this.Lap_But.Click += new System.EventHandler(this.Lap_But_Click);
            // 
            // Reset_But
            // 
            this.Reset_But.Location = new System.Drawing.Point(354, 96);
            this.Reset_But.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Reset_But.Name = "Reset_But";
            this.Reset_But.Size = new System.Drawing.Size(109, 25);
            this.Reset_But.TabIndex = 7;
            this.Reset_But.Text = "Reset";
            this.Reset_But.UseVisualStyleBackColor = true;
            this.Reset_But.Click += new System.EventHandler(this.Reset_But_Click);
            // 
            // Pause_But
            // 
            this.Pause_But.Location = new System.Drawing.Point(124, 96);
            this.Pause_But.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pause_But.Name = "Pause_But";
            this.Pause_But.Size = new System.Drawing.Size(109, 25);
            this.Pause_But.TabIndex = 6;
            this.Pause_But.Text = "Pause";
            this.Pause_But.UseVisualStyleBackColor = true;
            this.Pause_But.Click += new System.EventHandler(this.Stop_But_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(10, 206);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 151);
            this.listBox1.TabIndex = 8;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(267, 148);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.Name = "battery";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(349, 209);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Battery Chart";
            this.chart1.Titles.Add(title1);
            // 
            // Remaining_Timer
            // 
            this.Remaining_Timer.Enabled = true;
            this.Remaining_Timer.Interval = 1000;
            this.Remaining_Timer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // Stopwatch_Timer
            // 
            this.Stopwatch_Timer.Tick += new System.EventHandler(this.Stopwatch_Timer_Tick);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Location = new System.Drawing.Point(10, 158);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(253, 25);
            this.listBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Start Record";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Record Results";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // write_data
            // 
            this.write_data.Location = new System.Drawing.Point(495, 96);
            this.write_data.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.write_data.Name = "write_data";
            this.write_data.Size = new System.Drawing.Size(109, 25);
            this.write_data.TabIndex = 13;
            this.write_data.Text = "Download Data";
            this.write_data.UseVisualStyleBackColor = true;
            this.write_data.Click += new System.EventHandler(this.write_data_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 371);
            this.Controls.Add(this.write_data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Reset_But);
            this.Controls.Add(this.Pause_But);
            this.Controls.Add(this.Lap_But);
            this.Controls.Add(this.Start_But);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.PercentageBar);
            this.Controls.Add(this.TimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button Pause_But;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer Remaining_Timer;
        private System.Windows.Forms.Timer Stopwatch_Timer;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button write_data;
    }
}

