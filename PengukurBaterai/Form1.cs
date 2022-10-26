using System.Diagnostics;

namespace PengukurBaterai
{
    public partial class Form1 : Form
    {
        public Form1()
        {InitializeComponent();}

        private void SisaWaktu_Tick(object sender, EventArgs e)
        {
            PowerStatus ps = SystemInformation.PowerStatus;

            PercentageBar.Value = (int)(ps.BatteryLifePercent * 100);
            if (ps.BatteryLifeRemaining < 0)
                TimeLabel.Text = "Remaining Time = Unknown !!";
            else
                TimeLabel.Text = "Remaining Time = " + new TimeSpan(0, 0, ps.BatteryLifeRemaining);
                Percentage.Text = ps.BatteryLifePercent.ToString("P");
        } 

    }
}