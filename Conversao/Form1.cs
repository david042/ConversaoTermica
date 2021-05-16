using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double convertToFahrenheit, celsius;
            celsius = Convert.ToDouble(Celsius1.Text);
            convertToFahrenheit = (celsius * 9) / 5 + 32;
            Fahrenheit1.Text = convertToFahrenheit.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double convertToCelsius, fahrenheit;
            fahrenheit = Convert.ToDouble(Fahrenheit2.Text);
            convertToCelsius = (fahrenheit - 32) * 5 / 9;
            Celsius2.Text = convertToCelsius.ToString();
        }
    }
}
