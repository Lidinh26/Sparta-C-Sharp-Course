using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_07_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        void Initialize()
        {

        }

        static int counter = 0;
        private void Hello_Click(object sender, EventArgs e)
        {
            label1.Text = "You clicked " + counter + " times";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
