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

            ProgresBaterai.Value = (int)(ps.BatteryLifePercent * 100);
            if (ps.BatteryLifeRemaining < 0)
                LabelSisaWaktu.Text = "Sisa waktu pemakaian = Tidak Diketahui !!";
            else
                LabelSisaWaktu.Text = "Sisa waktu pemakaian = " + new TimeSpan(0, 0, ps.BatteryLifeRemaining);
                Persentase.Text = ps.BatteryLifePercent.ToString("P");
        }

       



        
    }
}