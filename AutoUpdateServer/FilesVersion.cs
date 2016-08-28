using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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



                FilesVersionXml.Save(Properties.Settings.Default.FileVersionXmlFileName);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
