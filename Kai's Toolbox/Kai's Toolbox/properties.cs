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
    public partial class properties : Form
    {
        public static bool devPropertiesPageAdded = true;

        public properties()
        {
            InitializeComponent();
            this.tabPage2.Hide();
            tabControl1.TabPages.Remove(tabPage2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kaistoolbox.developerModeEnabled == true)
            {
                if (devPropertiesPageAdded == false)
                {
                    tabControl1.TabPages.Insert(2, tabPage2);
                    this.tabPage2.Show();
                    devPropertiesPageAdded = true;
                }
                
                
            }
        }
    }
}
