using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManager
{
    public partial class FrmAddTransaction : Form
    {
        AddController ctrl = new AddController();
        List<string> ComboB1 = new List<string>();
        List<string> ComboIncome = new List<string>();
        List<string> ComboExpanse = new List<string>();
        public FrmAddTransaction()
        {
            InitializeComponent();

            // Category
            ComboB1.Add("<Select>");
            ComboB1.Add("Income");
            ComboB1.Add("Expense");
            comboBox1.DataSource = ComboB1;

            // Income Category
            ComboIncome.Add("Salary");
            ComboIncome.Add("Award");
            ComboIncome.Add("Interest Money");
            ComboIncome.Add("Gifts");
            ComboIncome.Add("Selling");
            ComboIncome.Add("Miscellaneous");

            // Expanse Category
            ComboExpanse.Add("Friends & Lover");
            ComboExpanse.Add("Food & Beverage");
            ComboExpanse.Add("Bills & Utilities");
            ComboExpanse.Add("Transportation");
            ComboExpanse.Add("Shopping");
            ComboExpanse.Add("Entertaintment");
            ComboExpanse.Add("Travel");
            ComboExpanse.Add("Health & Fitness");
            ComboExpanse.Add("Gifts & Donation");
            ComboExpanse.Add("Family");
            ComboExpanse.Add("Education");
            ComboExpanse.Add("Investment");
            ComboExpanse.Add("Business");
            ComboExpanse.Add("Insurance");
            ComboExpanse.Add("Fees & Charges");
            ComboExpanse.Add("Miscellaneous");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(0))
            {
                comboBox2.DataSource = null;
                comboBox2.Enabled = false;
            }
            else if (comboBox1.SelectedIndex.Equals(1))
            {
                comboBox2.DataSource = ComboIncome;
                comboBox2.Enabled = true;
            }
            else if (comboBox1.SelectedIndex.Equals(2))
            {
                comboBox2.DataSource = ComboExpanse;
                comboBox2.Enabled = true; ;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str;
            e.Handled = ctrl.NumberValidation(str = e.KeyChar.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
