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
    public partial class LASTSTAND : Form
    {
        public LASTSTAND(string g,string o)
        {
            
            InitializeComponent();
             label4.Text=g;
             label5.Text = o;
             
        }
        string g;
        string o;
            private void button1_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            this.Hide();
            j.comboBox1.Text=o;
            j.comboBox2.Items.Add("Anjli Char Rasta");
            j.comboBox2.Items.Add("Akhabarnagar");
            j.comboBox2.Items.Add("Amabavadi");
            j.comboBox2.Items.Add("Amraivadi");
            j.comboBox2.Items.Add("Ambartower");
            j.comboBox2.Items.Add("A E C");
         
           
          // LASTSTAND l = new LASTSTAND(g,o);
          //  l.Close();
    
            }

        private void button2_Click(object sender, EventArgs e)
        {
            JANMARG J = new JANMARG(label4.Text,o);
            J.Show();
            J.comboBox1.Text = o;
            J.comboBox2.Items.Add("Bapunagar");
            J.comboBox2.Items.Add("Bhairavnath Road");
            J.comboBox2.Items.Add("Bhuyangdev");
            J.comboBox2.Items.Add("Bodakdev");
            this.Hide();
          // LASTSTAND l = new LASTSTAND(g,o);
            //l.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("Chandranagar");
            j.comboBox2.Items.Add("C G Road");
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("Danilimda");
            j.comboBox2.Items.Add("Dahrnodhar");
            j.comboBox2.Items.Add("Dhudheshwar");
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("Ellis Bridge");
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("F R");
            j.comboBox2.Items.Add("Fateh Wadi");
            j.comboBox2.Items.Add("F D School");
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("Gandhi Ashram");
            j.comboBox2.Items.Add("Gomtipur");
            j.comboBox2.Items.Add("Gujrat University");
            this.Hide();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("Himalya Mall");
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("ISRO");
            j.comboBox2.Items.Add("Isanpur");
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("Jamalpure");
            j.comboBox2.Items.Add("Jansi Ki Rani");
            j.comboBox2.Items.Add("Javahar Chok");
            this.Hide();
        
        }

        private void button11_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("Khokhara");
            j.comboBox2.Items.Add("Kankaria");
            j.comboBox2.Items.Add("Kalupur");
            j.comboBox2.Items.Add("Khodiyar Nagar");
            this.Hide();
        
        }

        private void button12_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("Lal Darvaja");
            j.comboBox2.Items.Add("Lal Bahadur Stadium");
            j.comboBox2.Items.Add("Law Garden");
            this.Hide();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("Maninagar");
            j.comboBox2.Items.Add("Meghaninagar");
            j.comboBox2.Items.Add("Memko");
            this.Hide();
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("Nroda");
            j.comboBox2.Items.Add("Narol");
            j.comboBox2.Items.Add("Naheru Nagar");
            this.Hide();
     
        }

        private void button15_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("Odhav");
            j.comboBox2.Items.Add("ONGC");
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("Paldi");
            j.comboBox2.Items.Add("Pahaladnagar");
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("Rambahg");
            j.comboBox2.Items.Add("Rameshvar");
            j.comboBox2.Items.Add("R.T.O.");
            j.comboBox2.Items.Add("Ranip");
            this.Hide();
       
        }

        private void button19_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("Saraspur");
            j.comboBox2.Items.Add("Sarkhej Road");
            j.comboBox2.Items.Add("S.G. Highway");
            j.comboBox2.Items.Add("Sattadhar");
            j.comboBox2.Items.Add("Sabarmati");
            j.comboBox2.Items.Add("Sonini Chal");
            j.comboBox2.Items.Add("Shivranjni");
            j.comboBox2.Items.Add("Satellite");
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("Updharna");
            this.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("Vatava");
            j.comboBox2.Items.Add("Vasana");

            j.comboBox2.Items.Add("Vijay Park");
            j.comboBox2.Items.Add("VejalPur");
            this.Hide();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("Wadaj");
            this.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            
        }

        private void button25_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG(label4.Text,o);
            j.Show();
            j.comboBox1.Text = o;
            j.comboBox2.Items.Add("Yogeshwari");
            this.Hide();
        }

        private void LASTSTAND_Load(object sender, EventArgs e)
        {
            g=label4.Text;
            o = label5.Text;
          
        }

       
        

       
  
    }
}
