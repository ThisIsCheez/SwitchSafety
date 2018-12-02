using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace SwitchSafety
{
    public partial class SwitchSafety : Form
    {
        public SwitchSafety()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                browseBox.Text = openFile.FileName;
            }
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            md5Box.Text = "";
            backgroundWork.RunWorkerAsync(browseBox.Text);
        }

        private void backgroundWork_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = e.Argument.ToString();

            byte[] buffer;
            int bytesRead;
            long size;
            long totalBytesRead = 0;

            using (Stream file = File.OpenRead(filePath))
            {
                size = file.Length;

                using (HashAlgorithm hasher = MD5.Create())
                {
                    do
                    {
                        buffer = new byte[4096];

                        bytesRead = file.Read(buffer, 0, buffer.Length);

                        totalBytesRead += bytesRead;

                        hasher.TransformBlock(buffer, 0, bytesRead, null, 0);

                        backgroundWork.ReportProgress((int)((double)totalBytesRead / size * 100));
                    }
                    while (bytesRead != 0);

                    hasher.TransformFinalBlock(buffer, 0, 0);

                    e.Result = MakeHashString(hasher.Hash);
                }
            }
        }

        private static string MakeHashString(byte[] hashBytes)
        {
            StringBuilder hash = new StringBuilder(32);

            foreach (byte b in hashBytes)
                hash.Append(b.ToString("X2").ToLower());

            return hash.ToString();
        }

        private void backgroundWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            md5Progress.Value = e.ProgressPercentage;
        }

        private void backgroundWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            md5Box.Text = e.Result.ToString();

            WebClient wc = new WebClient();
            wc.DownloadFile("https://raw.githubusercontent.com/ThisIsCheez/SwitchSafety/master/SwitchMD5.txt", "SwitchMD5.txt");

            string readText = File.ReadAllText("SwitchMD5.txt");
            if (readText.Contains(md5Box.Text))
                MessageBox.Show("Your file is safe!", "Verified", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("MD5 not found. Your file may not be safe.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                md5Progress.Value = 0;
        }

        private void md5Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("v0.02b - Created by Cheez");
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ThisIsCheez/SwitchSafety/");
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
