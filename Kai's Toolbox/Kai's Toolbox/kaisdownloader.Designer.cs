using System;

namespace Kais_Downloader_V3
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
            progressBar = new ProgressBar();
            btnDownload = new Button();
            txtUrl = new TextBox();
            lblStatus = new Label();
            label1 = new Label();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 393);
            progressBar.Margin = new Padding(4, 3, 4, 3);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(705, 33);
            progressBar.TabIndex = 0;
            progressBar.Click += progressBar_Click;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(629, 445);
            btnDownload.Margin = new Padding(4, 3, 4, 3);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(88, 38);
            btnDownload.TabIndex = 1;
            btnDownload.Text = "Start";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(12, 120);
            txtUrl.Margin = new Padding(4, 3, 4, 3);
            txtUrl.Multiline = true;
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(704, 254);
            txtUrl.TabIndex = 2;
            txtUrl.Text = resources.GetString("txtUrl.Text");
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(12, 451);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(32, 20);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "0%";
            lblStatus.Click += lblStatus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(603, 90);
            label1.TabIndex = 4;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
            // 
            // btnQuit
            // 
            btnQuit.DialogResult = DialogResult.Cancel;
            btnQuit.Location = new Point(519, 445);
            btnQuit.Margin = new Padding(4, 3, 4, 3);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(91, 38);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // kaisdownloader
            // 
            AcceptButton = btnDownload;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnQuit;
            ClientSize = new Size(724, 500);
            Controls.Add(btnQuit);
            Controls.Add(label1);
            Controls.Add(lblStatus);
            Controls.Add(txtUrl);
            Controls.Add(btnDownload);
            Controls.Add(progressBar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "kaisdownloader";
            Text = "Kai's Downloader";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuit;
    }
}

