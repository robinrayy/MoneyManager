using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyManagerLibrary;

namespace MoneyManager
{
    public partial class FrmMainMenu : Form
    {
        User user = null;
        List<Transaction> TransactionList = null;
        List<string> ComboCat = new List<string>();
        List<string> ComboIncome = new List<string>();
        List<string> ComboExpense = new List<string>();

        public FrmMainMenu(User ImportedUser)
        {
            InitializeComponent();
            this.user = ImportedUser;
            lblHello.Text += user.Nama.ToString();
            dgvData.AutoGenerateColumns = false;
            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dgvData.DataSource = null;

            // Category
            ComboCat.Add("<Select>");
            ComboCat.Add("Income");
            ComboCat.Add("Expense");
            coBoxCategory.DataSource = ComboCat;

            // Income Category
            ComboIncome.Add("Salary");
            ComboIncome.Add("Award");
            ComboIncome.Add("Interest Money");
            ComboIncome.Add("Gifts");
            ComboIncome.Add("Selling");
            ComboIncome.Add("Miscellaneous");

            // Expanse Category
            ComboExpense.Add("Friends & Lover");
            ComboExpense.Add("Food & Beverage");
            ComboExpense.Add("Bills & Utilities");
            ComboExpense.Add("Transportation");
            ComboExpense.Add("Shopping");
            ComboExpense.Add("Entertaintment");
            ComboExpense.Add("Travel");
            ComboExpense.Add("Health & Fitness");
            ComboExpense.Add("Gifts & Donation");
            ComboExpense.Add("Family");
            ComboExpense.Add("Education");
            ComboExpense.Add("Investment");
            ComboExpense.Add("Business");
            ComboExpense.Add("Insurance");
            ComboExpense.Add("Fees & Charges");
            ComboExpense.Add("Miscellaneous");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmGraph(user, ComboIncome, ComboExpense).ShowDialog();
            this.Show();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            double totalIncome = 0, totalExpense = 0;

            try
            {
                using (var transdao = new TransactionDAO())
                {
                    TransactionList = transdao.GetAllTransactionDataByID(user.ID.ToString());
                }
                dgvData.DataSource = TransactionList;
                this.dgvData.Columns[0].DataPropertyName = "Date";
                this.dgvData.Columns[1].DataPropertyName = "Category";
                this.dgvData.Columns[2].DataPropertyName = "SubCategory";
                this.dgvData.Columns[3].DataPropertyName = "Amount";
                this.dgvData.Columns[4].DataPropertyName = "Note";

                foreach (var item in TransactionList)
                {
                    if (item.Category.ToString() == "Income")
                    {
                        totalIncome += item.Amount;
                    }
                    else if (item.Category.ToString() == "Expense")
                    {
                        totalExpense += item.Amount;
                    }
                }
                lblIncome.Text =  "Income   :  Rp. " + totalIncome.ToString() + ",00-";
                lblExpense.Text = "Expense  :  Rp. " + totalExpense.ToString() + ",00-";
                lblTotal.Text = "Account Balance : Rp. " + (totalIncome -totalExpense).ToString() + ",00-";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            
        }

        private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmAddTransaction(user,ComboIncome,ComboExpense).ShowDialog();
            this.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            
            DialogResult dialog = MessageBox.Show("Are you sure ?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                new FrmLogin().ShowDialog();
                this.Close();
            }
            else
            {
                //back to menu
            }
            
        }

        private void radButMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButMonth.Checked == true)
            {
                coBoxMonth.Enabled = true;
                radioButMonth.ForeColor = Color.Black;
            }
            else
            {
                coBoxMonth.Enabled = false;
                radioButMonth.ForeColor = Color.Gray;
            }
        }
        private void radioButSpecDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButSpecDate.Checked == true)
            {
                dtpSpecDate.Enabled = true;
                radioButSpecDate.ForeColor = Color.Black;
            }
            else
            {
                dtpSpecDate.Enabled = false;
                radioButSpecDate.ForeColor = Color.Gray;
            }
        }


        private void manageProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmManageProfile().ShowDialog();
            this.Show();
        }

        private void FrmMainMenu_Resize(object sender, EventArgs e)
        {
            this.dgvData.Columns[0].Width = 15 * this.dgvData.Width / 100;
            this.dgvData.Columns[1].Width = 15 * this.dgvData.Width / 100;
            this.dgvData.Columns[2].Width = 15 * this.dgvData.Width / 100;
            this.dgvData.Columns[3].Width = 15 * this.dgvData.Width / 100;
            this.dgvData.Columns[4].Width = 40 * this.dgvData.Width / 100;
        }


        private void checkBoxCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCategory.Checked == true)
            {
                checkBoxCategory.ForeColor = Color.Black;
                coBoxCategory.Enabled = true;
            }
            else if (checkBoxCategory.Checked == false)
            {
                checkBoxCategory.ForeColor = Color.Gray;
                coBoxCategory.Enabled = false;
                checkBoxSubCat.Checked = false;
            }
        }

        private void checkBoxSubCat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSubCat.Checked == true)
            {
                checkBoxCategory.Checked = true;
                checkBoxSubCat.ForeColor = Color.Black;
                coBoxSubCat.Enabled = true;
            }
            else
            {
                checkBoxSubCat.ForeColor = Color.Gray;
                coBoxSubCat.Enabled = false;
            }


        }

        private void coBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coBoxCategory.SelectedIndex.Equals(0))
            {
                coBoxSubCat.DataSource = null;

            }
            else if (coBoxCategory.SelectedIndex.Equals(1))
            {
                coBoxSubCat.DataSource = ComboIncome;
           
            }
            else if (coBoxCategory.SelectedIndex.Equals(2))
            {
                coBoxSubCat.DataSource = ComboExpense;
                
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FrmMainMenu_Load(null,null);
        }

        private void dtpSpecDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void coBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
