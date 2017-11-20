using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdemyObj5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //put code to run when the button is clicked
            //we  want the button to fire an arrow
            //arch.shoot() has the action of shoorting an arrow
            //it causes the arrow count for the archer object to be decreased by 1
            //each call to Shoot gives back a number we can here to display number of arrows left.
            label1.Text = $"Arrows Left:{arch.Shoot()}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arch.ReloadQuiver(); //now invoke ReloadQuiver on the archer object
            
        }
    }
}
