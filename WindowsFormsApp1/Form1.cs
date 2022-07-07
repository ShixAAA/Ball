using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int WidnthBall = 100;
        private int HeightBall = 100;
        private int ballPosX = 0;
        private int ballPosY = 0;
        private int StepX = 4;
        private int StepY = 4;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }

        private void PaintCircle(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.BackColor);
            e.Graphics.FillEllipse(Brushes.Red,
                            ballPosX,ballPosY,
                            WidnthBall,HeightBall);
            e.Graphics.DrawEllipse(Pens.Black,
                            ballPosX,ballPosY,
                            WidnthBall,HeightBall);
        }

        private void MoveBall(object sender, EventArgs e)
        {
            ballPosX += StepX;
            if (ballPosX < 0 || ballPosX + WidnthBall > this.ClientSize.Width)
            {
                StepX = -StepX;
            }
            ballPosY += StepY;

            if (ballPosY < 0 || ballPosY + HeightBall > this.ClientSize.Height)
            {
                StepY = -StepY;
            }
            this.Refresh();
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
