using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_calc_program
{
    public partial class Form1 : Form
    {
        int FirstNumber;
        char Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.All(c => c == '0'))
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text += "1";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.All(c => c == '0'))
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text += "2";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.All(c => c == '0'))
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text += "3";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.All(c => c == '0'))
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text += "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.All(c => c == '0'))
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text += "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.All(c => c == '0'))
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text += "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.All(c => c == '0'))
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text += "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.All(c => c == '0'))
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text += "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.All(c => c == '0'))
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text += "9";
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                FirstNumber = int.Parse(txtDisplay.Text);
                Operation = '+';
                txtDisplay.Text += Operation;
            }
            catch (Exception ex)
            {
                Font CurrentFont = txtDisplay.Font;
                float NewFontSize = 16;
                txtDisplay.Font = new Font(CurrentFont.FontFamily, NewFontSize, CurrentFont.Style);
                
                txtDisplay.Text = ex.Message;
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text += '-';
            }
            else
            {
                try
                {
                    FirstNumber = int.Parse(txtDisplay.Text);
                    Operation = '-';
                    txtDisplay.Text += Operation;
                }
                catch (Exception ex)
                {
                    Font CurrentFont = txtDisplay.Font;
                    float NewFontSize = 16;
                    txtDisplay.Font = new Font(CurrentFont.FontFamily, NewFontSize, CurrentFont.Style);
                    
                    txtDisplay.Text = ex.Message;
                }
            }
        }

        private void mul_Click(object sender, EventArgs e)
        {
            try
            {
                FirstNumber = int.Parse(txtDisplay.Text);
                Operation = '*';
                txtDisplay.Text += Operation;
            }
            catch (Exception ex)
            {
                Font CurrentFont = txtDisplay.Font;
                float NewFontSize = 16;
                txtDisplay.Font = new Font(CurrentFont.FontFamily, NewFontSize, CurrentFont.Style);

                txtDisplay.Text = ex.Message;
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            try
            {
                FirstNumber = int.Parse(txtDisplay.Text);
                Operation = '/';
                txtDisplay.Text += Operation;
            }
            catch (Exception ex)
            {
                Font CurrentFont = txtDisplay.Font;
                float NewFontSize = 16;
                txtDisplay.Font = new Font(CurrentFont.FontFamily, NewFontSize, CurrentFont.Style);

                txtDisplay.Text = ex.Message;
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                Font CurrentFont = txtDisplay.Font;
                float NewFontSize = 16;
                txtDisplay.Font = new Font(CurrentFont.FontFamily, NewFontSize, CurrentFont.Style);

                txtDisplay.Text = "Enter any value";
            }
            else
            {
                int SecondNumber;

                string[] takeSecondNum = txtDisplay.Text.Split(Operation);
                SecondNumber = int.Parse(takeSecondNum[1]);

                if (Operation == '+')
                {
                    txtDisplay.Text = Convert.ToString(FirstNumber + SecondNumber);
                }

                else if (Operation == '-')
                {
                    txtDisplay.Text = Convert.ToString(FirstNumber - SecondNumber);
                }

                else if (Operation == '*')
                {
                    txtDisplay.Text = Convert.ToString(FirstNumber * SecondNumber);
                }

                else if (Operation == '/')
                {
                    try
                    {
                        txtDisplay.Text = Convert.ToString(FirstNumber / SecondNumber);
                    }
                    catch (Exception)
                    {
                        Font CurrentFont = txtDisplay.Font;
                        float NewFontSize = 16;
                        txtDisplay.Font = new Font(CurrentFont.FontFamily, NewFontSize, CurrentFont.Style);

                        txtDisplay.Text = "Enter a valid number.";
                    }
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Font CurrentFont = txtDisplay.Font;
            float NewFontSize = 16;
            txtDisplay.Font = new Font(CurrentFont.FontFamily, NewFontSize, CurrentFont.Style);

            txtDisplay.Text = "Please try small values. Click on CLR.";
        }
    }
}
