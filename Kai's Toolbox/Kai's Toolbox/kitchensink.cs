using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kai_s_Toolbox
{
    public partial class kitchensink : Form
    {
        public static bool developerModeTestEnabled = false;
        public kitchensink()
        {
            InitializeComponent();
            this.tabPage3.Hide();
            tabControl1.TabPages.Remove(tabPage3);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (developerModeTestEnabled == true)
            {
                tabControl1.TabPages.Insert(2, tabPage3);
                this.tabPage3.Show();

            }
            else
            {
                this.tabPage3.Hide();
                tabControl1.TabPages.Remove(tabPage3);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            developerModeTestEnabled = true;
            tabControl1.TabPages.Insert(2, tabPage3);
            this.tabPage3.Show();
        }
    }
}
