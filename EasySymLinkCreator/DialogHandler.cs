using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ookii.Dialogs;

namespace EasySymLinkCreator
{
    public static class DialogHandler
    {
        private const string FILTER = "All |*.*";

        public static string OpenDirectoryDialogBox()
        {
            VistaFolderBrowserDialog folderDialog = new VistaFolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                return folderDialog.SelectedPath;
            }

            return string.Empty;
        }

        public static string OpenSaveFileDialogBox()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = FILTER;


            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return fileDialog.FileName;
            }

            return string.Empty;
        }

        public static string OpenSaveFolderDialogBox()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();


            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return fileDialog.FileName;
            }

            return string.Empty;
        }

        public static string OpenFileDialogBox()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = FILTER;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return fileDialog.FileName;
            }

            return string.Empty;
        }

    }
}
