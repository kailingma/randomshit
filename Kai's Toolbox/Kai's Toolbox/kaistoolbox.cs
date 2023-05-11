using Kais_Downloader_V3;

namespace Kai_s_Toolbox
{
    public partial class kaistoolbox : Form
    {
        public string CloseReason { get; private set; }

        public kaistoolbox()
        {
            InitializeComponent();
            var developerModeEnabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // The kai's downloader button //
            kaisfoldersync objUI = new kaisfoldersync();
            objUI.ShowDialog();
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
            credits objUI = new credits();
            objUI.ShowDialog();
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Folder sync btn //
            kaisfoldersync objUI = new kaisfoldersync();
            objUI.ShowDialog();
        }
    }
}