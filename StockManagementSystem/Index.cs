using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ItemSetup itemSetup = new ItemSetup();
            itemSetup.Show();
        }

        private void CategorySetupLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategorySetupUi categorySetup = new CategorySetupUi();
            categorySetup.Show();
        }

        private void CompanySetupLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CompanySetupUi companySetup = new CompanySetupUi();
            companySetup.Show();
        }

        private void StockInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StockIn stockIn = new StockIn();
            stockIn.Show();
        }

  
    }
}
