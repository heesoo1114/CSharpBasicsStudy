using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingCar_윤희수_10111
{
    public partial class Form1 : Form
    {


        int collectedcoin = 0;
        int carSpeed = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void coinsCollection()
        {
            if(pictureBox_Car.Bounds.IntersectsWith(pictureBox_Car.Bounds))
            {
                collectedcoin++;
                
            }
        }



        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(carSpeed);
            expensiveCar(3);
            gameover();
            coins(carSpeed);
        }

        Random r = new Random();
        int x;

        void expensiveCar(int speed)
        {
            if(pictureBox_expensivecar.Top >= 500)
            {
                x = r.Next(0, 400);
                pictureBox_expensivecar.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_expensivecar.Top += speed;
            }

            if(pictureBox_expensivecar2.Top >= 500)
            {
                x = r.Next(200, 438-(pictureBox_expensivecar2.Width));
                pictureBox_expensivecar2.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_expensivecar2.Top += speed;
            }
        }

        void coins(int speed)
        {
            if(pictureBox_expensivecar.Top >= 500)
            {
                x = r.Next(0, 200);
                coin1.Location = new Point(x, 0); 
            }
            else
            {
                coin1.Top += speed; 
            }
            
            if(pictureBox_expensivecar2.Top >= 500)
            {
                x = r.Next(100, 300);
                coin2.Location = new Point(x, 0); 
            }
            else
            {
                coin2.Top += speed; 
            }
            
            if(coin3.Top >= 500)
            {
                x = r.Next(250, 420);
                coin3.Location = new Point(x, 0); 
            }
            else
            {
                coin3.Top += speed; 
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(pictureBox_Car.Left > 0)
                {
                    pictureBox_Car.Left += -10;
                }
                
            }
            if(e.KeyCode == Keys.Right)
            {
                if(pictureBox_Car.Right < 320)
                {
                    pictureBox_Car.Left += 10;
                } 
            }

            if(e.KeyCode == Keys.Up)
            {
                if(carSpeed < 15)
                {
                    carSpeed++;
                }
            }

            if(e.KeyCode == Keys.Down)
            {
                if(carSpeed > 0)
                {
                    carSpeed--;
                }
            }
        }

        void gameover()
        {
            if(pictureBox_Car.Bounds.IntersectsWith(pictureBox_Car.Bounds))
            {
                timer1.Enabled = false;
                GameoverLablle.Visible = true;
            }
            if(pictureBox_Car.Bounds.IntersectsWith(pictureBox_expensivecar2.Bounds))
            {
                timer1.Enabled = false;
                GameoverLablle.Visible = true;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
