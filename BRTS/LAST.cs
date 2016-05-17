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
    public partial class LAST : Form
    {

        string string1 = "THANK YOU ";
        string string2 = "FOR USING BRTS";

        private Timer timer = new Timer();
        public LAST(string a)
        {
            InitializeComponent();
            label3.Text = a;
            timer.Interval = 1000;
            timer.Tick += (sender, ergs) =>
            {
                if (label2.Text == string2)
                {
                    label2.Text = string1;
                    label2.Show();
                    label2.ForeColor = Color.Purple;

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

        private void LAST_Load(object sender, EventArgs e)
        {
            label1.Hide();
            label3.Hide();
            label1.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            
            Point p2 = new Point();
           
            if (pictureBox2.Location.X + pictureBox2.Width < 0)
            {
                p2.X = this.Width;
                

            }
            else
               
                p2.X =  pictureBox2.Location.X -5;
            p2.Y = pictureBox2.Location.Y;
            pictureBox2.Location = p2;
        
        }

     private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                PAYMENT p = new PAYMENT(label3.Text);
                p.Show();
            }
            else if (radioButton3.Checked == true)
            {
                DEBIT d = new DEBIT(label3.Text);
                d.Show();
            }
        }

     private void timer3_Tick(object sender, EventArgs e)
     {
         Point p1 = new Point();
         label1.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();

         if (label4.Location.X + label4.Width < 0)
         {
             p1.X = this.Width;

         }
         else
             p1.X = label4.Location.X - 5;
         p1.Y = label4.Location.Y;
         label4.Location = p1;
     }

 /*  private void button1_Click_1(object sender, EventArgs e)
     {
         if (radioButton2.Checked == true)
         {
             PAYMENT p = new PAYMENT(label3.Text);
             p.Show();
         }
         else if (radioButton3.Checked == true)
         {
             DEBIT d = new DEBIT(label3.Text);
             d.Show();
         }
     }*/

     private void radioButton2_CheckedChanged(object sender, EventArgs e)
     {
         PAYMENT p = new PAYMENT(label3.Text);
         p.Show();
         

     }

     private void radioButton3_CheckedChanged(object sender, EventArgs e)
     {
         DEBIT d = new DEBIT(label3.Text);
         d.Show();

     }

     
        


        
      
        
       

       

      
      

        }

    }

