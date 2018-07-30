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

        public FrmMainMenu(User ImportedUser)
        {
            InitializeComponent();
            this.user = ImportedUser;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmAddTransaction().ShowDialog();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comboBox1.Enabled = true;
                radioButton1.ForeColor = Color.Black;
            }
            else
            {
                comboBox1.Enabled = false;
                radioButton1.ForeColor = Color.Gray;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                dateTimePicker1.Enabled = true;
                radioButton2.ForeColor = Color.Black;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                radioButton2.ForeColor = Color.Gray;
            }
        }

        private void manageProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmManageProfile().ShowDialog();
            this.Show();
        }
    }


}
