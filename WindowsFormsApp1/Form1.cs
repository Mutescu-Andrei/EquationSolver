﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rezolva_Click(object sender, EventArgs e)
        {
            double a, b, c, delta, re, im;
            try
            {
                a = Convert.ToDouble(camp_a.Text);
                try
                {
                    b = Convert.ToDouble(camp_b.Text);
                    try
                    {
                        c = Convert.ToDouble(camp_c.Text);
                        if (a != 0)
                        {
                            delta = b * b - 4 * a * c;
                        if (delta < 0)
                            {
                                re = -b / (2 * a);
                                im = Math.Sqrt(-delta) / (2 * a);
                                String text = "Complex solution : \r\n";
                                text += "x1=" + re + "+i" + im;
                                text += "\r\nx2=" + re + "-i" + im;
                                rez.Text = text;
                            }
                            else
                            {
                                re = -b / (2 * a);
                                im = Math.Sqrt(delta) / (2 * a);
                                String text = "Real solution : \r\n";
                                text += "x1=" + (re + im);
                                text += "\r\nx2=" + (re - im);
                                rez.Text = text;
                            }
                        }
                        else
                        {
                            if (b != 0)
                            {
                                String text = "First order equation \r\n";
                                text += "Solution: ";
                                text += Convert.ToString(-c / b);
                                rez.Text = text;
                            }
                            else
                            {
                                if (c != 0)
                                    rez.Text = "No solutions";
                                else
                                    rez.Text = "2nd order solution, infinity of solutions";
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Check input for c!", "Caution...");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Check input for b!", "Caution...");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Check input for a!", "Atentie...");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
