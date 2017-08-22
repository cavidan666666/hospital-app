using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console.Ap_Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName, PassWord;

            UserName = textBox1.Text;
            PassWord = textBox2.Text;

            if(UserName == "admin" && PassWord == "admin")
            {

                this.label3.Text = "UserName ve PassWord Duzgundur: Daxil Ola Bileceyiniz Hisseler Bunlardir";
                this.label4.Text = "1.Xestexananin Sobeleri:";
                this.label5.Text = "2.Xestexananin Hekimleri:";
                this.label6.Text = "Zehmet Olmazsa Seciminizi Edin";
             
            }
            else
            {
                this.label3.Text = "UserName ve PassWord Duzgun Deyil";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string istfadi, istfprlu;
            istfadi = textBox1.Text;
            istfprlu = textBox2.Text;
            if (istfadi == "admin" && istfprlu == "admin")
            {
                listBox1.Items.Add("1.1: Kordiologiya");
                listBox1.Items.Add("1.2: Travmatologiya");
                listBox1.Items.Add("1.3: Nevrologiya");
                listBox1.Items.Add("1.4: Stomotoloq");
            }
            else
            {
                
                MessageBox.Show("Istifadeci adi ve Istifadeci parolu Dogru Deyil");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name, surname;
            name = textBox1.Text;
            surname = textBox2.Text;

            if (name == "admin" && surname == "admin")
            {
                listBox2.Items.Add("2.1: Kordiologiya Hekimi: ID 055");
                listBox2.Items.Add("2.2: Travmatalogiya: ID 023");
                listBox2.Items.Add("2.3: Nevrologiya Hekimi: ID 045");
                listBox2.Items.Add("2.4: Stomotoloq Hekimi: ID 638");
            }
            else
            {
                MessageBox.Show("Istifadeci adi ve Istifadeci Parolu Dogru Deyil");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(textBox3.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(textBox4.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
          
            listBox2.Items.Add(textBox6.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(textBox5.Text);
        }
    }
}
