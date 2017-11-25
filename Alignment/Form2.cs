using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alignment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Rectangle prim = Screen.PrimaryScreen.WorkingArea;

            this.Left -= 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Drawing.Rectangle prim = Screen.PrimaryScreen.WorkingArea;

            
            this.CenterToScreen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Drawing.Rectangle prim = Screen.PrimaryScreen.WorkingArea;

            this.Left += 100;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Drawing.Rectangle prim = Screen.PrimaryScreen.WorkingArea;
            
            this.SetDesktopLocation(0, -100);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Drawing.Rectangle prim = Screen.PrimaryScreen.WorkingArea;


            this.CenterToScreen();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Drawing.Rectangle prim = Screen.PrimaryScreen.WorkingArea;

            this.SetDesktopLocation(0, 100);
        }
    }
}
