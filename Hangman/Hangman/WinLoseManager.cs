namespace Hangman
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;

    /// <summary>
    ///  Class for Managing Wins of Losses of the game
    /// </summary>
    public class WinLoseManager
    {
        const int AllowableMisses = 6;

        private bool m_bWinFlag = false;
        public bool YouWinFlag
        {
            get
            {
                return m_bWinFlag;
            }
            set
            {
                m_bWinFlag = value;
            }

        }

        private bool m_bLoseFlag = false;
        public bool YouLoseFlag
        {
            get
            {
                return m_bLoseFlag;
            }
            set
            {
                m_bLoseFlag = value;
            }

        }

        public WinLoseManager()
        {
            // 
            // TODO: Add Constructor Logic here
            //
        }

        public void YouLose(Graphics g)
        {
            g.DrawString("You Lose The Game!", new Font("Arial", 15), new SolidBrush(Color.Azure), 10, 190);
        }

        public void YouWin(Graphics g)
        {
            g.DrawString("You Win The Game!", new Font("Arial", 15), new SolidBrush(Color.Azure), 10, 190);
        }

        public bool CheckForWin(int count, string strWord)
        {

            if (count >= strWord.Length)
            {
                return true;
            }

            return false;
        }

        public bool CheckForLoss(int nMisses)
        {
            if (nMisses >= AllowableMisses)
            {
                return true;
            }

            return false;
        }


        public void PlayAgain(Graphics g)
        {
            g.DrawString("Play Again(Y/N)?", new Font("Arial", 15), new SolidBrush(Color.Azure), 10, 220);
        }

        public void Initialize()
        {
            YouWinFlag = false;
            YouLoseFlag = false;
        }

    }


}
