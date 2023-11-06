using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeGitRemoteUrlTool
{
    public partial class Form1 : Form
    {
        private static readonly string GitFolderName = "\\.git";
        private static readonly string GitConfigFileName = "\\config";
        private static readonly string GitUrlPattern = @"url = (http|ssh|https):\/\/{0}\/?";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetBasePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.SelectedPath = @"E:\Slipper\Code\gogs";
            folderBrowser.Description = "请选择项目所在的目录";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                this.txtBasePath.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnReplaceUrl_Click(object sender, EventArgs e)
        {
            string basePath = this.txtBasePath.Text.Trim();
            string oldUrl = this.txtOldUrl.Text.Trim();
            string newUrl = this.txtNewUrl.Text.Trim();


            if (String.IsNullOrWhiteSpace(basePath))
            {
                MessageBox.Show("请先选择项目所在目录。");
                return;
            }
            if (string.IsNullOrWhiteSpace(oldUrl))
            {
                MessageBox.Show("请输入原地址。");
            }
            if (string.IsNullOrWhiteSpace(newUrl))
            {
                MessageBox.Show("请输入新地址。");
            }

            try
            {
                int successCount = 0;
                string pattern = string.Format(GitUrlPattern, oldUrl);
                List<string> list = GetGitRepositoriesPath(basePath);

                foreach (string gitPath in list)
                {
                    string confFileName = gitPath + GitFolderName + GitConfigFileName;
                    if (!File.Exists(confFileName))
                    {
                        continue;
                    }

                    string text = File.ReadAllText(confFileName, Encoding.UTF8);
                    if (Regex.IsMatch(text, pattern))
                    {
                        text = text.Replace(oldUrl, newUrl);
                        File.WriteAllText(confFileName, text, Encoding.UTF8);
                        successCount++;
                    }
                }

                MessageBox.Show($"共发现{list.Count}个项目,替换成功{successCount}个。");
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常:" + ex.Message);
            }
        }

        /// <summary>
        /// 获取指定目录下是git项目的文件夹路径
        /// </summary>
        /// <param name="basePath"></param>
        /// <returns></returns>
        private List<string> GetGitRepositoriesPath(string basePath)
        {
            List<string> listResult = new List<string>();

            if (HasGitFolder(basePath))
            {
                listResult.Add(basePath);
                return listResult;
            }

            string[] directories = Directory.GetDirectories(basePath);

            foreach (var directory in directories)
            {
                listResult.AddRange(GetGitRepositoriesPath(directory));
            }

            return listResult;
        }

        /// <summary>
        /// 判断指定路径是否为git项目
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private bool HasGitFolder(string path)
        {
            string[] directories = Directory.GetDirectories(path);
            string gitPath = directories.FirstOrDefault(en => en.EndsWith(GitFolderName));
            return !string.IsNullOrEmpty(gitPath);
        }
    }
}
