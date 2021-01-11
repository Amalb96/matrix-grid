using System;
using System.Threading;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixGrid
{
    public partial class Form1 : Form
    {
        public int m_width; //Width of the grid cell

        public int m_Height; // The height of the Cell

        public int m_NoOfRows; // The Number Of Rows

        public int m_NoOfCols; // The Number Of Columns

        public int m_XOffset; //Offset from which drawing start
        public int m_YOffset;

        public const int DEFAULT_X_OFFSET = 100;
        public const int DEFAULT_Y_OFFSET = 50;
        public const int DEFAULT_NO_ROWS = 2;
        public const int DEFAULT_NO_COLS = 1;
        public const int DEFAULT_WIDTH = 60;
        public const int DEFAULT_HEIGHT = 60;
        int m_K = -3;
        public Form1()
        {
            Initialize();
            InitializeComponent();
            bThreadStatus = false;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridMatrix = new Thread(new ThreadStart(DrawGrid));
            GridMatrix.Start();bThreadStatus = true;
        }

        public void Initialize()
        {
            //Put all the default values
            m_NoOfRows = DEFAULT_NO_ROWS;
            m_NoOfCols = DEFAULT_NO_COLS;
            m_width = DEFAULT_WIDTH;
            m_Height = DEFAULT_HEIGHT;
            m_XOffset = DEFAULT_X_OFFSET;
            m_YOffset = DEFAULT_Y_OFFSET;

        }
        private void DrawGrid()
        {
            for (; ; )
            {
                m_K++;
                if (m_K == 5)
                    m_K = -3;


                Graphics boardLayout = this.CreateGraphics();
                Pen layoutPen = new Pen(Color.Red);
                layoutPen.Width = 5;

                //boardLayout.DrawLine(layoutPen, 0, 0, 100, 0);
                int X = DEFAULT_X_OFFSET;
                int Y = DEFAULT_Y_OFFSET;
                //Draw The rows
                if (m_NoOfCols != 0)
                {
                    for (int i = 0; i <= m_NoOfRows; i++)
                    {
                        boardLayout.DrawLine(layoutPen, X, Y, X + this.m_width * this.m_NoOfCols, Y);
                        Y = Y + m_Height;
                    }

                    X = DEFAULT_X_OFFSET;
                    Y = DEFAULT_Y_OFFSET;
                    for (int j = 0; j <= m_NoOfCols; j++)
                    {
                        boardLayout.DrawLine(layoutPen, X, Y, X, Y + this.m_Height * this.m_NoOfRows);
                        X = X + this.m_width;

                    }
                }
                Thread.Sleep(230);
                if (m_K <= 0)
                    m_NoOfCols++;
                else
                    m_NoOfCols--;
                Invalidate();
            }
         
         }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            GridMatrix.Suspend();
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridMatrix.Resume();

        }

        private void toolStripMenuItem_50_Click(object sender, EventArgs e)
        {
            m_width = DEFAULT_WIDTH / 2;
            m_Height = DEFAULT_HEIGHT / 2;
        }

        private void toolStripMenuItem_100_Click(object sender, EventArgs e)
        {
            m_width = DEFAULT_WIDTH;
            m_Height = DEFAULT_HEIGHT;
        }

        private void toolStripMenuItem_200_Click(object sender, EventArgs e)
        {
            m_width = DEFAULT_WIDTH * 2;
            m_Height = DEFAULT_HEIGHT * 2;
        }
    }
}
