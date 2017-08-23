using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XSTXNA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Sece Bileceyiniz Hisseler";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listbox1.Items.Add("1.Kordiologiya");
            listbox1.Items.Add("2.Nevrologiya");
            listbox1.Items.Add("3.Travmatologiya");
            listbox1.Items.Add("4.Mental");
        }

        private void fr_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listbox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listbox1.Items.Remove(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("2.1: Kordiologiya Hekimi");
            listBox2.Items.Add("2.2: Travmatologiya Hekimi");
            listBox2.Items.Add("2.3: Nevrologiya Hekimi");
            listBox2.Items.Add("2.4: Mental Hekimi");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(textBox2.Text);
        }
    }
}
