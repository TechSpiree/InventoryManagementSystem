using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IMS
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            
            if(File.Exists(path+"\\cnt"))
            {
                Login lg = new Login();
                Mainclass.showwindow(lg, this);
            }
            else
            {
                settings st = new settings();
                Mainclass.showwindow(st, this);
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingToolStripMenuItem.Enabled = false;
            settings st = new settings();
            Mainclass.showwindow(st, this);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            Mainclass.showwindow(lg, this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("www.facebook.com/romisploit");
        }
    }
}
