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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void linklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new FrmRegis().ShowDialog();
            Show();
        }

        private void linklblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new FrmForgotPassword().ShowDialog();
            Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var userdao = new UserDAO())
                {
                    User user = userdao.GetUserDataByID(txtId.Text);
                    if (user != null)
                    {
                        if (user.Password.ToString() == txtPass.Text)
                        {
                            //MessageBox.Show("Login Success !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            userdao.Dispose();
                            new FrmMainMenu(user).ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtPass.Clear();
                            txtPass.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtId.Clear();
                        txtPass.Clear();
                        txtId.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex; 
            }   
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
            
        }
    }
}
