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
    public partial class DEBIT : Form
    {
        public DEBIT(string a)
        {
            InitializeComponent();
            textBox1.Text = a;

        }
        string a;
        private void DEBIT_Load(object sender, EventArgs e)
        {
            a = textBox1.Text;
        }
        
        private void butto1_click(object sender, EventArgs e)
        {





            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please Enter The Credit CardNo And PinNo.");
            }



            else
            {
                Exception X = new Exception();

                TextBox T = (TextBox)sender;

                try
                {
                    if (T.Text != "-")
                    {
                        int x = int.Parse(T.Text);
                    }
                }
                catch (Exception)
                {
                    try
                    {
                        int CursorIndex = T.SelectionStart - 1;
                        T.Text = T.Text.Remove(CursorIndex, 1);

                        //Align Cursor to same index
                        T.SelectionStart = CursorIndex;
                        T.SelectionLength = 0;
                    }
                    catch (Exception) { }
                }
            }
            SqlConnection con = new SqlConnection("Data Source=DIP-PC\\SQLEXPRESS;Initial Catalog=brts;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("insert into debit(debit_no,pin_no) values('" + textBox2.Text + "','" + textBox3.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Payment Is Pay.");
            con.Close();
        }


        private void yESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FIRST f = new FIRST();
            f.Show();
            //DEBIT d = new DEBIT(textBox1.Text);
            //d.Close();
        }

        private void nOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DEBIT d = new DEBIT(textBox1.Text);
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Invalid DebitCard NO And Password.");
            }
            else
            {
                try
                {
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
                catch (Exception h)
                {
                    MessageBox.Show("Enter the Proper Credit Card no or Pin no.");
                    textBox2.Text="";
                    textBox3.Text = "";
                }
                
            }
        }

    }
}
        



      


        
  