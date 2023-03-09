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
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(usernametxt.Text=="" && passwordtxt.Text=="")
            {
                HomeScreen hs = new HomeScreen();
                Mainclass.showwindow(hs, this, MDI.ActiveForm);
                
            }
            else
            {
                Mainclass.ShowMSG("Fill Username and Password First..", "stop", "Error");
            }
            
        }
    }
}
