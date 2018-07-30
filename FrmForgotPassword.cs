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
using System.Text.RegularExpressions;

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool EmailIsValid(string emailAddr)
        {
            string emailPattern1 = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(emailPattern1);
            Match match = regex.Match(emailAddr);
            return match.Success;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            using (var userdao = new UserDAO())
            {
                if (lblSampingEmail.Text == "Invalid")
                {
                    if (!EmailIsValid(this.txtEmail.Text))
                    {
                        MessageBox.Show("Please type a valid email !", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (userdao.GetUserDataByEmail(this.txtEmail.Text) == null)
                    {
                        MessageBox.Show("This email was not registered !", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please type a valid email !", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    txtEmail.Focus();
                }
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            using (var userdao = new UserDAO())
            {
                if (!EmailIsValid(this.txtEmail.Text) || userdao.GetUserDataByEmail(this.txtEmail.Text) == null)
                {
                    lblSampingEmail.Text = "Invalid";
                    lblSampingEmail.ForeColor = Color.Red;
                }

                else
                {
                    lblSampingEmail.Text = "Valid";
                    lblSampingEmail.ForeColor = Color.Green;
                }
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (lblSampingID.Text == "Invalid")
            {
                if (txtID.TextLength < 6)
                {
                    MessageBox.Show("ID must be at least 6 characters", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtID.Text.Contains(" "))
                {
                    MessageBox.Show("ID must NOT contain spaces", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("A particular ID doesn't exists", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtID.Focus();
            }
            else
            {
                using (var userdao = new UserDAO())
                {
                    User user = userdao.GetUserDataByID(txtID.Text);
                    if (user != null)
                    {
                        if (user.Question.ToString().Trim() == "" || user.Question.ToString() == null)
                        {
                            MessageBox.Show("This ID does not have a safety question !", "No Safety Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            lblQuestion.Text = user.Question.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("This ID was not registered !", "Unregistered ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            using (var userdao = new UserDAO())
            {
                if (userdao.GetUserDataByID(txtID.Text.Trim()) == null)
                {
                    lblSampingID.Text = "Invalid";
                    lblSampingID.ForeColor = Color.Red;
                    txtID.Focus();
                }
                else
                {
                    if (txtID.TextLength < 6 || txtID.Text.Trim() == "" || txtID.Text.Contains(" "))
                    {
                        lblSampingID.Text = "Invalid";
                        lblSampingID.ForeColor = Color.Red;
                        txtID.Focus();
                    }
                    else
                    {
                        lblSampingID.Text = "Valid";
                        lblSampingID.ForeColor = Color.Green;
                    }

                }
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                User user = null;
                using (var userdao = new UserDAO())
                {
                    user = userdao.GetUserDataByID(txtID.Text);
                    if (txtAnswer.Text == user.Answer.ToString())
                    {
                        MessageBox.Show("Your password : "+ user.Password, "Verification Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userdao.Dispose();
                        btnCancel_Click(null,null);
                    }
                    else
                    {
                        MessageBox.Show("Wrong Answer!", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEnter_Click(null, null);
            }
        }
    }
}
