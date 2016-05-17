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
    public partial class JANMARG : Form
    {

        string string1 = " TICKET INFORMATION.";
        string string2 = "";

        private Timer timer = new Timer();

        public JANMARG(string d,string p)
        {
            InitializeComponent();
             label14.Text = d;
             comboBox1.Text=p;
             timer.Interval = 1000;
             timer.Tick += (sender, ergs) =>
             {
                 if (label9.Text == string2)
                 {
                     label9.Text = string1;
                     label9.Show();
                     label9.ForeColor = Color.Blue;

                 }
                 else
                     label9.Text = string2;


             };
             timer.Start();



        }



        //string d;
        //string flag;
        private void button14_Click(object sender, EventArgs e)
        {
            LASTSTAND l = new LASTSTAND(label14.Text,comboBox1.SelectedItem.ToString());
            l.Show();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "First Stand." || comboBox2.Text == "Last Stand.")
            {
                MessageBox.Show("Select Your Stand.");
            }
            else
            {
                textBox4.Text = textBox4.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "First Stand." || comboBox2.Text == "Last Stand.")
            {
                MessageBox.Show("Select Your Stand.");
            }
            else
            {
                textBox4.Text = textBox4.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "First Stand." || comboBox2.Text == "Last Stand.")
            {
                MessageBox.Show("Select Your Stand.");
            }
            else
            {
                textBox4.Text = textBox4.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "First Stand." || comboBox2.Text == "Last Stand.")
            {
                MessageBox.Show("Select Your Stand.");
            }
            else
            {
                textBox4.Text = textBox4.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "First Stand." || comboBox2.Text == "Last Stand.")
            {
                MessageBox.Show("Select Your Stand.");
            }
            else
            {
                textBox4.Text = textBox4.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "First Stand." || comboBox2.Text == "Last Stand.")
            {
                MessageBox.Show("Select Your Stand.");
            }
            else
            {
                textBox4.Text = textBox4.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "First Stand." || comboBox2.Text == "Last Stand.")
            {
                MessageBox.Show("Select Your Stand.");
            }
            else
            {
                textBox4.Text = textBox4.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "First Stand." || comboBox2.Text == "Last Stand.")
            {
                MessageBox.Show("Select Your Stand.");
            }
            else
            {
                textBox4.Text = textBox4.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "First Stand." || comboBox2.Text == "Last Stand.")
            {
                MessageBox.Show("Select Your Stand.");
            }
            else
            {
                textBox4.Text = textBox4.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "First Stand." || comboBox2.Text == "Last Stand.")
            {
                MessageBox.Show("Select Your Stand.");
            }
            else
            {
                textBox4.Text = textBox4.Text + "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "0" || textBox4.Text == "")
            {
                MessageBox.Show("Please Enter The Adult.");
                textBox4.Clear();
            }
                else if(textBox4.Text == "1")
            {
                MessageBox.Show("Total Km Is :8");
                textBox6.Text = textBox6.Text + "8";
                textBox5.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox2.Text));
             }
                else if(textBox4.Text=="2")
            {
                MessageBox.Show("Total Km Is :14");
                textBox6.Text = textBox6.Text + "14";
                textBox5.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox2.Text));
            
                }
            else if (textBox4.Text == "3")
            {
                MessageBox.Show("Total Km Is :6");
                textBox6.Text = textBox6.Text + "6";
                textBox5.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox2.Text));

            }
            else if (textBox4.Text == "4")
            {
                MessageBox.Show("Total Km Is :15");
                textBox6.Text = textBox6.Text + "15";
                textBox5.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox2.Text));

            }
            else if (textBox4.Text == "5")
            {
                MessageBox.Show("Total Km Is :7");
                textBox6.Text = textBox6.Text + "7";
                textBox5.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox2.Text));

            }
            else if (textBox4.Text == "6")
            {
                MessageBox.Show("Total Km Is :11");
                textBox6.Text = textBox6.Text + "11";
                textBox5.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox2.Text));

            }
            else if (textBox4.Text == "7")
            {
                MessageBox.Show("Total Km Is :14");
                textBox6.Text = textBox6.Text + "14";
                textBox5.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox2.Text));

            }
            else if (textBox4.Text == "8")
            {
                MessageBox.Show("Total Km Is :16");
                textBox6.Text = textBox6.Text + "16";
                textBox5.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox2.Text));

            }
            else if (textBox4.Text == "9")
            {
                MessageBox.Show("Total Km Is :4");
                textBox6.Text = textBox6.Text + "4";
                textBox5.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox2.Text));

            }

            else
            {
                MessageBox.Show("Total Km Is :12");
                textBox6.Text = textBox6.Text + "12";
                textBox5.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox2.Text));
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
        string u;
        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "First Stand." || comboBox1.Text == "Last Stand.")
            {
                MessageBox.Show("Please Select Stand First");
            }
            else
            {
                string d = label14.Text;
                u = comboBox1.SelectedItem.ToString();
                string b = comboBox2.SelectedItem.ToString();
                string c = dateTimePicker1.Value.ToString();
                SqlConnection con = new SqlConnection("Data Source=DIP\\SQLEXPRESS;Initial Catalog=brts;Integrated Security=True;Pooling=False");
                SqlCommand cmd = new SqlCommand("insert into janmarg(firstname,f_stand,l_stand,adult,totalkm,date,fare) values('" + label14.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + b + "','" + textBox4.Text + "','" + textBox6.Text + "','" + c + "','" + textBox5.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                 lable p1 = new lable(label14.Text, comboBox1.SelectedItem.ToString(), b, textBox4.Text, textBox6.Text, c, textBox5.Text);
                p1.Show();
            }
        }

   
  /*    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
       {
            flag = comboBox1.SelectedItem.ToString();
            label10.Text = flag;
           
            /*SqlConnection con = new SqlConnection("Data Source=DIP-PC\\SQLEXPRESS;Initial Catalog=brts;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("Select * From station", con);
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader DR = cmd.ExecuteReader();
            comboBox1.DataSource = DR;
            comboBox1.
            
   }*/

      
      /*  private void JANMARG_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'brtsDataSet.station' table. You can move, or remove it, as needed.
            this.stationTableAdapter.Fill(this.brtsDataSet.station);
            label10.Text = flag;
             //d=label14.Text;
           
        }
        */
        

        private void button14_Click_1(object sender, EventArgs e)
        {
            string d;
             d=label14.Text; 
            LASTSTAND l = new LASTSTAND(d,u);
            l.Show();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            CHANGE c = new CHANGE();
            c.Show();
        }

 private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
 {
    
    
     
     LASTSTAND l = new LASTSTAND(label14.Text, comboBox1.SelectedItem.ToString());
     this.Hide();
     
     l.Show();

     
    
 }

 private void JANMARG_Load(object sender, EventArgs e)
 {
     comboBox1.Text = "First Stand.";
     comboBox2.Text = "Last Stand.";
     label10.Hide();
     label10.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
     timer1.Start();
    
 }
 string w;
 private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
 {
     u = comboBox1.SelectedItem.ToString();
     w = comboBox2.SelectedItem.ToString();
     MessageBox.Show("Your First Stand is :"+" " + u + "\n \n Your Last Stand is :"+" " + w);
    
     
 }

 private void button14_Click_2(object sender, EventArgs e)
 {
     this.Hide();
     FIRST f = new FIRST();
     f.ShowDialog();
     f.Close();
     this.Close();
 }





        
    }
}
