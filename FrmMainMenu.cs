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
    }


}
