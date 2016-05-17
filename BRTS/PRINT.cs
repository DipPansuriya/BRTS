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

    public partial class lable : Form
    {
        public lable(string n,string a, string b, string t4, string t6, string c, string t5)
        {
            InitializeComponent();
            textBox1.Text = n;
            textBox2.Text = a;
            textBox3.Text = b;
            textBox4.Text = t4;
            textBox5.Text = t6;
            textBox6.Text = c;
            textBox7.Text = t5;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LAST l=new LAST(textBox1.Text);
            l.Show();
          
        }

        private void lable_Load(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();
            label8.Hide();
            timer2.Start();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            Point p1 = new Point();
            label8.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();

           
            if (pictureBox1.Location.X + pictureBox1.Width < 0)
            {
                p1.X = this.Width;

            }
            else

                p1.X = pictureBox1.Location.X - 5;
            p1.Y = pictureBox1.Location.Y;
            pictureBox1.Location = p1;
        }
 
    }
}
