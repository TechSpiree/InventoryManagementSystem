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
    public partial class catagory : sample2
    {
        public catagory()
        {
            InitializeComponent();
        }
       
  
        private void catagory_Load(object sender, EventArgs e)
        {
            Mainclass.disable(LeftPanel);
        }
        public override void button2_Click(object sender, EventArgs e)
        {
            Mainclass.enable_reset(LeftPanel);
            
        }

        public override void button3_Click(object sender, EventArgs e)
        {
           
            Mainclass.enable(LeftPanel);
        }

        public override void button4_Click(object sender, EventArgs e)
        {
            if (CattxtBox.Text == "") { carerrorlabel.Visible = true; }else { carerrorlabel.Visible = false; }
            if (ActiveDD.SelectedIndex == -1) { acriveerrorlabel.Visible = true; }else { acriveerrorlabel.Visible = false; }
            if (carerrorlabel.Visible || acriveerrorlabel.Visible )
            {
                Mainclass.ShowMSG("Fields With * are Mendatory..", "Stop", "Error");
            }
            else
            {
                if (ActiveDD.SelectedIndex == 0)
                {
                    
                }
                else if(ActiveDD.SelectedIndex==1)
                {
                   
                }
            }
        }

        public override void button5_Click(object sender, EventArgs e)
        {

        }

        public override void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void carerrorlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
