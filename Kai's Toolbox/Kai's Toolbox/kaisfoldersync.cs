using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kai_s_Folder_Syncer
{
    public partial class kaisfoldersync : Form
    {
        public kaisfoldersync()
        {
            InitializeComponent();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            // message box 1 source
            MessageBox.Show("First select your source folder");
            // Using the folder browser dialog thingymabob
            using (FolderBrowserDialog fbdSource = new FolderBrowserDialog() { Description = "Select source folder..." })
            {
                if (fbdSource.ShowDialog() == DialogResult.OK)
                {
                    // Message box 2 target
                    MessageBox.Show("Now select your target folder");
                    using (FolderBrowserDialog fbdTarget = new FolderBrowserDialog() { Description = "Select target folder..." })
                    {
                        if (fbdTarget.ShowDialog() == DialogResult.OK)
                        {
                            // folder copying
                            if (System.IO.Directory.Exists(fbdTarget.SelectedPath)) ;
                            {
                                string[] files = System.IO.Directory.GetFiles(fbdSource.SelectedPath);

                                // Copy the files and overwrite destination files if they already exist.
                                foreach (string s in files)
                                {
                                    // Use static Path methods to extract only the file name from the path.
                                    string fileName = System.IO.Path.GetFileName(s);
                                    string destFile = System.IO.Path.Combine(fbdTarget.SelectedPath, fileName);
                                    System.IO.File.Copy(s, destFile, true);
                                    // Message box!
                                    MessageBox.Show("Done Copying!");
                                }
                            }
                        }
                    }
                }



            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
