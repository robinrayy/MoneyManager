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
    public partial class FrmGraph : Form
    {
        List<string> listInSubCategory = new List<string>();
        List<string> listExSubCategory = new List<string>();

        public FrmGraph(List<string> comboIn, List<string> comboEx)
        {
            InitializeComponent();
            listInSubCategory = comboIn;
            listExSubCategory = comboEx;
        }

        private void FrmGraph_Load(object sender, EventArgs e)
        {
            fillChart();
        }

        private void fillChart()
        {
            List<Transaction> listTransaksi = null;
            double[] arrayInAmount = new double[listInSubCategory.Count];
            double[] arrayExAmount = new double[listExSubCategory.Count];
            try
            {
                using (var transdao = new TransactionDAO())
                {
                    listTransaksi = transdao.GetAllTransactionDataByID("weyata");
                }

                foreach (var item in listTransaksi)
                {
                    if (item.Category == "Income")
                    {
                        for (int i = 0; i < listInSubCategory.Count; i++)
                        {
                            if (item.SubCategory == listInSubCategory.ElementAt(i))
                            {
                                arrayInAmount[i] += item.Amount;
                            }
                        }
                    }

                    else if (item.Category == "Expanse")
                    {
                        for (int i = 0; i < listInSubCategory.Count; i++)
                        {
                            if (item.SubCategory == listExSubCategory.ElementAt(i))
                            {
                                arrayExAmount[i] += item.Amount;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            // For Income Chart
            for (int i = 0; i < listInSubCategory.Count; i++)
            {
                incomeChart.Series["Income"].Points.AddXY(listInSubCategory.ElementAt(i), arrayInAmount[i]);
            }
            incomeChart.Titles.Add("Income");

            // For Expanse Chart
            for (int i = 0; i < listExSubCategory.Count; i++)
            {
                incomeChart.Series["Expanse"].Points.AddXY(listExSubCategory.ElementAt(i), arrayExAmount[i]);
            }
            incomeChart.Titles.Add("Expanse");
        }

    }
}
