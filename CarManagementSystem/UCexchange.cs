using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class UCexchange : UserControl
    {
        public UCexchange()
        {
            InitializeComponent();
        }

        private void button_enteragain_Click(object sender, EventArgs e)
        {
            mytextBox_exchange.Clear();
            mytextBox_dollar.Clear();
            mytextBox_riel.Clear();
            mytextBox_resultdollar.Clear();
            mytextBox_resultriel.Clear();
        }

        private void CalculateRielResult()
        {
            if (double.TryParse(mytextBox_dollar.Text, out double dollarAmount) &&
                double.TryParse(mytextBox_exchange.Text, out double interestRate))
            {
                double rielAmount = dollarAmount * interestRate;
                mytextBox_resultriel.Text = rielAmount.ToString("F2") + " ៛";
            }
        }

        private void CalculateDollarResult()
        {
            if (double.TryParse(mytextBox_riel.Text, out double rielAmount) &&
                double.TryParse(mytextBox_exchange.Text, out double interestRate))
            {
                double dollarAmount = rielAmount / interestRate;
                mytextBox_resultdollar.Text = dollarAmount.ToString("F2") + " $";
            }
        }

        private void mytextBox_exchange_TextChanged(object sender, EventArgs e)
        {
            CalculateRielResult();
            CalculateDollarResult();
        }

        private void mytextBox_dollar_TextChanged(object sender, EventArgs e)
        {
            CalculateRielResult();
        }

        private void mytextBox_riel_TextChanged(object sender, EventArgs e)
        {
            CalculateDollarResult();
        }
    }
}
