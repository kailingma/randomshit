using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kais_Downloader_V3
{
    public partial class kaisfoldersync : Form
    {
        public kaisfoldersync()
        {
            InitializeComponent();
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select folder..." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    List<string> list = new List<string>(txtUrl.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
                    foreach (string url in list)
                    {
                        using (WebClient client = new WebClient())
                        {
                            progressBar.Value = 0;
                            client.Credentials = CredentialCache.DefaultNetworkCredentials;
                            client.DownloadProgressChanged += Wc_DownloadProgressChanged;
                            Uri uri = new Uri(url);
                            string filename = System.IO.Path.GetFileName(uri.LocalPath);
                            await client.DownloadFileTaskAsync(uri,
                                $"{fbd.SelectedPath}\\{filename}"
                            );
                        }
                    }
                    MessageBox.Show("You have finished downloading the file(s).", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            progressBar.Update();
            lblStatus.Invoke((MethodInvoker)(() => lblStatus.Text = $"{e.ProgressPercentage}%"));
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
