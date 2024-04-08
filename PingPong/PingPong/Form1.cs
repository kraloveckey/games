using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        public int speed_left = 2; //Speed of the ball
        public int speed_top = 4;
        public int point = 0; //Scored points
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide(); //Hide the cursor

            this.FormBorderStyle = FormBorderStyle.None; //Remove any border
            this.TopMost = true; //Bring the form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds; //Make it fullscreen

            racket.Top = playground.Bottom - (playground.Bottom / 10); //Set the position of racket

            gameover_lbl.Left = (playground.Width / 2) - (gameover_lbl.Width / 2); //Position to center
            gameover_lbl.Top = (playground.Height / 2) - (gameover_lbl.Height / 2);

            gameover_lbl.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2); //Set the center of the racket to the position of the cursor

            ball.Left += speed_left; //Move the ball
            ball.Top += speed_top;

            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right) //Racket collision
            {
                speed_top += 1;
                speed_left += 1;
                speed_top = -speed_top; //Change direction
                point += 1;
                points_lbl.Text = point.ToString();

                Random r = new Random();
                playground.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255)); //Get a random RGB color and set is as playground backcolor
            }

            if (ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }

            if (ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }

            if (ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }

            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false; //Ball is out ---> Stop the game
                gameover_lbl.Visible = true;

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Application.Exit(); } // Press Escape to Quit

            if (e.KeyCode == Keys.F1) //Reload game
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                point = 0;
                points_lbl.Text = "0";
                timer1.Enabled = true;
                gameover_lbl.Visible = false;
                playground.BackColor = Color.White;
            }
        }
    }
}
