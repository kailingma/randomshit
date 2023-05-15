using Kai_s_Folder_Syncer;
using Kais_Downloader_V3;

namespace Kai_s_Toolbox
{
    public partial class kaistoolbox : Form
    {
        public string CloseReason { get; private set; }

        public static bool developerModeEnabled = false;

        public kaistoolbox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // kitchen sink btn //
            kitchensink kSink = new();
            kSink.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // The kai's downloader button //
            kaisdownloader kDownloader = new();
            kDownloader.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            credits creditsForm = new credits();
            creditsForm.Show();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void kaistoolbox_Load(object sender, EventArgs e)
        {
            // update date and time on load //
            lblTime.Text = DateTime.Now.ToLongTimeString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // update date and time every "tick" //
            lblTime.Text = DateTime.Now.ToLongTimeString();
            // check for developer mode//
            if (developerModeEnabled == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            // enable or disable the enable dev mode button //
            if (Properties.Settings.Default.DeveloperRelease == true)
            {
                button5.Visible = true;
            }
            else
            {
                button5.Visible = false;
            }
            //  //

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Folder sync btn //
            kaisfoldersync syncForm = new();
            syncForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            developerModeEnabled = true;
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            properties propertiesDialog = new();
            propertiesDialog.ShowDialog();
        }
    }
}