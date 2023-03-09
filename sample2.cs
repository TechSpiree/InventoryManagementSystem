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
    public partial class sample2 : Sample
    {
        public sample2()
        {
            InitializeComponent();
        }

        public void button6_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            Mainclass.showwindow(hs, this, MDI.ActiveForm);
        }

        public virtual void button2_Click(object sender, EventArgs e)
        {

        }

        public virtual void button3_Click(object sender, EventArgs e)
        {

        }

        public virtual void button4_Click(object sender, EventArgs e)
        {

        }

        public virtual void button5_Click(object sender, EventArgs e)
        {

        }

        public virtual void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
