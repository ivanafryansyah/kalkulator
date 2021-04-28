using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorIvan
{
    public partial class Form1 : Form
    {
        double angka1;
        string hitung;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void Buttonplus_Click(object sender, EventArgs e)
        {
            angka1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            hitung = "+";
        }

        private void Buttonminus_Click(object sender, EventArgs e)
        {
            angka1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            hitung = "-";
        }

        private void Buttonkali_Click(object sender, EventArgs e)
        {
            angka1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            hitung = "*";
        }

        private void Buttonbagi_Click(object sender, EventArgs e)
        {
            angka1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            hitung = "/";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void ButtonSMdg_Click(object sender, EventArgs e)
        {
            double angka2;
            double hasil;
            angka2 = Convert.ToDouble(textBox1.Text);

            if (hitung == "+")
            {
                hasil = (angka1 + angka2);
                textBox1.Text = Convert.ToString(hasil);
                angka1 = hasil;
            }
            if (hitung == "-")
            {
                hasil = (angka1 - angka2);
                textBox1.Text = Convert.ToString(hasil);
                angka1 = hasil;
            }
            if (hitung == "*")
            {
                hasil = (angka1 * angka2);
                textBox1.Text = Convert.ToString(hasil);
                angka1 = hasil;
            }
            if (hitung == "/")
            {
                if (angka2 == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    hasil = (angka1 / angka2);
                    textBox1.Text = Convert.ToString(hasil);
                    angka1 = hasil;
                }
            }
        }
    }
}
