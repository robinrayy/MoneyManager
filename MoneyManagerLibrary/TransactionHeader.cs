using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagerLibrary
{
    public class TransactionHeader
    {
        public DateTime Date { get; set; }
        public double Income { get; set; }
        public double Expense { get; set; }
    }
}
