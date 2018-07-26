using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManager
{
    public partial class FrmRegis : Form
    {
        public FrmRegis()
        {
            InitializeComponent();
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {

        }

        private void checkboxSafetyQuestion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxSafetyQuestion.Checked == true)
            {
                lblQuestion.ForeColor = Color.Black;
                lblAnswer.ForeColor = Color.Black;
                lblQestionMark.ForeColor = Color.Black;
                txtQuestion.Enabled = true;
                txtAnswer.Enabled = true;
            }
            else {
                lblQuestion.ForeColor = Color.Gray;
                lblAnswer.ForeColor = Color.Gray;
                lblQestionMark.ForeColor = Color.Gray;
                txtQuestion.Enabled = false;
                txtAnswer.Enabled = false;
            }
        }
    }
}
