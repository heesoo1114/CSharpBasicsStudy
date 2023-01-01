using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris_10112
{
    public partial class Form1 : Form
    {
        Game game;
        
        int bx;
        int by;
        int bwidth;
        int bheight;

        public static int score;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = Game.Singleton;
            bx = GameRule.BX;
            by = GameRule.BY;
            bwidth = GameRule.B_WIDTH;
            bheight = GameRule.B_HEIGHT;
            score = 0;
            SetClientSizeCore(bx * bwidth, by * bheight);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawGraduation(e.Graphics);
            DrawDiagram(e.Graphics);
            DoubleBuffered = true;
            DrawBoard(e.Graphics);
        }

        private void DrawBoard(Graphics graphics)
        {
            for(int xx = 0; xx < bx; xx++)
            {
                for(int yy = 0; yy < by; yy++)
                {
                    if(game[xx, yy] != 0)
                    {
                        Rectangle now_rt = new Rectangle(xx * bwidth + 2, yy * bheight + 2, bwidth - 4, bheight - 4);
                        graphics.DrawRectangle(Pens.Green, now_rt);
                        graphics.FillRectangle(Brushes.Red, now_rt);
                    }
                }
            }
        }

        private void DrawDiagram(Graphics graphics)
        {
            Pen dpen = new Pen(Color.Red, 4);
            Point now = game.NowPosition;
            int bn = game.BlockNum;
            int tn = game.Turn;

            for (int xx = 0; xx < 4; xx++)
            {
                for ( int yy = 0; yy < 4; yy++)
                {
                    if(BlockValue.bvals[bn, tn, xx, yy] != 0)
                    {
                        Rectangle now_rt = new Rectangle((now.X + xx) * bwidth + 2, (now.Y + yy) * bheight + 2, bwidth - 4, bheight- 4);
                        graphics.DrawRectangle(dpen, now_rt);
                    }
                }
            }
        }

        private void DrawGraduation(Graphics graphics)
        {
            DrawHozions(graphics);
            DrawDiagramVerticals(graphics);
        }

        private void DrawDiagramVerticals(Graphics graphics)
        {
            Point st = new Point();
            Point et = new Point();

            for(int cx = 0; cx < bx; cx++)
            {
                st.X = cx * bwidth;
                st.Y = 0;
                et.X = st.X;
                et.Y = by * bheight;
                graphics.DrawLine(Pens.Blue, st, et);
            }
        }

        private void DrawHozions(Graphics graphics)
        {
            Point st = new Point();
            Point et = new Point();

            for (int cy = 0; cy < by; cy++)
            {
                st.X = 0;
                st.Y = cy * bheight;
                et.X = bx * bwidth;
                et.Y = st.Y;
                graphics.DrawLine(Pens.Brown, st, et);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Escape)
            {
                timer_down.Enabled = false;
                DialogResult re = MessageBox.Show("계속 하시겠습니까?", "게임을 멈췄습니다", MessageBoxButtons.YesNo);
                if (re == DialogResult.Yes)
                {
                    timer_down.Enabled = true;
                    Invalidate();
                }
                else
                {
                    Close();
                }
            }

            switch (e.KeyCode)
            {
                case Keys.Right : MoveRight(); return;
                case Keys.Left : MoveLeft(); return;
                case Keys.Space: MoveDown(); return;
                case Keys.Up : MoveSSDown(); return;
                case Keys.Down: MoveTurn(); return;
            }
        }

        private void MoveSSDown()
        {
            while (game.MoveDown())
            {
                Region rg = MakeRegion(0, 1);
                Invalidate(rg);
            }
            EndingCheck();
        }

        private void MoveDown()
        {
            if (game.MoveDown())
            {
                Region rg = MakeRegion(0, -1);
                Invalidate(rg); 
            }
            else
            {
                EndingCheck();
            }
        }

        private void EndingCheck()
        {
            if (game.Next())
            {
                Invalidate();
            }
            else
            {
                timer_down.Enabled = false; 

                DialogResult re1 = MessageBox.Show("점수", $"점수 : {score}");
                DialogResult re = MessageBox.Show("다시시작", "여부 알려주세요", MessageBoxButtons.YesNo);

                if(re == DialogResult.Yes)
                {
                    game.Restart();
                    timer_down.Enabled = true;
                    Invalidate();
                }
                else
                {
                    Close();
                }
            }
        }

        private Region MakeRegion(int cx, int cy)
        {
            Point now = game.NowPosition;
            int bn = game.BlockNum;
            int tn = game.Turn;

            Region region = new Region();

            for( int xx = 0; xx < 4; xx++)
            {
                for( int yy = 0; yy < 4; yy++)
                {
                    if(BlockValue.bvals[bn, tn, xx, yy] != 0)
                    {
                        Rectangle rect1 = new Rectangle((now.X + xx) * bwidth, (now.Y + yy) * bheight, bwidth, bheight);
                        Rectangle rect2 = new Rectangle((now.X + xx + cx) * bwidth, (now.Y + xx + cy) * bheight, bwidth, bheight);
                        Region rg1 = new Region(rect1);
                        Region rg2 = new Region(rect2);
                        region.Union(rg1);
                        region.Union(rg2);
                    }
                }
            }
            return region;
        }

        private Region MakeRegion()
        {
            Point now = game.NowPosition;
            int bn = game.BlockNum;
            int tn = game.Turn;
            int oldtn = (tn + 3) % 4;

            Region region = new Region();

            for(int xx = 0; xx < 4; xx++)
            {
                for(int yy = 0; yy < 4; yy++)
                {
                    if(BlockValue.bvals[bn, tn, xx, yy] != 0)
                    {
                        Rectangle rect1 = new Rectangle((now.X + xx) * bwidth, (now.Y + yy)* bheight, bwidth, bheight);
                        Region rg1 = new Region(rect1);
                        region.Union(rg1);
                    }
                    if(BlockValue.bvals[bn, tn, xx, yy] != 0)
                    {
                        Rectangle rect1 = new Rectangle((now.X + xx) * bwidth, (now.Y + yy) * bheight, bwidth, bheight);
                        Region rg1 = new Region(rect1);
                        region.Union(rg1);
                    }
                }
            }
            return region;
        }

        private void MoveLeft()
        {
            if (game.MoveLeft())
            {
                Region rg = MakeRegion(1, 0);
                Invalidate(rg);
            }
        }

        private void MoveRight()
        {
            if (game.MoveRight())
            {
                Region rg = MakeRegion(-1, 0);
                Invalidate(rg);
            }
        }

        private void MoveTurn()
        {
            if (game.MoveTurn())
            {
                Region rg = MakeRegion();
                Invalidate(rg);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveDown();

            Score.Text = score.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // not thing
        }
    }
}
