using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kid_Learning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animals check = new Animals();
            this.Hide();
            check.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bird check = new bird();
            this.Hide();
            check.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Color check = new Color();
            this.Hide();
            check.Show();
        }
    }
}
