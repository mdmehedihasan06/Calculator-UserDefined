using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        Calculation aCalculation = new Calculation();
        
        public CalculatorUI()
        {
            InitializeComponent();
        }

        public void GetValue()
        {
            aCalculation.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculation.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            GetValue();
            //aCalculation.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            //aCalculation.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            aCalculation.result = aCalculation.Add();
            resultTextBox.Text = aCalculation.result.ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            GetValue();
            aCalculation.result = aCalculation.Subtract();
            resultTextBox.Text = aCalculation.result.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            GetValue();
            aCalculation.result = aCalculation.Multiply();
            resultTextBox.Text = aCalculation.result.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            GetValue();
            aCalculation.result = aCalculation.Divide();
            resultTextBox.Text = aCalculation.result.ToString();
        }

       
    }
}
