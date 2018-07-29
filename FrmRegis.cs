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
    public partial class FrmRegis : Form
    {
        public FrmRegis()
        {
            InitializeComponent();
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {
            RandomString(6);
        }

        private void checkboxSafetyQuestion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxSafetyQuestion.Checked == true)
            {
                lblQuestion.Enabled = true;
                lblAnswer.Enabled = true;
                lblQestionMark.Enabled = true;
                txtQuestion.Enabled = true;
                txtAnswer.Enabled = true;
            }
            else
            {
                lblQuestion.Enabled = false;
                lblAnswer.Enabled = false;
                lblQestionMark.Enabled = false;
                txtQuestion.Enabled = false;
                txtAnswer.Enabled = false;
            }
        }

        private void FrmRegis_Load(object sender, EventArgs e)
        {
            ActiveControl = txtNama;// txtNama.Focus();
            RandomString(6);
        }

        private static Random random = new Random();

        public void RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz/#@;:.,!";
            txtCaptcha.Text = new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }



        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (lblSampingID.Text == "Invalid")
            {
                if (txtId.TextLength < 6)
                {
                    MessageBox.Show("ID must be at least 6 characters", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtId.Focus();
                }
                else
                {
                    MessageBox.Show("A particular ID exists", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtId.Focus();
                }
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            using (var userdao = new UserDAO())
            {
                if (userdao.GetUserDataByID(txtId.Text.Trim()) != null)
                {
                    lblSampingID.Text = "Invalid";
                    lblSampingID.ForeColor = Color.Red;
                    txtId.Focus();
                }
                else
                {
                    if (txtId.TextLength < 6)
                    {
                        lblSampingID.Text = "Invalid";
                        lblSampingID.ForeColor = Color.Red;
                        txtId.Focus();
                    }
                    else
                    {
                        lblSampingID.Text = "Valid";
                        lblSampingID.ForeColor = Color.Green;
                    }

                }
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (lblSampingPass.Text == "Invalid")
            { 
                    MessageBox.Show("Password must be at least 6 characters", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();               
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            if (txtPassword.TextLength < 6)
            {
                lblSampingPass.Text = "Invalid";
                lblSampingPass.ForeColor = Color.Red;
                txtPassword.Focus();
            }
            else
            {
                lblSampingPass.Text = "Valid";
                lblSampingPass.ForeColor = Color.Green;
            }
        }

        private void txtRetypePass_TextChanged(object sender, EventArgs e)
        {
            if (txtRetypePass.Text != txtPassword.Text)
            {
                
                Lbl_PassInfo.Text = "Wrong";
                Lbl_PassInfo.Visible = true;
                Lbl_PassInfo.ForeColor = Color.Red;
            }
            else
            {
                Lbl_PassInfo.Text = "Correct";
                Lbl_PassInfo.Visible = true;
                Lbl_PassInfo.ForeColor = Color.Green;
            }
        }

        private void txtRetypePass_Leave(object sender, EventArgs e)
        {
            if (Lbl_PassInfo.Text == "Wrong")
            {
                MessageBox.Show("Password and ReType are not identical !", "Invalid ReType Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRetypePass.Focus();
            }
        }
    }
}

