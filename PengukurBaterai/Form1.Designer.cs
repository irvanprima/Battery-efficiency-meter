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
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LabelHour = new System.Windows.Forms.Label();
            this.LabelSecond = new System.Windows.Forms.Label();
            this.LabelMinute = new System.Windows.Forms.Label();
            this.StartBTN = new System.Windows.Forms.Button();
            this.StopBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PercentageBar
            // 
            this.PercentageBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PercentageBar.Location = new System.Drawing.Point(17, 62);
            this.PercentageBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PercentageBar.Name = "PercentageBar";
            this.PercentageBar.Size = new System.Drawing.Size(809, 36);
            this.PercentageBar.TabIndex = 0;
            // 
            // Percentage
            // 
            this.Percentage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Percentage.Location = new System.Drawing.Point(836, 62);
            this.Percentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(99, 36);
            this.Percentage.TabIndex = 1;
            this.Percentage.Text = "0%";
            this.Percentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TimeLabel.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.Location = new System.Drawing.Point(17, 15);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(359, 40);
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
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 262);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(18, 308);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(397, 129);
            this.listBox1.TabIndex = 10;
            // 
            // LabelHour
            // 
            this.LabelHour.AutoSize = true;
            this.LabelHour.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelHour.Location = new System.Drawing.Point(111, 149);
            this.LabelHour.Name = "LabelHour";
            this.LabelHour.Size = new System.Drawing.Size(67, 54);
            this.LabelHour.TabIndex = 11;
            this.LabelHour.Text = "00";
            this.LabelHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelSecond
            // 
            this.LabelSecond.AutoSize = true;
            this.LabelSecond.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelSecond.Location = new System.Drawing.Point(257, 149);
            this.LabelSecond.Name = "LabelSecond";
            this.LabelSecond.Size = new System.Drawing.Size(67, 54);
            this.LabelSecond.TabIndex = 13;
            this.LabelSecond.Text = "00";
            this.LabelSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelMinute
            // 
            this.LabelMinute.AutoSize = true;
            this.LabelMinute.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelMinute.Location = new System.Drawing.Point(184, 149);
            this.LabelMinute.Name = "LabelMinute";
            this.LabelMinute.Size = new System.Drawing.Size(67, 54);
            this.LabelMinute.TabIndex = 14;
            this.LabelMinute.Text = "00";
            this.LabelMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartBTN
            // 
            this.StartBTN.Location = new System.Drawing.Point(17, 220);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(195, 38);
            this.StartBTN.TabIndex = 15;
            this.StartBTN.Text = "Start";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.Start_Click);
            // 
            // StopBTN
            // 
            this.StopBTN.Location = new System.Drawing.Point(220, 221);
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.Size = new System.Drawing.Size(195, 37);
            this.StopBTN.TabIndex = 16;
            this.StopBTN.Text = "Stop";
            this.StopBTN.UseVisualStyleBackColor = true;
            this.StopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 480);
            this.Controls.Add(this.StopBTN);
            this.Controls.Add(this.StartBTN);
            this.Controls.Add(this.LabelMinute);
            this.Controls.Add(this.LabelSecond);
            this.Controls.Add(this.LabelHour);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.PercentageBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProgressBar PercentageBar;
        private Label Percentage;
        private Label TimeLabel;
        private System.Windows.Forms.Timer TimeLeft;
        private System.Windows.Forms.Timer Timer1;
        private Button button1;
        private ListBox listBox1;
        private Label LabelHour;
        private Label LabelSecond;
        private Label LabelMinute;
        private Button StartBTN;
        private Button StopBTN;
    }
}