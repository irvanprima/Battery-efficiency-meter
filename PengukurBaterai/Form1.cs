using System.Diagnostics;

namespace PengukurBaterai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   
        }

        private void SisaWaktu_Tick(object sender, EventArgs e)
        {
            PowerStatus ps = SystemInformation.PowerStatus;

            PercentageBar.Value = (int)(ps.BatteryLifePercent * 100);
            if (ps.BatteryLifeRemaining < 0)
                TimeLabel.Text = "Remaining Time = Unknown !!";
            else
                TimeLabel.Text = "Remaining Time = " + new TimeSpan(0 , 0 , ps.BatteryLifeRemaining);
                Percentage.Text = ps.BatteryLifePercent.ToString("P");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int second;
        int minute;
        int hour;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            second++;

            if (second > 59)
            {
                minute++;
                second = 0;
            }

            if (minute > 59)
            {
                hour++;
                minute = 0;
            }
            LabelHour.Text = hour.ToString();
            LabelMinute.Text = minute.ToString();
            LabelSecond.Text = second.ToString();
        }

        private string appendZero(double str)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            Timer1.Start();
        }

        private void StopBTN_Click(object sender, EventArgs e)
        {
            Timer1.Stop();
        }
    }
}