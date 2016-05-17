using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BRTS
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            REGESTRATION r = new REGESTRATION();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FORGET f = new FORGET();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CHANGE c = new CHANGE();
            c.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Enter User Name And Password.");
            }

                
         //   else if ("Username".ToString() != textBox1.Text || "Password".ToString() != textBox2.Text)
           // {
             //   MessageBox.Show("Invalid User Name And Password.");
               // textBox1.Clear();
               // textBox2.Clear();
            //}
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DIP\\SQLEXPRESS;Initial Catalog=brts;Integrated Security=True;Pooling=False");
                SqlCommand cmd = new SqlCommand("select username,password from regestration where Username='" + textBox1.Text + "'and password='" + textBox2.Text + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["Username"].ToString() == textBox1.Text && dr["Password"].ToString() == textBox2.Text)
                    {
                        MessageBox.Show("Wel Come : " +" "+ textBox1.Text+" " + " To BRTS." + "\n \n" + " Login Sucessfully.");
                        // MessageBox.Show();
                        JANMARG ja = new JANMARG(textBox1.Text, "");
                        ja.Show();
                    }


                    else
                    {
                        MessageBox.Show("Invalid Username Or Password.");
                    }


                }
                else 
                {
                    MessageBox.Show("Incorrect Username And Password."+"\n\n"+"Please Enter The Correct Username And Password. ");
                }

                JANMARG j = new JANMARG(textBox1.Text, "");

                con.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             Point p1 = new Point();
            label7.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();

            if (label6.Location.X + label6.Width < 0)
            {
                p1.X = this.Width;

            }
            else
                p1.X = label6.Location.X - 5;
            p1.Y = label6.Location.Y;
            label6.Location=p1;
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();
            label7.Hide();
            timer1.Start();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        }

    }

