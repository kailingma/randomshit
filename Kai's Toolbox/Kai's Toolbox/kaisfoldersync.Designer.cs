namespace Kai_s_Folder_Syncer
{
    partial class kaisfoldersync
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kaisfoldersync));
            btnSync = new Button();
            btnQuit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSync
            // 
            btnSync.Location = new Point(353, 209);
            btnSync.Margin = new Padding(4, 3, 4, 3);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(88, 32);
            btnSync.TabIndex = 0;
            btnSync.Text = "&Sync";
            btnSync.UseVisualStyleBackColor = true;
            btnSync.Click += btnSync_Click;
            // 
            // btnQuit
            // 
            btnQuit.DialogResult = DialogResult.Cancel;
            btnQuit.Location = new Point(256, 209);
            btnQuit.Margin = new Padding(4, 3, 4, 3);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(88, 32);
            btnQuit.TabIndex = 1;
            btnQuit.Text = "Q&uit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(375, 135);
            label1.TabIndex = 2;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
            // 
            // kaisfoldersync
            // 
            AcceptButton = btnSync;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnQuit;
            ClientSize = new Size(454, 253);
            Controls.Add(label1);
            Controls.Add(btnQuit);
            Controls.Add(btnSync);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "kaisfoldersync";
            Text = "Kai's Folder Syncer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label1;
    }
}

