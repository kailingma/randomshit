namespace Kai_s_Toolbox
{
    partial class kaistoolbox
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kaistoolbox));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton2 = new ToolStripDropDownButton();
            kaisToolboxToolStripMenuItem = new ToolStripMenuItem();
            kaisDownloaderToolStripMenuItem = new ToolStripMenuItem();
            kaisFolderSyncToolStripMenuItem = new ToolStripMenuItem();
            theKitchenSinkToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton1 = new ToolStripDropDownButton();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            lblTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button5 = new Button();
            toolStripSeparator1 = new ToolStripSeparator();
            propertiesToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(12, 272);
            button1.Name = "button1";
            button1.Size = new Size(288, 112);
            button1.TabIndex = 0;
            button1.Text = "The kitchen sink";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(320, 272);
            button2.Name = "button2";
            button2.Size = new Size(288, 112);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 140);
            button3.Name = "button3";
            button3.Size = new Size(288, 112);
            button3.TabIndex = 2;
            button3.Text = "Kai's Downloader";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(320, 140);
            button4.Name = "button4";
            button4.Size = new Size(288, 112);
            button4.TabIndex = 3;
            button4.Text = "Kai's Folder Sync";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(191, 35);
            label1.Name = "label1";
            label1.Size = new Size(253, 50);
            label1.TabIndex = 4;
            label1.Text = "Kai's Toolbox";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 86);
            label2.Name = "label2";
            label2.Size = new Size(441, 30);
            label2.TabIndex = 5;
            label2.Text = "Welcome to Kai's Toolbox!\r\nThis application compiles some of my previous small projects into one big project.";
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripDropDownButton2, toolStripButton2, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(623, 25);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(0, 22);
            toolStripLabel1.Click += toolStripLabel1_Click;
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem, toolStripSeparator1, propertiesToolStripMenuItem });
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(38, 22);
            toolStripDropDownButton2.Text = "File";
            toolStripDropDownButton2.Click += toolStripDropDownButton2_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.DropDownItems.AddRange(new ToolStripItem[] { kaisToolboxToolStripMenuItem, kaisDownloaderToolStripMenuItem, kaisFolderSyncToolStripMenuItem, theKitchenSinkToolStripMenuItem });
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(64, 22);
            toolStripButton2.Text = "Window";
            // 
            // kaisToolboxToolStripMenuItem
            // 
            kaisToolboxToolStripMenuItem.Name = "kaisToolboxToolStripMenuItem";
            kaisToolboxToolStripMenuItem.Size = new Size(165, 22);
            kaisToolboxToolStripMenuItem.Text = "Kai's Toolbox";
            // 
            // kaisDownloaderToolStripMenuItem
            // 
            kaisDownloaderToolStripMenuItem.Name = "kaisDownloaderToolStripMenuItem";
            kaisDownloaderToolStripMenuItem.Size = new Size(165, 22);
            kaisDownloaderToolStripMenuItem.Text = "Kai's Downloader";
            // 
            // kaisFolderSyncToolStripMenuItem
            // 
            kaisFolderSyncToolStripMenuItem.Name = "kaisFolderSyncToolStripMenuItem";
            kaisFolderSyncToolStripMenuItem.Size = new Size(165, 22);
            kaisFolderSyncToolStripMenuItem.Text = "Kai's Folder Sync";
            // 
            // theKitchenSinkToolStripMenuItem
            // 
            theKitchenSinkToolStripMenuItem.Name = "theKitchenSinkToolStripMenuItem";
            theKitchenSinkToolStripMenuItem.Size = new Size(165, 22);
            theKitchenSinkToolStripMenuItem.Text = "The Kitchen Sink";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.DropDownItems.AddRange(new ToolStripItem[] { helpToolStripMenuItem, aboutToolStripMenuItem });
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(45, 22);
            toolStripButton1.Text = "Help";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Enabled = false;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.ShortcutKeyDisplayString = "F1";
            helpToolStripMenuItem.Size = new Size(118, 22);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(118, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(542, 25);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(34, 15);
            lblTime.TabIndex = 8;
            lblTime.Text = "00:00";
            lblTime.Click += lblTime_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // button5
            // 
            button5.Location = new Point(468, 86);
            button5.Name = "button5";
            button5.Size = new Size(140, 30);
            button5.TabIndex = 9;
            button5.Text = "Enable Developer Mode";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            propertiesToolStripMenuItem.Size = new Size(180, 22);
            propertiesToolStripMenuItem.Text = "Properties";
            propertiesToolStripMenuItem.Click += propertiesToolStripMenuItem_Click;
            // 
            // kaistoolbox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 411);
            Controls.Add(button5);
            Controls.Add(lblTime);
            Controls.Add(toolStrip1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "kaistoolbox";
            Text = "Kai's Toolbox";
            Load += kaistoolbox_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripDropDownButton toolStripButton1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripDropDownButton toolStripButton2;
        private ToolStripMenuItem kaisToolboxToolStripMenuItem;
        private ToolStripMenuItem kaisDownloaderToolStripMenuItem;
        private Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem kaisFolderSyncToolStripMenuItem;
        private ToolStripMenuItem theKitchenSinkToolStripMenuItem;
        private Button button5;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem propertiesToolStripMenuItem;
    }
}