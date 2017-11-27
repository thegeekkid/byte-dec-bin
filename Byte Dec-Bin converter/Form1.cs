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
            this.input.KeyPress += new KeyPressEventHandler(input_KeyPress);
        }

        private void input_KeyPress(object sender, KeyPressEventArgs e)
        {
            String AcceptedKeys = "0123456789";
            if (!(AcceptedKeys.Contains(e.KeyChar.ToString())))
            {
                e.Handled = true;
            }
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            int dec = int.Parse(input.Text);
            if ((dec < 0) || (dec > 255))
            {
                MessageBox.Show("Invalid number - must be between 0 and 255.");
                input.Text = input.Text.Substring(0, input.Text.Length - 1);
                if (input.Text.Length > 0)
                {
                    input.SelectionStart = input.Text.Length;
                    input.SelectionLength = 0;
                }
            }else
            {

            }
        }
    }
}
