using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feeding_Cat
{
    public partial class Form1 : Form
    {
        Cat myCat = new Cat("Lucas", 1);
        public Form1()
        {
            InitializeComponent();
            catTextBox1.Text = myCat.express();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myCat.eat();
            catTextBox1.Text = myCat.express();
        }

        private void hangOut_Click(object sender, EventArgs e)
        {
            myCat.play();
            catTextBox1.Text = myCat.express();
        }

        private void catTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            myCat.GetBord();
            catTextBox1.Text = myCat.express();
        }
    }
}
