﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parse_stringiSayiyaCevirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            decimal birim_fiyat;
            birim_fiyat = decimal.Parse(textBox1.Text);
            textBox1.Text = birim_fiyat.ToString("N0");
            textBox1.SelectionStart = textBox1.Text.Length;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal toplam_tutar;
            toplam_tutar = decimal.Parse(textBox1.Text) * decimal.Parse(textBox2.Text);
            label4.Text = toplam_tutar.ToString("C0"); //para birimi formatında göstercek.
        }
    }
}
