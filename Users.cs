using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class Users : sample2
    {
        public Users()
        {
            InitializeComponent();
        }
        int edit = 0;

        private void Users_Load(object sender, EventArgs e)
        {
            Mainclass.disable(LeftPanel);
        }
        public override void button2_Click(object sender, EventArgs e)
        {
            Mainclass.enable_reset(LeftPanel);
            edit = 0;
            
        }

        public override void button3_Click(object sender, EventArgs e)
        {
            
            Mainclass.enable(LeftPanel);
            edit = 1;
        }

        public override void button4_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == "") { nameerrorlabel.Visible = true; } else { nameerrorlabel.Visible = false; }
            if (UsernameTxt.Text == "") { usernameerrorlabel.Visible = true; }else { usernameerrorlabel.Visible = false; }
            if (PasswordTxt.Text == "") { passerrorlabel.Visible = true; } else { passerrorlabel.Visible = false; }
            if (EmailTxt.Text == "") { emailerrorlabel.Visible = true; } else { passerrorlabel.Visible = false; }
            if (PhoneTxt.Text == "") { phoneerrorlabel.Visible = true; } else { phoneerrorlabel.Visible = false; }
            if(nameerrorlabel.Visible||usernameerrorlabel.Visible||passerrorlabel.Visible||emailerrorlabel.Visible||phoneerrorlabel.Visible)
            {
                Mainclass.ShowMSG("Fileds With * Are Mendatory...", "Stop", "Error");
            }
            else
            {
                if(edit==0)         //code for save 
                {

                }
                else if(edit==1)   //code for update 
                {

                }
            }
        }
        public override void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
