using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Ookii.Dialogs;

namespace EasySymLinkCreator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectPath_Click(object sender, EventArgs e)
        {
            TextBox pathBox = this.TargetPath;
            bool isTarget = true;

            if (sender == this.SelectLinkPath)
            {
                pathBox = this.LinkPath;
                isTarget = false;
            }

            pathBox.Text = this.SelectPath(isTarget);
        }

        private string SelectPath(bool isTarget)
        {
            string path = string.Empty;

            if (this.IsDirectory.Checked)
            {
                if (isTarget)
                {
                    path = DialogHandler.OpenDirectoryDialogBox();
                }
                else
                {
                    path = DialogHandler.OpenSaveFolderDialogBox();
                }
            }
            else
            {
                if (isTarget)
                {
                    path = DialogHandler.OpenFileDialogBox();
                }
                else
                {
                    path = DialogHandler.OpenSaveFileDialogBox();
                }
            }

            return path;            
        }

        private void CreateLink_Click(object sender, EventArgs e)
        {
            string symLinkParameter = string.Empty;

            if (this.IsDirectory.Checked)
            {
                if (this.IsHard.Checked)
                {
                    symLinkParameter = "/j";
                }
                else
                {
                    symLinkParameter = "/d";
                }
            }
            else if (!this.IsDirectory.Checked && this.IsHard.Checked)
            {
                symLinkParameter = "/h";
            }

            Process process = new Process();
            process.StartInfo = new ProcessStartInfo("cmd", $"/c mklink {symLinkParameter} \"{this.LinkPath.Text}\" \"{this.TargetPath.Text}\"");
            process.Start();
        }

        private void About_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }
    }
}
