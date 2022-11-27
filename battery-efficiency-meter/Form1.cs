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
                TimeLabel.Text = "Remaining Time = " + new TimeSpan(0 , 0 , 0, ps.BatteryLifeRemaining);
                Percentage.Text = string.Format($"{ps.BatteryLifePercent * 100} %");            
        }


    }

}
