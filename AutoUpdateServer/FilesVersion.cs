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
        public string path = Environment.CurrentDirectory + "/test";
        public FilesVersion()
        {
            FilesVersionXml = new XmlDocument();
            try
            {
                if (!File.Exists(Properties.Settings.Default.FileVersionXmlFileName))
                {
                    var fileStream = new FileStream(Properties.Settings.Default.FileVersionXmlFileName, FileMode.CreateNew);
                    var temp = Encoding.UTF8.GetBytes(Properties.Resources.FilesVersion);
                    fileStream.Write(temp, 0, temp.Count());
                    fileStream.Close();
                }
                FilesVersionXml.LoadXml(File.ReadAllText(Properties.Settings.Default.FileVersionXmlFileName));
                root = FilesVersionXml.DocumentElement;

                //FilesVersionXml.Save(Properties.Settings.Default.FileVersionXmlFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Debug.WriteLine(ex.Message);
            }
        }
        public void initXml()
        {
            try
            {
                LatestVersion = FilesVersionXml.CreateElement("LatestVersion");
                root.AppendChild(LatestVersion);
                AllFilesVersion = FilesVersionXml.CreateElement("AllFilesVersion");
                root.AppendChild(AllFilesVersion);

                AppendAllFolder(path, null);

                FilesVersionXml.Save(Properties.Settings.Default.FileVersionXmlFileName);
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
        public string GetMD5(string filepath)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] file = File.ReadAllBytes(filepath);
            byte[] output = md5.ComputeHash(file);
            return BitConverter.ToString(output).Replace("-", "");
        }
    }
}
