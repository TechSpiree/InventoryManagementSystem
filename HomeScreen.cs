using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            catagory cg = new catagory();
            Mainclass.showwindow(cg, this, MDI.ActiveForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Products pd = new Products();
            Mainclass.showwindow(pd, this, MDI.ActiveForm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Percahse_Invoice pi = new Percahse_Invoice();
            Mainclass.showwindow(pi, this, MDI.ActiveForm);
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            Users us = new Users();
            Mainclass.showwindow(us, this, MDI.ActiveForm);
        }
    }
}
