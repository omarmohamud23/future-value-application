using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace future_value_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment =
                Convert.ToDecimal(txtMonthlyIvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
            int years = Convert.ToInt32(txtYears.Text);

            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

            decimal futurevalue = CalculateFuturevalue(monthlyInvestment, months, monthlyInterestRate);

            txtFutureValue.Text = futurevalue.ToString("C");
            txtMonthlyIvestment.Focus();
        }

       

        private decimal CalculateFuturevalue(decimal monthlyInvestment,  int months, decimal monthlyInterestRate)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                            * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
    

      

       
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
           
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
            txtMonthlyIvestment.Text = "";
            txtInterestRate.Text = "";
            txtYears.Text = "";


        }

        private void txtInterestRate_DoubleClick(object sender, EventArgs e)
        {
            txtInterestRate.Text = "12";
        }
    }
}
