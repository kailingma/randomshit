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


namespace Kai_s_Toolbox
{

    public partial class credits : Form
    {

        public int developerModeClicks;
        public bool developerModeEnabled;

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

        private void label4_Click(object sender, EventArgs e)
        {

            if (developerModeClicks < 10)
            {
                developerModeClicks = developerModeClicks + 1;


            }
            else if (developerModeClicks == 10)
            {
                MessageBox.Show("You are now a developer!!", developerModeEnabled.ToString());
            }
            else
                MessageBox.Show("hmmm... something happened. let's try that again.", "Uh Oh!!! :(");

        }
    }
}
