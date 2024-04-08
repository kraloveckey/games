using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data;
using System.Threading;
using System.Runtime.InteropServices;


namespace Hangman
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : System.Windows.Forms.Form
    {
        private System.ComponentModel.Container components1;
        private HangDude TheMan;
        private LetterManager TheLetterManager;
        private RandomWordManager TheWordManager;
        private WinLoseManager TheWinLoseManager;
        private Thread oThread = null;

        [DllImport("winmm.dll")]
        public static extern long PlaySound(String lpszName, long hModule, long dwFlags);

        /// <summary>
        /// Required designer variable.
        /// </summary>

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            InitializeComponent1();

            TheMan = new HangDude();
            TheMan.SetPosition(50, 50);
            TheWordManager = new RandomWordManager();
            TheLetterManager = new LetterManager(TheWordManager.Pick());
            TheLetterManager.SetPosition(20, 150);
            TheLetterManager.SetMissPosition(this.ClientRectangle.Right - 120, this.ClientRectangle.Bottom - 20);
            TheWinLoseManager = new WinLoseManager();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        //		public override void Dispose()
        //		{
        //			if (components != null) 
        //			{
        //				components.Dispose();
        //			}
        //			base.Dispose();
        //		}

        private string m_strCurrentSoundFile = "miss.wav";
        public void PlayASound()
        {
            if (m_strCurrentSoundFile.Length > 0)
            {
                PlaySound(Application.StartupPath + "\\" + m_strCurrentSoundFile, 0, 0);
            }
            m_strCurrentSoundFile = "";
            oThread.Abort();
        }

        public void PlaySoundInThread(string wavefile)
        {
            m_strCurrentSoundFile = wavefile;
            oThread = new Thread(new ThreadStart(PlayASound));
            oThread.Start();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            char j = e.KeyChar;
            string bigJ = j.ToString().ToUpper();
            j = bigJ[0];

            if (TheWinLoseManager.YouLoseFlag || TheWinLoseManager.YouWinFlag)
            {
                if (j == 'N')
                {
                    Application.Exit();
                }

                if (j == 'Y')
                {

                    TheLetterManager = null;
                    TheLetterManager = new LetterManager(TheWordManager.Pick());
                    TheLetterManager.SetPosition(20, 150);
                    TheLetterManager.SetMissPosition(this.ClientRectangle.Right - 120, this.ClientRectangle.Bottom - 20);
                    TheWinLoseManager.Initialize();
                    TheMan.NumberOfMisses = 0;
                    this.Invalidate();
                }

                return;
            }

            if (TheLetterManager.GotALetter(j) == false)
            {
                TheMan.NumberOfMisses++;
                PlaySoundInThread("miss.wav");
            }
            else
            {
                PlaySoundInThread("hit.wav");
            }

            if (TheWinLoseManager.CheckForLoss(TheMan.NumberOfMisses))
            {
                PlaySoundInThread("youlose.wav");
                TheWinLoseManager.YouLoseFlag = true;
            }

            if (TheWinLoseManager.CheckForWin(TheLetterManager.GetNumberOfGuesses(), TheLetterManager.GetHiddenWord()))
            {
                PlaySoundInThread("tada.wav");
                TheWinLoseManager.YouWinFlag = true;
            }


            this.Invalidate();

        }



        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent1()
        {
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        private void OnPaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = this.ClientRectangle;
            LinearGradientBrush lBrush = new LinearGradientBrush(rect, Color.Red, Color.Yellow,
                LinearGradientMode.BackwardDiagonal);
            g.FillRectangle(lBrush, rect);
            TheMan.DrawAllBasedOnMisses(g);
            TheLetterManager.DrawLetters(g);
            if (TheWinLoseManager.YouLoseFlag == true)
            {
                TheWinLoseManager.YouLose(g);
                TheWinLoseManager.PlayAgain(g);
            }
            else if (TheWinLoseManager.YouWinFlag == true)
            {
                TheWinLoseManager.YouWin(g);
                TheWinLoseManager.PlayAgain(g);
            }
        }
    }
}
