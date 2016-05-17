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
    public partial class PAYMENT : Form
    {
        public PAYMENT(string a)
        {
            InitializeComponent();
            textBox1.Text = a;
        }
        string a;
        private void PAYMENT_Load(object sender, EventArgs e)
        {
            a = textBox1.Text;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please Enter The credit CardNo And PinNo.");
            }
            else
            {
                try {
                    int temp = Convert.ToInt32(textBox2.Text);
                    int temp1 = Convert.ToInt32(textBox3.Text);
                    SqlConnection con = new SqlConnection("Data Source=DIP\\SQLEXPRESS;Initial Catalog=brts;Integrated Security=True;Pooling=False");
                    SqlCommand cmd = new SqlCommand("insert into credit(cre_no,pin_no) values('" + textBox2.Text + "','" + textBox3.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Payment Is Pay.");
                    con.Close();
                    FIRST f = new FIRST();
                    f.Show();
                }
                catch(Exception h)
                {
                    MessageBox.Show("Enter the Proper Credit Card no or Pin no.");
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                




                /* int a = 16;
                 if (Convert.ToInt64(textBox2.Text) == Convert.ToInt64(a) )
                 {
                     MessageBox.Show("It Is valid.");
                 }
                 else 
                 {
                     MessageBox.Show("Your Paymanet is not  pay.");
                 }*/
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DEBIT d = new DEBIT(textBox1.Text);
            d.Show();
        }

        private void yESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN l = new LOGIN();
            l.Show();
          //PAYMENT p = new PAYMENT(textBox1.Text);
            //p.Close();
        }

        private void nOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PAYMENT p = new PAYMENT(textBox1.Text);
            p.Show();
            
        }

      
        
    }
}
