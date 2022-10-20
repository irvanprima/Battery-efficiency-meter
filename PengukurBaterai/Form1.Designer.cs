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
            this.ProgresBaterai = new System.Windows.Forms.ProgressBar();
            this.Persentase = new System.Windows.Forms.Label();
            this.LabelSisaWaktu = new System.Windows.Forms.Label();
            this.SisaWaktu = new System.Windows.Forms.Timer(this.components);
            this.Button1 = new System.Windows.Forms.Button();
            this.Hasil_Rekaman = new System.Windows.Forms.ListBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProgresBaterai
            // 
            this.ProgresBaterai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgresBaterai.Location = new System.Drawing.Point(17, 62);
            this.ProgresBaterai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProgresBaterai.Name = "ProgresBaterai";
            this.ProgresBaterai.Size = new System.Drawing.Size(808, 38);
            this.ProgresBaterai.TabIndex = 0;
            // 
            // Persentase
            // 
            this.Persentase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Persentase.Location = new System.Drawing.Point(836, 62);
            this.Persentase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Persentase.Name = "Persentase";
            this.Persentase.Size = new System.Drawing.Size(99, 38);
            this.Persentase.TabIndex = 1;
            this.Persentase.Text = "0%";
            this.Persentase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelSisaWaktu
            // 
            this.LabelSisaWaktu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelSisaWaktu.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelSisaWaktu.Location = new System.Drawing.Point(17, 15);
            this.LabelSisaWaktu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSisaWaktu.Name = "LabelSisaWaktu";
            this.LabelSisaWaktu.Size = new System.Drawing.Size(412, 42);
            this.LabelSisaWaktu.TabIndex = 2;
            this.LabelSisaWaktu.Text = "Sisa waktu pemakaian = 00 : 00 : 00";
            this.LabelSisaWaktu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SisaWaktu
            // 
            this.SisaWaktu.Enabled = true;
            this.SisaWaktu.Interval = 1000;
            this.SisaWaktu.Tick += new System.EventHandler(this.SisaWaktu_Tick);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(17, 182);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(808, 38);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "Mulai ";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.UseWaitCursor = true;
            
            // 
            // Hasil_Rekaman
            // 
            this.Hasil_Rekaman.FormattingEnabled = true;
            this.Hasil_Rekaman.ItemHeight = 25;
            this.Hasil_Rekaman.Items.AddRange(new object[] {
            " "});
            this.Hasil_Rekaman.Location = new System.Drawing.Point(17, 280);
            this.Hasil_Rekaman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Hasil_Rekaman.Name = "Hasil_Rekaman";
            this.Hasil_Rekaman.Size = new System.Drawing.Size(808, 154);
            this.Hasil_Rekaman.TabIndex = 5;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(17, 230);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(397, 38);
            this.Button2.TabIndex = 6;
            this.Button2.Text = "Lap";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(243, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 49);
            this.label1.TabIndex = 8;
            this.label1.Text = "00 : 00 : 00 : 00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(430, 230);
            this.Button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(395, 38);
            this.Button3.TabIndex = 9;
            this.Button3.Text = "Reset";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 482);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Hasil_Rekaman);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.LabelSisaWaktu);
            this.Controls.Add(this.Persentase);
            this.Controls.Add(this.ProgresBaterai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private ProgressBar ProgresBaterai;
        private Label Persentase;
        private Label LabelSisaWaktu;
        private System.Windows.Forms.Timer SisaWaktu;
        private Button Button1;
        private ListBox Hasil_Rekaman;
        private Button Button2;
        private Label label1;
        private System.Windows.Forms.Timer Timer;
        private Button Button3;
    }
}