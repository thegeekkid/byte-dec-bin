using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Byte_Dec_Bin_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void input_TextChanged(object sender, EventArgs e)
        {
            String AcceptedKeys = "0123456789";
            string validated = "";
            foreach (char c in input.Text)
            {
                if (AcceptedKeys.Contains(c)) {
                    validated += c;
                }
            }
            input.Text = validated;
            input.SelectionStart = input.Text.Length;
            input.SelectionLength = 0;

            if (input.Text != "")
            {
                int dec = int.Parse(input.Text);
                if ((dec < 0) || (dec > 255))
                {
                    MessageBox.Show("Invalid number - must be between 0 and 255.");
                    input.Text = input.Text.Substring(0, input.Text.Length - 1);
                    input.SelectionStart = input.Text.Length;
                    input.SelectionLength = 0;
                }
                else
                {
                    int current = 128;
                    string bin = "";
                    do
                    {
                        if (dec >= current)
                        {
                            bin = 1 + bin;
                            dec = (dec - current);
                        }
                        else
                        {
                            bin = 0 + bin;
                        }

                        if (current == 1)
                        {
                            current = 0;
                        }
                        else
                        {
                            current = (current / 2);
                        }

                    } while (current > 0);

                    output.Text = bin;
                }
            }else
            {
                output.Text = "";
            }


            
        }
    }
}
