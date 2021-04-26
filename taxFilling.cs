using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculatetax_Click(object sender, EventArgs e)
        {
            double personal_income;
            int  inttax_income = Convert.ToInt32(this.taxableincome.Text);

            if (Convert.ToInt32(this.fillingstatus.Text) == 1)
            {
                if (inttax_income < 8350)
                {
                    personal_income = (0.1 * inttax_income);
                }
                else if (inttax_income < 33950)
                {
                    personal_income = (0.1 * 8350) + (0.15 * (inttax_income - 8350));
                }
                else if (inttax_income < 82250)
                {
                    personal_income = (0.15 * 33950) + (0.25 * (inttax_income - 33950));
                }
                else if (inttax_income < 17550)
                {
                    personal_income = (0.25 * 82250) + (0.28 * (inttax_income - 82250));
                }
                else if (inttax_income < 372950)
                {
                    personal_income = (0.28 * 171550) + (0.33 * (inttax_income - 171550));
                }
                else if (inttax_income > 372950)
                {
                    personal_income = (0.33 * 372950) + (0.35 * (inttax_income - 372951));
                }
               }
            else if(Convert.ToInt32(this.fillingstatus.Text) == 2)
            {
                if (inttax_income < 16700)
                {
                    personal_income = (0.1 * inttax_income);
                }
                else if (inttax_income < 67900)
                {
                    personal_income = (0.1 * 16700) + (0.15 * (inttax_income - 16700));
                }
                else if (inttax_income < 137050)
                {
                    personal_income = (0.15 * 67900) + (0.25 * (inttax_income - 67900));
                }
                else if (inttax_income < 208850)
                {
                    personal_income = (0.25 * 67900) + (0.28 * (inttax_income - 67900));
                }
                else if (inttax_income < 372950)
                {
                    personal_income = (0.28 * 208850) + (0.33 * (inttax_income - 208850));
                }
                else if (inttax_income > 372950)
                {
                    personal_income = (0.33 * 372950) + (0.35 * (inttax_income - 372951));
                }
            }
            else if (Convert.ToInt32(this.fillingstatus.Text) == 3)
            {
                if (inttax_income < 8350)
                {
                    personal_income = (0.1 * inttax_income);
                }
                else if (inttax_income < 33950)
                {
                    personal_income = (0.1 * 8350) + (0.15 * (inttax_income - 8350));
                }
                else if (inttax_income < 82250)
                {
                    personal_income = (0.15 * 33950) + (0.25 * (inttax_income - 33950));
                }
                else if (inttax_income < 171550)
                {
                    personal_income = (0.25 * 82250) + (0.28 * (inttax_income - 82250));
                }
                else if (inttax_income < 372950)
                {
                    personal_income = (0.28 * 171550) + (0.33 * (inttax_income - 171550));
                }
                else if (inttax_income > 372950)
                {
                    personal_income = (0.33 * 372950) + (0.35 * (inttax_income - 372951));
                }
            }
            }
            }
        }
