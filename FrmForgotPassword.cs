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
    public partial class FrmForgotPassword : Form
    {
        public FrmForgotPassword()
        {
            InitializeComponent();
        }

        private void radioButtonEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEmail.Checked == true)
            {
                txtEmail.Enabled = true;
                lblEmail.Enabled = true;
                lblEmailDesc.Enabled = true;
                //
                txtAnswer.Enabled = false;
                txtID.Enabled = false;
                lblID.Enabled = false;
                lblQuestion.Enabled = false;
                Lbl_Question.Enabled = false;
                lblAnswer.Enabled = false;
            }
        }

        private void radioButtonID_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonID.Checked == true)
            {
                txtEmail.Enabled = false;
                lblEmail.Enabled = false;
                lblEmailDesc.Enabled = false;
                //
                txtAnswer.Enabled = true;
                txtID.Enabled = true;
                lblID.Enabled = true;
                lblQuestion.Enabled = true;
                Lbl_Question.Enabled = true;
                lblAnswer.Enabled = true;
            }
        }
    }
}
