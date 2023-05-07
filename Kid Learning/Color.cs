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
    public partial class Color : Form
    {
        public Color()
        {
            InitializeComponent();
        }

        private void Color_Load(object sender, EventArgs e)
        {

        }
        private void bird_Load(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {



        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip3_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip4_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip5_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip6_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip7_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip8_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;

            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;








            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox10.Visible = true;
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            radioButton9.Visible = true;
            radioButton10.Visible = true;
            radioButton11.Visible = true;
            radioButton12.Visible = true;
            radioButton13.Visible = true;
            radioButton14.Visible = true;
            radioButton15.Visible = true;
            radioButton16.Visible = true;
            button2.Visible = true;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int total = 0;
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton13.Checked == false)
            {
                MessageBox.Show("please select 1st Question option");
            }
            else if (radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false && radioButton14.Checked == false)
            {
                MessageBox.Show("please select 2nd question option");
            }
            else if (radioButton7.Checked == false && radioButton8.Checked == false && radioButton9.Checked == false && radioButton15.Checked == false)
            {
                MessageBox.Show("please select 3rd question option");
            }
            else if (radioButton10.Checked == false && radioButton11.Checked == false && radioButton12.Checked == false && radioButton16.Checked == false)
            {
                MessageBox.Show("please select 4rth question option");
            }

            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton13.Checked == true)
            {

                if (radioButton4.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true || radioButton14.Checked == true)
                {
                    if (radioButton7.Checked == true || radioButton8.Checked == true || radioButton9.Checked == true || radioButton15.Checked == true)
                    {
                        if (radioButton10.Checked == true || radioButton11.Checked == true || radioButton12.Checked == true || radioButton16.Checked == true)
                        {
                            button2.Visible = false;
                            if (radioButton3.Checked == true)
                            {
                                one = one + 5;
                            }
                            if (radioButton5.Checked == true)
                            {
                                two = two + 5;
                            }
                            if (radioButton9.Checked == true)
                            {
                                three = three + 5;
                            }
                            if (radioButton12.Checked == true)
                            {
                                four = four + 5;
                            }
                            label1.Visible = true;
                            label2.Visible = true;
                            total = one + two + three + four;
                            if (total == 0)
                            {
                                label1.Text = "Your score is " + total + " Out of 20";
                                label2.Text = "Not Good result";
                            }
                            else if (total == 5)
                            {
                                label1.Text = "Your score is " + total + " Out of 20";
                                label2.Text = "Need more effort";
                            }
                            else if (total == 10)
                            {
                                label1.Text = "Your score is " + total + " Out of 20";
                                label2.Text = "Satisfactory";
                            }
                            else if (total == 15)
                            {
                                label1.Text = "Your score is " + total + " Out of 20";
                                label2.Text = "Good";
                            }
                            else
                            {
                                label1.Text = "Your score is " + total + " Out of 20";
                                label2.Text = "Excellent";
                            }
                            // tabControl.TabPages.Insert(index, tabPage);
                            // tabControl.TabPages.Insert(index, tabPage);
                            tabControl1.TabPages.Insert(1, tabPage1);
                            tabControl1.TabPages.Insert(2, tabPage2);
                            button1.Text = "StartAgain";
                            button1.Visible = true;


                        }

                    }


                }

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 check = new Form1();
            this.Hide();
            check.Show();
        }
    }
}
