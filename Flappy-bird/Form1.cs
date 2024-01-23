using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundOfGame_Click(object sender, EventArgs e)
        {

        }
        Random random = new Random();   
        int gravity = 20;
        int speed = 15;
        int score= 0;
  

        private void timer1_Tick(object sender, EventArgs e)
        {
            humangamer.Top += gravity;
            wall1.Left -= speed;
            wall2.Left -=speed;
            label1.Text = "scor: " + score.ToString(); 
            if(wall1.Left < 0)
            {
                wall1.Left = random.Next(400, 650);
                wall2.Left = random.Next(400, 550);
                speed++;
                score++;
            }
            if (humangamer.Bounds.IntersectsWith(wall1.Bounds) || humangamer.Bounds.IntersectsWith(wall2.Bounds) || humangamer.Bounds.IntersectsWith(floor.Bounds))
            {
                timer1.Stop();
                speed = 15;
                label1.Text = "Game Over"+ "Score :"+score.ToString();
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled == false)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    timer1.Start();
                    score = 0;
                    
                    wall1.Left= random.Next(400, 650);
                    wall2.Left = random.Next(400, 550);
                    humangamer.Top = 150;


                }
            }


            if (e.KeyCode == Keys.Enter)
            {
                timer1.Start();

            }
                if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
            if(humangamer.Top < 2)
            {
                humangamer.Top = 16;
            }
            if(humangamer.Top >350)
            {
                humangamer.Top = 300;
            }
          
         

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

      
    }
}
