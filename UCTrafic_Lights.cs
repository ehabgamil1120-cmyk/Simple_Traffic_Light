using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Trafic_Lights_Project
{
    public partial class UCTrafic_Lights : UserControl
    {

        public UCTrafic_Lights()
        {
            InitializeComponent();
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void UCTrafic_Lights_Load(object sender, EventArgs e)
        {
        }

        public async void Start_Traffic_Lights(bool Case,short RedTime,short YellowTime,short GreenTime)
        {
          

            while (Case)
            {

                lbTimer.ForeColor = Color.Red;
                pictureBox1.Image = Properties.Resources.Red;
                for (int i = RedTime; i > 0; i--)
                {
            
                    lbTimer.Text = i.ToString();
                    await Task.Delay(1100);
                }




                pictureBox1.Image = Properties.Resources.Orange;
                lbTimer.ForeColor = Color.Orange;
                for (int i = YellowTime; i > 0; i--)
                {
        
                    lbTimer.Text = i.ToString();
                    await Task.Delay(1100);
                }




                pictureBox1.Image = Properties.Resources.Green1;
                lbTimer.ForeColor = Color.Green;
                for (int i = GreenTime; i > 0; i--)
                { 
          
                    lbTimer.Text = i.ToString();
                    await Task.Delay(1100);
                }


            }
        }

        private void lbTimer_Click(object sender, EventArgs e)
        {

        }
    }

}
