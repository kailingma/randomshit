using Kais_Downloader_V3;

namespace Kai_s_Toolbox
{
    public partial class kaistoolbox : Form
    {
        public string CloseReason { get; private set; }

        public kaistoolbox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kaisdownloader objUI = new kaisdownloader();
            objUI.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

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
    }
}