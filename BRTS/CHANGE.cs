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
    public partial class CHANGE : Form
    {
        public CHANGE()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            LOGIN l = new LOGIN();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIP\\SQLEXPRESS;Initial Catalog=brts;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("update regestration set password='"+textBox3.Text+"' where username='"+textBox1.Text+"'and password='"+textBox2.Text+"'",con);
            con.Open();
            
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your Password Is Change Sucessfyully.");
            LOGIN l = new LOGIN();
            l.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SELECTEDSTAND s = new SELECTEDSTAND();
            s.Show();
        }

       

       

       

       
    }
}
