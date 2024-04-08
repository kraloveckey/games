namespace Hangman
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;

    public class HangDude
    {
        private Point Position = new Point(0, 0);
        public const int HeadDiameter = 15;
        public const int BodyLength = 50;
        public const int ArmLength = 20;
        public const int NeckLength = 10;
        public const int StandLength = 15;
        public const int DistanceToTree = 25;

        public void SetPosition(int x, int y) { Position.X = x; Position.Y = y; }

        public void DrawHangStand(Graphics g)
        {
            Pen aPen = new Pen(Color.Black);
            g.DrawLine(aPen, Position.X + HeadDiameter / 2, Position.Y, Position.X + HeadDiameter / 2, Position.Y - 10);
            g.DrawLine(aPen, Position.X + HeadDiameter / 2, Position.Y - 10, Position.X + HeadDiameter / 2 - DistanceToTree, Position.Y - 10);
            g.DrawLine(aPen, Position.X + HeadDiameter / 2 - DistanceToTree, Position.Y - 10, Position.X + HeadDiameter / 2 - DistanceToTree, Position.Y + BodyLength + HeadDiameter + ArmLength + StandLength);
            g.DrawLine(aPen, Position.X + HeadDiameter / 2 - 30, Position.Y + BodyLength + HeadDiameter + ArmLength + StandLength, Position.X + HeadDiameter / 2 + 30, Position.Y + BodyLength + HeadDiameter + ArmLength + StandLength);
        }


        public void DrawHead(Graphics g)
        {
            Rectangle rect = new Rectangle(Position.X, Position.Y, HeadDiameter, HeadDiameter);
            g.DrawEllipse(new Pen(Color.Blue), rect);
        }

        public void DrawLeftArm(Graphics g)
        {
            g.DrawLine(new Pen(Color.Blue), Position.X + HeadDiameter / 2, Position.Y + HeadDiameter + NeckLength, Position.X + HeadDiameter / 2 - ArmLength, Position.Y + HeadDiameter + NeckLength + ArmLength);
        }

        public void DrawRightArm(Graphics g)
        {
            g.DrawLine(new Pen(Color.Blue), Position.X + HeadDiameter / 2, Position.Y + HeadDiameter + NeckLength, Position.X + HeadDiameter / 2 + ArmLength, Position.Y + HeadDiameter + NeckLength + ArmLength);
        }

        public void DrawBody(Graphics g)
        {
            g.DrawLine(new Pen(Color.Blue), Position.X + HeadDiameter / 2, Position.Y + HeadDiameter, Position.X + HeadDiameter / 2, Position.Y + HeadDiameter + BodyLength);
        }

        public void DrawLeftLeg(Graphics g)
        {
            g.DrawLine(new Pen(Color.Blue), Position.X + HeadDiameter / 2, Position.Y + HeadDiameter + BodyLength, Position.X + HeadDiameter / 2 - ArmLength, Position.Y + HeadDiameter + BodyLength + ArmLength);
        }

        public void DrawRightLeg(Graphics g)
        {
            g.DrawLine(new Pen(Color.Blue), Position.X + HeadDiameter / 2, Position.Y + HeadDiameter + BodyLength, Position.X + HeadDiameter / 2 + ArmLength, Position.Y + HeadDiameter + BodyLength + ArmLength);
        }

        public int NumberOfMisses = 0;

        public void DrawAllBasedOnMisses(Graphics g)
        {
            DrawHangStand(g);

            if (NumberOfMisses > 0)
            {
                DrawHead(g);
            }

            if (NumberOfMisses > 1)
            {
                DrawBody(g);
            }

            if (NumberOfMisses > 2)
            {
                DrawLeftArm(g);
            }

            if (NumberOfMisses > 3)
            {
                DrawRightArm(g);
            }

            if (NumberOfMisses > 4)
            {
                DrawLeftLeg(g);
            }

            if (NumberOfMisses > 5)
            {
                DrawRightLeg(g);
            }
        }
    }

}