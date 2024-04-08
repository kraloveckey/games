using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarleyBreak
{
    public partial class Form1 : Form
    {
        private static int count;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button 2,5
            CheckButton(button1, button2);
            CheckButton(button1, button5);
            CheckSolved();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1,3,6
            CheckButton(button2, button1);
            CheckButton(button2, button3);
            CheckButton(button2, button6);
            CheckSolved();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //2,4,7
            CheckButton(button3, button2);
            CheckButton(button3, button4);
            CheckButton(button3, button7);
            CheckSolved();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //3,8
            CheckButton(button4, button3);
            CheckButton(button4, button8);
            CheckSolved();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //1,6,9
            CheckButton(button5, button1);
            CheckButton(button5, button9);
            CheckButton(button5, button6);
            CheckSolved();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //2/5/10/7
            CheckButton(button6, button2);
            CheckButton(button6, button5);
            CheckButton(button6, button7);
            CheckButton(button6, button10);
            CheckSolved();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //3/6/11/8
            CheckButton(button7, button3);
            CheckButton(button7, button8);
            CheckButton(button7, button11);
            CheckButton(button7, button6);
            CheckSolved();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //4..12,7
            CheckButton(button8, button12);
            CheckButton(button8, button4);
            CheckButton(button8, button7);
            CheckSolved();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //5,10,13
            CheckButton(button9, button10);
            CheckButton(button9, button13);
            CheckButton(button9, button5);
            CheckSolved();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //6,9,11,14
            CheckButton(button10, button11);
            CheckButton(button10, button9);
            CheckButton(button10, button6);
            CheckButton(button10, button14);
            CheckSolved();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //7,10,15,12
            CheckButton(button11, button10);
            CheckButton(button11, button12);
            CheckButton(button11, button15);
            CheckButton(button11, button7);
            CheckSolved();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //8,11,16
            CheckButton(button12, button11);
            CheckButton(button12, button16);
            CheckButton(button12, button8);
            CheckSolved();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CheckButton(button13, button14);
            CheckButton(button13, button9);
            CheckSolved();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            CheckButton(button14, button10);
            CheckButton(button14, button13);
            CheckButton(button14, button15);
            CheckSolved();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            CheckButton(button15, button11);
            CheckButton(button15, button16);
            CheckButton(button15, button14);
            CheckSolved();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            CheckButton(button16, button12);
            CheckButton(button16, button15);
            CheckSolved();
        }
        public void CheckButton(Button bttn1, Button bttn2)
        {
            if (bttn2.Text == "")
            {
                bttn2.Text = bttn1.Text;
                bttn1.Text = "";
            }

        }
        public void CheckSolved()
        {
            count = count + 1;
            label2.Text = count + " Clicks";
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" && button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" && button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" && button13.Text == "13" && button14.Text == "14" && button15.Text == "15" && button16.Text == "")
            {
                MessageBox.Show("WOW YOU DID IT IN " + count + " CLICKs");
            }

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Shuffle()
        {
            int i, j, RN;
            int[] a = new int[16];
            Boolean flag = false;
            i = 1;
            //a[j] = 1;
            do
            {
                Random rnd = new Random();
                //int b = rnd.Next(1, 15);
                RN = Convert.ToInt32((rnd.Next(0, 15)) + 1);
                for (j = 1; j <= i; j++)
                {
                    if (a[j] == RN)
                    {
                        flag = true;
                        break;
                    }

                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    a[i] = RN;
                    i = i + 1;
                }
            }
            while (i <= 15);
            button1.Text = Convert.ToString(a[1]);
            button2.Text = Convert.ToString(a[2]);
            button3.Text = Convert.ToString(a[3]);
            button4.Text = Convert.ToString(a[4]);
            button5.Text = Convert.ToString(a[5]);
            button6.Text = Convert.ToString(a[6]);
            button7.Text = Convert.ToString(a[7]);
            button8.Text = Convert.ToString(a[8]);
            button9.Text = Convert.ToString(a[9]);
            button10.Text = Convert.ToString(a[10]);
            button11.Text = Convert.ToString(a[11]);
            button12.Text = Convert.ToString(a[12]);
            button13.Text = Convert.ToString(a[13]);
            button14.Text = Convert.ToString(a[14]);
            button15.Text = Convert.ToString(a[15]);
            button16.Text = "";
            count = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By kraloveckey", "About");
        }
    }
}
