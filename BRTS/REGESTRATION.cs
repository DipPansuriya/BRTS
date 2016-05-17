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
    public partial class REGESTRATION : Form 
    {
        public REGESTRATION()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void REGESTRATION_Load(object sender, EventArgs e)
        {
            //for (int i = 1; i <= 31;i++ ) 
            //{
            //    comboBox1.Items.Add(i);
            //}
            //for (int j = 0; j <= 12; j++)
            //{
            //    comboBox2.Items.Add(j);
            //}
            //for (int k = 1800; k <= 2012; k++)
            //{
            //    comboBox3.Items.Add(k);
            //}
            //comboBox1.Text = "DATE";
            //comboBox2.Text = "MONTH";
            //comboBox3.Text = "YEAR";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" )
            {
                MessageBox.Show("Invalid Data Filled.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();

            }
            else
            {
               // string c = comboBox1.SelectedItem + ":" + comboBox2.SelectedItem + ":" + comboBox3.SelectedItem;
                SqlConnection con = new SqlConnection("Data Source=DIP\\SQLEXPRESS;Initial Catalog=brts;Integrated Security=True;Pooling=False");
                SqlCommand cmd = new SqlCommand("insert into regestration(Firstname,Middlename,Lastname,Address,Pincode,Mobileno,Username,Password,Hobby) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')", con);
              //  SqlCommand sqlcmd = new SqlCommand("insert into image(image) values('"+pictureBox1.Image+"')",con);
               // label12.Text = "insert into regestration(Firstname,Middlename,Lastname,Address,Pincode,Mobileno,Birthdate,Username,Password,Hobby) values('" + textBox1.Text + "','" + textBox2.Text + "'','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + c + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "'";
                con.Open();
                cmd.ExecuteNonQuery();
                //sqlcmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Regestration Is Sucessfully.");
                LOGIN l = new LOGIN();
                l.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        

        

       
    }
}
