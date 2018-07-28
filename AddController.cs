using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManager
{
    class AddController
    {
        public Boolean NumberValidation(string str)
        {
            //char key = str;
            char key = Convert.ToChar(str);
            if (char.IsNumber(key) || key == (char)8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
