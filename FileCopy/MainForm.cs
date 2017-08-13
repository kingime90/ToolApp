using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FileCopy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                tbFolderPath.Text = folder.SelectedPath;
            }
        }

        private void btnFindFileType_Click(object sender, EventArgs e)
        {
            string folderPath = tbFolderPath.Text.Trim();
            if (string.IsNullOrWhiteSpace(folderPath))
            {
                MessageBox.Show("请选择文件夹！", "温馨提示！");
                return;
            }
            //
            var fileList = new List<string>();
            GetAllFile(folderPath, fileList);
            var extensionList = new List<string>();
            string extensionName;
            foreach (var file in fileList)
            {
                extensionName = Path.GetExtension(file).ToLower();
                if (extensionName.Length == 0 || extensionList.Contains(extensionName)) continue;
                //
                extensionList.Add(extensionName);
            }
            rtbContent.Text = string.Join("\n", extensionList);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="fileList"></param>
        private void GetAllFile(string folderPath, IList<string> fileList)
        {
            string[] folders = Directory.GetDirectories(folderPath);//得到所有子目录
            foreach (string folder in folders)
            {
                GetAllFile(folder, fileList);//对每一个字目录做与根目录相同的操作：即找到子目录并将当前目录的文件名存入List
            }
            string[] files = Directory.GetFiles(folderPath);
            foreach (string file in files)
            {
                fileList.Add(file);//将当前目录中的所有文件全名存入文件List
            }
        }

        private void btnSelect2_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                tbFolderPath2.Text = folder.SelectedPath;
            }
        }

        private void btnCoptFile_Click(object sender, EventArgs e)
        {
            string folderPath = tbFolderPath.Text.Trim();
            if (string.IsNullOrWhiteSpace(folderPath))
            {
                MessageBox.Show("请选择文件夹！", "温馨提示！");
                return;
            }
            //
            string folderPath2 = tbFolderPath2.Text.Trim();
            if (string.IsNullOrWhiteSpace(folderPath2))
            {
                MessageBox.Show("请选择复制文件夹！", "温馨提示！");
                return;
            }
            //
            var extensions = new Dictionary<string, string>()
            {
                
            };
            var thread = new Thread(() =>
            {
                CopyFile(folderPath, folderPath2, folderPath, extensions);
                MessageBox.Show("复制文件夹成功！", "温馨提示！");
            });
            thread.Start();
        }

        private void CopyFile(string fromPath, string copyFolderPath, string folderPath, Dictionary<string, string> extensions)
        {
            string[] folders = Directory.GetDirectories(folderPath);//得到所有子目录
            string newFolder;
            foreach (string folder in folders)
            {
                newFolder = folder.Replace(fromPath, copyFolderPath);
                if (!Directory.Exists(newFolder))
                    Directory.CreateDirectory(newFolder);
                //
                CopyFile(fromPath, copyFolderPath, folder, extensions);
            }
            //
            string[] files = Directory.GetFiles(folderPath);
            string extensionName, newFile;
            bool contains;
            foreach (string file in files)
            {
                newFile = file.Replace(fromPath, copyFolderPath);
                extensionName = Path.GetExtension(file).ToLower();
                contains = extensions.ContainsKey(extensionName);
                if (contains)
                    newFile = newFile + extensions[extensionName];
                //
                if (File.Exists(newFile)) continue;
                //
                if (contains)
                {
                    File.AppendAllText(newFile, File.ReadAllText(file, Encoding.UTF8), Encoding.UTF8);
                }
                //直接复制
                else
                {
                    File.Copy(file, newFile);
                }
            }
        }
    }
}
