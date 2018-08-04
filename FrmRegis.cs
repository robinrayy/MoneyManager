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
    public partial class FrmRegis : Form
    {
        public FrmRegis()
        {
            InitializeComponent();
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {
            RandomCaptcha(6);
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
            RandomCaptcha(6);
        }

        private static Random random = new Random();

        public void RandomCaptcha(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz/#@;:.,!";
            txtCaptcha.Text = new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txtNama.Text = "";
            txtId.Text = ""; lblSampingID.Text = "";
            txtPassword.Text = ""; lblSampingPass.Text = "";
            txtRetypePass.Text = ""; Lbl_PassInfo.Text = "";
            txtEmail.Text = ""; lblSampingEmail.Text = "";
            txtQuestion.Text = "";
            txtAnswer.Text = "";
            RandomCaptcha(6);
            txtCaptchaAnswer.Text = "";
            checkboxSafetyQuestion.Checked = false;
            this.Close();
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (lblSampingID.Text == "Invalid")
            {
                if (txtId.TextLength < 6)
                {
                    MessageBox.Show("ID must be at least 6 characters !", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else if (txtId.TextLength > 20)
                {
                    MessageBox.Show("ID must not contain more than 20 characters ! ", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtId.Text.Contains(" "))
                {
                    MessageBox.Show("ID must NOT contain spaces", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("A particular ID exists", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtId.Focus();
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
                    if (txtId.TextLength < 6 || txtId.TextLength > 20|| txtId.Text.Trim() == "" || txtId.Text.Contains(" "))
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtRetypePass.Text != txtPassword.Text)
            {
                Lbl_PassInfo.Text = "Wrong";
                Lbl_PassInfo.Visible = true;
                Lbl_PassInfo.ForeColor = Color.Red;
            }
            else if (txtRetypePass.Text == txtPassword.Text)
            {
                Lbl_PassInfo.Text = "Correct";
                Lbl_PassInfo.Visible = true;
                Lbl_PassInfo.ForeColor = Color.Green;
            }
            if (txtPassword.Text == "")
            {
                lblSampingPass.Text = "";
            }
            
            else if (txtPassword.TextLength < 6 || txtPassword.Text.Trim() == "" || txtPassword.Text.Contains(" "))
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
            if (txtRetypePass.Text.Trim() == "" || txtRetypePass.Text.Contains(" "))
            {
                Lbl_PassInfo.Text = "Invalid";
                Lbl_PassInfo.Visible = true;
                Lbl_PassInfo.ForeColor = Color.Red;
            }
            else
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
                    if (userdao.GetUserDataByEmail(this.txtEmail.Text) != null)
                    {
                        MessageBox.Show("This email has been used by another account !", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!EmailIsValid(this.txtEmail.Text) || userdao.GetUserDataByEmail(this.txtEmail.Text) != null)
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtNama.Text.Trim() == "" || txtId.Text.Trim() == "" || txtPassword.Text.Trim() == "" || txtRetypePass.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtCaptchaAnswer.Text.Trim() == "")
            {
                MessageBox.Show("Please type every required data or captcha ! ", "Blank Spaces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtCaptchaAnswer.Text != txtCaptcha.Text)
            {
                MessageBox.Show("Wrong Captcha", "Captcha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPassword.Text.Contains(" ") || txtRetypePass.Text.Contains(" "))
            {
                MessageBox.Show("Passwords must not contain spaces, retype your password !", "Captcha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPassword.Text != txtRetypePass.Text)
            {
                MessageBox.Show("Password's not the same", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else
            {
                try
                {
                    using (var userdao = new UserDAO())
                    {
                        
                            userdao.Insert(
                            new User(txtId.Text.Trim(), txtNama.Text.Trim(), txtPassword.Text.Trim(), txtEmail.Text.Trim(), txtQuestion.Text.Trim(), txtAnswer.Text.Trim())
                            );
                        
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                MessageBox.Show("Registration Successful !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                
                btnCancel_Click_1(null,null);
            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
                txtRetypePass.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtRetypePass.PasswordChar = '*';
            }
        }

        private void txtCaptchaAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRegister_Click(null, null);
            }
        }

        private void txtRetypePass_Leave(object sender, EventArgs e)
        {
            txtPassword_TextChanged(null,null);
        }
    }
}

