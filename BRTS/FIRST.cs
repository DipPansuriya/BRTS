using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BRTS
{
    public partial class FIRST : Form
    {
        string string1 = " WELCOME TO ";
        string string2 = "BRTS AHMEDABAD. . . ";

        public Timer timer = new Timer();

        public FIRST()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += (sender, ergs) =>
            {
                if (label2.Text == string2)
                {
                    label2.Text = string1;
                    label2.Show();
                    label2.ForeColor = Color.Red;

                }
                else
                    label2.Text = string2;


            };
            timer.Start();




        }

        
         private void timer1_Tick(object sender, EventArgs e)
        {
            Point p1 = new Point();
            
            //PictureBox.MousePosition.ToString();
            if (pictureBox1.Location.X + pictureBox1.Width < 0)
            {
                p1.X = this.Width;

            }
            else
            
                p1.X = pictureBox1.Location.X - 5;
                p1.Y = pictureBox1.Location.Y;
                pictureBox1.Location = p1;
        }

         private void FIRST_Load(object sender, EventArgs e)
         {
             label1.Hide();
             label2.Hide();
             label1.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
             timer1.Start();
             
         }

         private void button1_Click(object sender, EventArgs e)
         {
             LOGIN l = new LOGIN();
             l.Show();
         }

    }
}
