﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName, passWord;
            userName = textBox1.Text;
            passWord = textBox2.Text;

            if(userName == "admin" && passWord == "admin")
            {
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();
            }
            else
            {
                label1.Text = "userName and passWord isn't Correct";
            }
           
        }
       
    }
}
