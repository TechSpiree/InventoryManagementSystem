using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace IMS
{
    public partial class settings : Sample
    {
        public settings()
        {
            InitializeComponent();
        }
        Mainclass main = new Mainclass();
        string s;
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void ServerTxt_TextChanged(object sender, EventArgs e)
        {
            if (ServerTxt.Text == "") { ServerErrorLabel.Visible = true; } else { ServerErrorLabel.Visible = false; }
        }

        private void DBTxt_TextChanged(object sender, EventArgs e)
        {
            if (DBTxt.Text == "") { DBErrorLabel.Visible = true; } else { DBErrorLabel.Visible = false; }
        }

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ISCBDD_CheckedChanged(object sender, EventArgs e)
        {
            if(ISCBDD.Checked)
            {
                UsernameTxt.Text = "";
                UsernameTxt.Enabled = false;

                PassTxt.Text = "";
                PassTxt.Enabled = false;
                usernamerrorlabel.Visible = false;
                passerrorlabel.Visible = false;
            }
            else 
            {
               
                UsernameTxt.Enabled = true;

               
                PassTxt.Enabled = true;
            }
        }
        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (ISCBDD.Checked)
            {
                if (ServerTxt.Text == "") { ServerErrorLabel.Visible = true; } else { ServerErrorLabel.Visible = false; }
                if (DBTxt.Text == "") { DBErrorLabel.Visible = true; } else { DBErrorLabel.Visible = false; }
                if (ServerErrorLabel.Visible || DBErrorLabel.Visible)
                {
                    Mainclass.ShowMSG("Fields With * are Mendatory For Save", "Stop", "Error");
                }
                else
                {
                    sb.Append("Data Source=" + ";Initial Catalog=" + DBTxt.Text + ";Intigrated Security True;MultipleActiveResultsSets=true");
                    File.WriteAllText(path + "\\cnt", sb.ToString());
                    DialogResult dr = MessageBox.Show("Setting Saved Successfully..","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if(dr==DialogResult.OK)
                    {
                        Login log = new Login();
                        Mainclass.showwindow(log, this,MDI.ActiveForm);
                    }
                }
            }
            else
            {
                if (ServerTxt.Text == "") { ServerErrorLabel.Visible = true; } else { ServerErrorLabel.Visible = false; }
                if (DBTxt.Text == "") { DBErrorLabel.Visible = true; } else { DBErrorLabel.Visible = false; }
                if (UsernameTxt.Text == "") { usernamerrorlabel.Visible = true; } else { usernamerrorlabel.Visible = false; }
                if (PassTxt.Text == "") { passerrorlabel.Visible = true; } else { passerrorlabel.Visible = false; }
                if(ServerErrorLabel.Visible||passerrorlabel.Visible||DBErrorLabel.Visible||usernamerrorlabel.Visible)
                {
                    Mainclass.ShowMSG("Fields With * Are Mendatory For Save", "Stop", "Error");
                }
                else
                {
                    sb.Append("Data Source=" + ";Initial Catalog=" + DBTxt.Text + ";User ID="+UsernameTxt.Text+";Password="+PassTxt.Text+ ";MultipleActiveResultsSets=true");
                    File.WriteAllText(path + "\\cnt", sb.ToString());
                    DialogResult dr = MessageBox.Show("Setting Saved Successfully..", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        Mainclass.showwindow(log, this, MDI.ActiveForm);
                    }
                }
            }
            }
        }
    }
