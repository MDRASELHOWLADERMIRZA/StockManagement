using StockManagementSystem.BLL;
using StockManagementSystem.Models;
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
    public partial class CompanySetupUi : Form
    {
        CompanyManager _companyManager = new CompanyManager();
        Company company = new Company();
        public CompanySetupUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            company.Name = CompanyNameTextBox.Text;
            string message = _companyManager.InsertCompany(company);
            MessageBox.Show(message);
            LoadCompanies();
        }
        public void LoadCompanies()
        {
            ShowCompanyDataGridView.DataSource = _companyManager.GetCompanies();
        }
        private void CompanySetupUi_Load(object sender, EventArgs e)
        {
            LoadCompanies();
        }
    }
}
