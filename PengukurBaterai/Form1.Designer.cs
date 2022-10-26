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
            this.StartRecord = new System.Windows.Forms.Button();
            this.Hasil_Rekaman = new System.Windows.Forms.ListBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PercentageBar
            // 
            this.PercentageBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PercentageBar.Location = new System.Drawing.Point(12, 37);
            this.PercentageBar.Name = "PercentageBar";
            this.PercentageBar.Size = new System.Drawing.Size(566, 23);
            this.PercentageBar.TabIndex = 0;
            // 
            // Percentage
            // 
            this.Percentage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Percentage.Location = new System.Drawing.Point(585, 37);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(69, 23);
            this.Percentage.TabIndex = 1;
            this.Percentage.Text = "0%";
            this.Percentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TimeLabel.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.Location = new System.Drawing.Point(12, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(238, 25);
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
            // StartRecord
            // 
            this.StartRecord.Location = new System.Drawing.Point(12, 109);
            this.StartRecord.Name = "StartRecord";
            this.StartRecord.Size = new System.Drawing.Size(566, 23);
            this.StartRecord.TabIndex = 3;
            this.StartRecord.Text = "Start Record";
            this.StartRecord.UseVisualStyleBackColor = true;
            this.StartRecord.UseWaitCursor = true;
            // 
            // Hasil_Rekaman
            // 
            this.Hasil_Rekaman.FormattingEnabled = true;
            this.Hasil_Rekaman.ItemHeight = 15;
            this.Hasil_Rekaman.Items.AddRange(new object[] {
            " "});
            this.Hasil_Rekaman.Location = new System.Drawing.Point(12, 168);
            this.Hasil_Rekaman.Name = "Hasil_Rekaman";
            this.Hasil_Rekaman.Size = new System.Drawing.Size(567, 94);
            this.Hasil_Rekaman.TabIndex = 5;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(12, 138);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(278, 23);
            this.Stop.TabIndex = 6;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.UseWaitCursor = true;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(301, 138);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(276, 23);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(170, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "00 : 00 : 00 : 00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 289);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Hasil_Rekaman);
            this.Controls.Add(this.StartRecord);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.PercentageBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private ProgressBar PercentageBar;
        private Label Percentage;
        private Label TimeLabel;
        private System.Windows.Forms.Timer TimeLeft;
        private Button StartRecord;
        private ListBox Hasil_Rekaman;
        private Button Stop;
        private System.Windows.Forms.Timer Timer;
        private Button Reset;
        private Label label1;
    }
}