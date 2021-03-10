using System;
using System.Windows.Forms;

namespace Amortization
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {

        public MainForm()
        {
            InitializeComponent();
        }

        double loan, rebate, rate = 0, principalPayment, months, interest, pmt, sum_interest = 0, sum_principal = 0, sum_payment = 0, temp_in, temp_pri,temp_pay;

        private void APRcomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == (char)Keys.Decimal);
        }

        private void APRcomboBox_Enter(object sender, EventArgs e)
        {
            APRcomboBox.SelectAll();
        }

        private void APRcomboBox_Click(object sender, EventArgs e)
        {
            APRcomboBox.SelectAll();
        }

        private void loan_amount_Click(object sender, EventArgs e)
        {
            loan_amount.SelectAll();
        }

        private void loan_amount_Enter(object sender, EventArgs e)
        {
            loan_amount.SelectAll();
        }

        private void rebate_amt_Click(object sender, EventArgs e)
        {
            rebate_amt.SelectAll();
        }

        private void rebate_amt_Enter(object sender, EventArgs e)
        {
            rebate_amt.SelectAll();
        }

        private void rebate_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar== (char)Keys.Decimal);
        }

        private void loan_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == (char)Keys.Decimal);
        }

        private void month_groupBox_TextChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void rebate_amt_TextChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void APRcomboBox_TextChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void loan_amount_TextChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void rebate_Check_CheckedChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            if (rebate_Check.Checked)
            {
                rebate_amt.Enabled = true;
            }
            else
            {
                rebate_amt.Enabled = false;
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                temp_in = 0;
                temp_pay = 0;
                temp_pri = 0;
                listBox.Items.Clear();
                double.TryParse(loan_amount.Text, out loan);
                rate = Convert.ToDouble(APRcomboBox.Text);
                rate /= 100;
                if (six_months.Checked)
                {
                    months = 6;
                }
                else if (one_year.Checked)
                {
                    months = 12;
                }
                else if (eighteen_months.Checked)
                {
                    months = 18;
                }
                else if (two_years.Checked)
                {
                    months = 24;
                }
                if (rebate_Check.Checked)
                {
                    rebate = Convert.ToDouble(rebate_amt.Text);
                }
                else
                {
                    rebate = 0;
                }
                loan -= rebate;
                string formatString = "{0,5}{1,12}{2,12}{3,12}{4,12}";
                principalPayment = rate / 12 * (loan + 0 * Math.Pow(1 + rate / 12, months)) / ((Math.Pow(1 + rate / 12, months) - 1));
                interest = loan * rate / 12;
                pmt = principalPayment + interest;
                for (int monthsCounter = 1; monthsCounter <= months; monthsCounter++)
                {
                    temp_in += interest;
                    temp_pay += pmt;
                    temp_pri += principalPayment;
                    loan -= principalPayment;
                    listBox.Items.Add(String.Format(formatString, monthsCounter, interest.ToString("c"), principalPayment.ToString("N2"), pmt.ToString("N2"), loan.ToString("N2")));
                    interest = loan * rate / 12;
                    principalPayment = pmt - interest;

                }
                listBox.Items.Add("");
                listBox.Items.Add(String.Format("{0,5}{1,12}{2,12}{3,12}", "Total", temp_in.ToString("c"), temp_pri.ToString("N2"), temp_pay.ToString("N2")));
            }
            catch
            {
                MessageBox.Show("Error occurred, please try again.", "Error", MessageBoxButtons.OK);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you confirm to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if (temp_in != 0)
            {
                sum_interest += temp_in;
                sum_payment += temp_pay;
                sum_principal += temp_pri;
                temp_in = 0;
                temp_pay = 0;
                temp_pri = 0;
                listBox.Items.Clear();
                loan_amount.Text = "";
                APRcomboBox.Text = "";
                rebate_amt.Text = "";
                rebate_Check.Checked = false;
                six_months.Checked = true;
                loan_amount.Focus();
            }
        }

        private void display_all_Click(object sender, EventArgs e)
        {
            Total_interest.Text = sum_interest.ToString("c");
            Total_loans.Text = sum_principal.ToString("c");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
