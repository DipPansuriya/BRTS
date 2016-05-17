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
    public partial class RESET : Form
    {
        public RESET()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Please Enter The Details.");
            }
                else if(textBox2.Text!=textBox3.Text)
             {
                 MessageBox.Show("Check Your Password Again . . .");
                }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DIP\\SQLEXPRESS;Initial Catalog=brts;Integrated Security=True;Pooling=False");
                SqlCommand cmd = new SqlCommand("update regestration set password='"+textBox2.Text+"' where username='"+textBox1.Text+"'",con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Is Changed.");
                LOGIN l = new LOGIN();
                l.Show();
            }

        }

       
    }
}
