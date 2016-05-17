using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace BRTS
{
    public partial class SELECTEDSTAND : Form
    {
        public SELECTEDSTAND()
        {
            InitializeComponent();
        }
        private void button27_Click(object sender, EventArgs e)
        {
            LOGIN l = new LOGIN();
            l.Show();

        }
     /*   private void button1_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");

            j.Show();
            j.comboBox1.Items.Add("Anjli Char Rasta");
            j.comboBox1.Items.Add("Akhabarnagar");
            j.comboBox1.Items.Add("Amabavadi");
            j.comboBox1.Items.Add("Amraivadi");
            j.comboBox1.Items.Add("Ambartower");

            j.comboBox1.Items.Add("A E C");


        }



        private void button2_Click(object sender, EventArgs e)
        {
            JANMARG J = new JANMARG("a");
            J.Show();
            J.comboBox1.Items.Add("Bapunagar");
            J.comboBox1.Items.Add("Bhairavnath Road");
            J.comboBox1.Items.Add("Bhuyangdev");
            J.comboBox1.Items.Add("Bodakdev");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("Chandranagar");
            j.comboBox1.Items.Add("C G Road");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("Danilimda");
            j.comboBox1.Items.Add("Dahrnodhar");
            j.comboBox1.Items.Add("Dhudheshwar");


        }

        private void button5_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("Ellis Bridge");


        }

        private void button6_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("F R");
            j.comboBox1.Items.Add("Fateh Wadi");
            j.comboBox1.Items.Add("F D School");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("Gandhi Ashram");
            j.comboBox1.Items.Add("Gomtipur");
            j.comboBox1.Items.Add("Gujrat University");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("Himalya Mall");


        }

        private void button9_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("ISRO");
            j.comboBox1.Items.Add("Isanpur");

        }

        private void button10_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("Jamalpure");
            j.comboBox1.Items.Add("Jansi Ki Rani");
            j.comboBox1.Items.Add("Javahar Chok");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("Khokhara");
            j.comboBox1.Items.Add("Kankaria");
            j.comboBox1.Items.Add("Kalupur");
            j.comboBox1.Items.Add("Khodiyar Nagar");
        }


        private void button11_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("Lal Darvaja");
            j.comboBox1.Items.Add("Lal Bahadur Stadium");
            j.comboBox1.Items.Add("Law Garden");

        }

        private void button13_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("Maninagar");
            j.comboBox1.Items.Add("Meghaninagar");
            j.comboBox1.Items.Add("Memko");

        }

        private void button14_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("Nroda");
            j.comboBox1.Items.Add("Narol");
            j.comboBox1.Items.Add("Naheru Nagar");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("Odhav");
            j.comboBox1.Items.Add("ONGC");
            j.comboBox2.Items.Add("Odhav");
            j.comboBox2.Items.Add("ONGC");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("Paldi");
            j.comboBox1.Items.Add("Pahaladnagar");

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("Rambahg");
            j.comboBox1.Items.Add("Rameshvar");
            j.comboBox1.Items.Add("R.T.O.");
            j.comboBox1.Items.Add("Ranip");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");

            j.Show();
            j.comboBox1.Items.Add("Saraspur");
            j.comboBox1.Items.Add("Sarkhej Road");
            j.comboBox1.Items.Add("S.G. Highway");
            j.comboBox1.Items.Add("Sattadhar");
            j.comboBox1.Items.Add("Sabarmati");
            j.comboBox1.Items.Add("Sonini Chal");
            j.comboBox1.Items.Add("Shivranjni");
            j.comboBox1.Items.Add("Satellite");


        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("Updharna");

        }

        private void button22_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("Vatava");
            j.comboBox1.Items.Add("Vasana");
            j.comboBox1.Items.Add("Vijay Park");
            j.comboBox1.Items.Add("VejalPur");

        }

        private void button23_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("Wadaj");


        }

        private void button25_Click(object sender, EventArgs e)
        {
            JANMARG j = new JANMARG("a");
            j.Show();
            j.comboBox1.Items.Add("Yogeshwari");


        }

        private void label4_Click(object sender, EventArgs e)
        {
            LOGIN l = new LOGIN();
            l.Close();
            REGESTRATION r = new REGESTRATION();
            r.Close();
            CHANGE c = new CHANGE();
            c.Close();
            SELECTEDSTAND s = new SELECTEDSTAND();
            s.Close();


        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            CHANGE c = new CHANGE();
            c.Show();

        }
        */




    }
}
