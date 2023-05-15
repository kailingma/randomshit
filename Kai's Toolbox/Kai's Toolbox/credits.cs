using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kai_s_Toolbox;


namespace Kai_s_Toolbox
{

    public partial class credits : Form
    {

        public static string VersionFull = "Version " + Properties.Settings.Default.ReleaseType + " " + Properties.Settings.Default.Version;

        public credits()
        {
            InitializeComponent();
        }

        private void credits_Load(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public static int developerModeActivatorClicks = 0;


        private void label4_Click(object sender, EventArgs e)
        {
            if (developerModeActivatorClicks < 10)
            {
                developerModeActivatorClicks = developerModeActivatorClicks + 1;
            }
            else if (developerModeActivatorClicks == 10)
            {
                label4.Text = "Developer mode has been enabled!";
                kaistoolbox.developerModeEnabled = true;

            }
            // send between forms //
            // kaistoolbox.developerModeEnabled = true;
            // MessageBox.Show("developerModeEnabled = "+developerModeEnabled.ToString(), developerModeEnabled.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // version code below me //
            label4.Text = VersionFull;
        }
    }
}
