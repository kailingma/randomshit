namespace Kai_s_Toolbox
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            toolStripButton1 = new ToolStripDropDownButton();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 272);
            button1.Name = "button1";
            button1.Size = new Size(288, 112);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
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
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripDropDownButton2, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(620, 25);
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
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(38, 22);
            toolStripDropDownButton2.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
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
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(180, 22);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 411);
            Controls.Add(toolStrip1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
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
    }
}