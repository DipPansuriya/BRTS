using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mime;
using System.Net.Mail;

namespace BRTS
{
    public partial class FORGET : Form
    {
        public FORGET()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con=new SqlConnection("Data Source=DIP\\SQLEXPRESS;Initial Catalog=brts;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("select username,hobby from regestration where username='"+textBox1.Text+"'",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               
                 if(textBox1.Text==""||textBox2.Text=="" || textBox1.Text==""&& textBox2.Text=="")
                {
                    MessageBox.Show("Please Enter The Usernbame And Hobby.");
                }
                     else if(dr["username"].ToString()==textBox1.Text && dr["hobby"].ToString()==textBox2.Text)
                {
                    MessageBox.Show("Your Username And Hobby Is Right.");
                    MessageBox.Show("Set Your New Password.");
                    RESET r = new RESET();
                    r.Show();
                }
    
                else
                {
                    MessageBox.Show("Invalid Username And Hobby.");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                
            }

            con.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

       

       

        
    }
}
