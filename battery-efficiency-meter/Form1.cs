using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace battery_efficiency_meter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            PowerStatus ps = SystemInformation.PowerStatus;

            PercentageBar.Value = (int)(ps.BatteryLifePercent * 100);
            if (ps.BatteryLifeRemaining < 0)
                TimeLabel.Text = "Charging";
            else
                TimeLabel.Text = "Remaining Time = " + new TimeSpan(0 , 0 , ps.BatteryLifeRemaining);
                Percentage.Text = string.Format($"{ps.BatteryLifePercent * 100} %");            
        }

        //Stopwatch
        //Chart
        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        //int A = 1;
        int B = 1;  
        private void Start_But_Click(object sender, EventArgs e)
        {
            Lap_But.Enabled = true;
            if (B == 1)
            {
                //
                Stopwatch_Timer.Start();
                stopwatch.Start();
                //
                PowerStatus ps = SystemInformation.PowerStatus;
                //int = ayam;
                listBox2.Items.Add(B++ + ".  " + lbl_Time.Text + " =   " + Percentage.Text);

                var batteryLifePercent = Convert.ToInt32(ps.BatteryLifePercent);
                chart1.Series["battery"].Points.AddXY(num, ps.BatteryLifePercent * 100);
                //
                //Start_But.Enabled = false;
                //listBox2 = null;
                
            }
            else
            {
                Stopwatch_Timer.Start();
                stopwatch.Start();
                
            }
            Start_But.Enabled = false;

        }
        private void Stopwatch_Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan Lap = stopwatch.Elapsed;
            lbl_Time.Text = string.Format("{0:00} : {1:00} : {2:00} : {3:00}",
                Math.Floor(Lap.TotalHours), Lap.Minutes, Lap.Seconds, Lap.Milliseconds);
        }
        int num = 0;
        //public object BatteryLifePercent { get; private set; }
        int num2 =+ 2;
        private void Lap_But_Click(object sender, EventArgs e)
        {
            PowerStatus ps = SystemInformation.PowerStatus;
            //num +=1;
            listBox1.Items.Add(num2++ + ".  " + lbl_Time.Text + " =   " + Percentage.Text);

            var batteryLifePercent = Convert.ToInt32(ps.BatteryLifePercent);            
            chart1.Series["battery"].Points.AddXY(num,ps.BatteryLifePercent * 100);
        }
        

        //stop but = pause
        private void Stop_But_Click(object sender, EventArgs e)
        {
            Stopwatch_Timer.Stop();
            stopwatch.Stop();
            //Start_But.Enabled= false;
            Start_But.Enabled = true;
            //listBox2.Enabled = false;
        }

        private void Reset_But_Click(object sender, EventArgs e)
        {
            string message = "Are you sure want to reset this record?";
            string title = "Reset all record battery";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                stopwatch.Reset();
                lbl_Time.Text = "00 : 00 : 00 : 000";
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                num = 0;
                num2 = 2;
                //A = 1;
                Lap_But.Enabled = false;
                B = 1;
                chart1.Series["battery"].Points.Clear();
                Start_But.Enabled = true;
                Reset_But.Enabled = false;
            }
            else
            {
                //do nothing
            }
        }

        private void write_data_Click(object sender, EventArgs e)
        {
            //otomatis pause saat akan download data dan button pause = false
            Stopwatch_Timer.Stop();
            stopwatch.Stop();            
            Start_But.Enabled = true;
            Pause_But.Enabled = false;


            // Data yang akan ditulis ke file CSV
            string data1 = lbl_Time.Text;
            string data2 = Percentage.Text;


            // Gabungkan data1 dan data2 dengan menambahkan koma sebagai pemisah
            //string data = data1 + "," + data2;

            // Buat objek SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Atur filter untuk hanya menampilkan file CSV
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";

            // Atur default extension untuk file CSV
            saveFileDialog.DefaultExt = "csv";

            // Atur title dari file explorer
            saveFileDialog.Title = "Save data to CSV file";

            // Tampilkan file explorer dan simpan file jika pengguna memilih file dan mengklik tombol Save
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Buka file CSV untuk menulis
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    // Tulis baris ke file CSV
                    //sw.WriteLine(data);
                    //sw.Write(data1 + ",");
                    //sw.WriteLine(data2);
                    //sw.WriteLine(data1 + "," + data2);
                    //sw.WriteLine(data1 + data2);                    
                    //sw.WriteLine(data1 + "," + data2);
                    
                    sw.WriteLine("Start Record :");
                    foreach (object item in listBox2.Items)
                    {
                        // Tulis baris ke file CSV
                        
                        sw.WriteLine(item + "\n"); 
                    }

                    sw.WriteLine("Record Result :");
                    foreach (object item in listBox1.Items)
                    {
                        // Tulis baris ke file CSV                        
                        sw.WriteLine(item);
                    }



                }
            }
        }

        
    }

}
