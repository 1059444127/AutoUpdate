using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AutoUpdateServer
{
    public partial class Form1 : Form
    {
        public FilesOperate filesOperate;
        public FilesVersion filesVersion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            filesOperate = new FilesOperate();
            filesVersion = new FilesVersion();
        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {
            filesVersion.SubmitNewVersion();
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Properties.Settings.Default.FileVersionXmlFileName))
                {
                    File.Delete(Properties.Settings.Default.FileVersionXmlFileName);
                    Form1_Load(null, null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
