using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AutoUpdateServer
{
    public class FilesVersion
    {
        XmlDocument FilesVersionXml;
        XmlElement LatestVersion, AllFilesVersion, root;
        private string path = Environment.CurrentDirectory + "\\" + Properties.Settings.Default.NewVersionFolderName;
        public FilesVersion()
        {
            FilesVersionXml = new XmlDocument();

            try
            {
                //if (!File.Exists(Properties.Settings.Default.FileVersionXmlFileName))
                //{
                //    var fileStream = new FileStream(Properties.Settings.Default.FileVersionXmlFileName, FileMode.CreateNew);
                //    var temp = Encoding.UTF8.GetBytes(Properties.Resources.FilesVersion);
                //    fileStream.Write(temp, 0, temp.Count());
                //    fileStream.Close();
                //}
                //FilesVersionXml.LoadXml(File.ReadAllText(Properties.Settings.Default.FileVersionXmlFileName));
                FilesVersionXml.LoadXml(Properties.Resources.FilesVersion);

                root = FilesVersionXml.DocumentElement;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                //FilesVersionXml.Save(Properties.Settings.Default.FileVersionXmlFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Debug.WriteLine(ex.Message);
            }
        }
        public void SubmitNewVersion()
        {
            try
            {
                //LatestVersion = FilesVersionXml.CreateElement("LatestVersion");
                //root.AppendChild(LatestVersion);
                AllFilesVersion = FilesVersionXml.CreateElement("AllFilesVersion");
                root.AppendChild(AllFilesVersion);

                AppendAllFolder(path, null);

                string temp = Environment.CurrentDirectory + "\\" + Properties.Settings.Default.NewVersionFolderName + "\\" + Properties.Settings.Default.FileVersionXmlFileName;

                if (File.Exists(temp))
                    File.Delete(temp);

                FilesVersionXml.Save(temp);

                var now = DateTime.Now;
                string time = now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString();
                //Debug.WriteLine(time);

                string temp2 = Environment.CurrentDirectory + "\\" + Properties.Settings.Default.RepositoryFolderName + "\\" + time;

                if (!File.Exists(temp2))
                {
                    Directory.CreateDirectory(temp2);
                    CopyFiles(path, temp2);
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.RepositoryFolderName + "\\" + time
                    + "存储库中文件夹已存在，请稍后重试");
                }
                if (MessageBox.Show("操作完成。\n是否清空临时存储区" + Properties.Settings.Default.NewVersionFolderName + "目录下的所有文件？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteAll(path);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public void AppendAllFolder(string FolderPath, XmlElement parent)
        {

            DirectoryInfo TheFolder = new DirectoryInfo(FolderPath);

            foreach (DirectoryInfo NextFolder in TheFolder.GetDirectories())
            {
                //遍历文件夹
                XmlElement folder = FilesVersionXml.CreateElement("D_" + NextFolder.Name);
                //folder.SetAttribute("folder", "1");

                if (parent == null)
                {
                    AllFilesVersion.AppendChild(folder);
                }
                else
                {
                    parent.AppendChild(folder);
                }
                AppendAllFolder(NextFolder.FullName, folder);
            }
            //遍历文件
            foreach (FileInfo NextFile in TheFolder.GetFiles())
            {
                XmlElement file = FilesVersionXml.CreateElement("F_" + NextFile.Name);
                file.InnerText = GetMD5(NextFile.FullName);
                //file.SetAttribute("folder", "0");
                if (parent == null)
                {
                    AllFilesVersion.AppendChild(file);
                }
                else
                {
                    parent.AppendChild(file);
                }
            }
        }
        public void DeleteAll(string pathToDelete)
        {
            foreach (string a in Directory.GetFileSystemEntries(pathToDelete))
            {
                if (File.Exists(a))
                {
                    //    FileInfo dd = new FileInfo(a);
                    //    //string na = dd.Name;
                    //    //string nc = na.Replace(dd.Extension, "");
                    //    ////Process[] pro = Process.GetProcesses();
                    //    //foreach (Process p in pro)
                    //    //{
                    //    //    if (p.MainWindowTitle.Contains(nc))
                    //    //        p.Kill(); //关闭正在使用的文件                   
                    //    //}
                    File.Delete(a);//删除文件
                }
                else
                {
                    DeleteAll(a);//递归删除子文件夹
                }
            }
            if (pathToDelete != path)
                Directory.Delete(pathToDelete);
        }

        public string GetMD5(string filepath)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] file = File.ReadAllBytes(filepath);
            byte[] output = md5.ComputeHash(file);
            return BitConverter.ToString(output).Replace("-", "");
        }
        public void CopyFiles(string varFromDirectory, string varToDirectory)
        {
            Directory.CreateDirectory(varToDirectory);
            if (!Directory.Exists(varFromDirectory))
            {
                MessageBox.Show("对不起，您要拷贝的目录不存在。 ");
                return;
            }
            string[] directories = Directory.GetDirectories(varFromDirectory);//取文件夹下所有文件夹名，放入数组；
            if (directories.Length > 0)
            {
                foreach (string d in directories)
                {
                    CopyFiles(d, varToDirectory + "\\" + d.Substring(d.LastIndexOf("\\") + 1));//递归拷贝文件和文件夹
                }
            }

            string[] files = Directory.GetFiles(varFromDirectory);//取文件夹下所有文件名，放入数组；
            if (files.Length > 0)
            {
                foreach (string s in files)
                {
                    File.Copy(s, varToDirectory + "\\" + s.Substring(s.LastIndexOf("\\") + 1));
                }
            }
        }
    }
}
