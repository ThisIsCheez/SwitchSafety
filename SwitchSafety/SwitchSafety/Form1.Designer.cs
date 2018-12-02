namespace SwitchSafety
{
    partial class SwitchSafety
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwitchSafety));
            this.browseButton = new System.Windows.Forms.Button();
            this.browseBox = new System.Windows.Forms.TextBox();
            this.md5Label = new System.Windows.Forms.Label();
            this.md5Box = new System.Windows.Forms.TextBox();
            this.md5Progress = new System.Windows.Forms.ProgressBar();
            this.verifyButton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWork = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(268, 24);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // browseBox
            // 
            this.browseBox.Location = new System.Drawing.Point(12, 27);
            this.browseBox.Name = "browseBox";
            this.browseBox.Size = new System.Drawing.Size(250, 20);
            this.browseBox.TabIndex = 1;
            this.browseBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // md5Label
            // 
            this.md5Label.AutoSize = true;
            this.md5Label.Location = new System.Drawing.Point(12, 57);
            this.md5Label.Name = "md5Label";
            this.md5Label.Size = new System.Drawing.Size(33, 13);
            this.md5Label.TabIndex = 2;
            this.md5Label.Text = "MD5:";
            // 
            // md5Box
            // 
            this.md5Box.Location = new System.Drawing.Point(51, 54);
            this.md5Box.Name = "md5Box";
            this.md5Box.Size = new System.Drawing.Size(211, 20);
            this.md5Box.TabIndex = 3;
            this.md5Box.TextChanged += new System.EventHandler(this.md5Box_TextChanged);
            // 
            // md5Progress
            // 
            this.md5Progress.Location = new System.Drawing.Point(15, 83);
            this.md5Progress.Name = "md5Progress";
            this.md5Progress.Size = new System.Drawing.Size(328, 23);
            this.md5Progress.TabIndex = 4;
            // 
            // verifyButton
            // 
            this.verifyButton.Location = new System.Drawing.Point(268, 54);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(75, 23);
            this.verifyButton.TabIndex = 5;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = true;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // backgroundWork
            // 
            this.backgroundWork.WorkerReportsProgress = true;
            this.backgroundWork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWork_DoWork);
            this.backgroundWork.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWork_ProgressChanged);
            this.backgroundWork.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWork_RunWorkerCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(355, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SwitchSafety
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 115);
            this.Controls.Add(this.verifyButton);
            this.Controls.Add(this.md5Progress);
            this.Controls.Add(this.md5Box);
            this.Controls.Add(this.md5Label);
            this.Controls.Add(this.browseBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SwitchSafety";
            this.Text = "Switch Safety";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox browseBox;
        private System.Windows.Forms.Label md5Label;
        private System.Windows.Forms.TextBox md5Box;
        private System.Windows.Forms.ProgressBar md5Progress;
        private System.Windows.Forms.Button verifyButton;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.ComponentModel.BackgroundWorker backgroundWork;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

