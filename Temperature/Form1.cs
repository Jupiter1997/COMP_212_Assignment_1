using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 

        private void button1_Click(object sender, EventArgs e)
        {

            // lblResult.Text = Convert.ToString((5/9) * (Convert.ToDouble(lblInput.Text) - 32)) + " °";
            double input = Convert.ToDouble(lblInput.Text);
            double result;

            result = (5 * (input - 32)) / 9;

            lblResult.Text = result.ToString("0.##");

        }
    }
}
