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
    public partial class ItemSetup : Form
    {
        ItemManager _itemManager = new ItemManager();
        public ItemSetup()
        {
            InitializeComponent();
        }
        private void LoadCategory()
        {
            categoryComboBox.DataSource = _itemManager.LoadCategory();
           
        }
        private void LoadCompany()
        {
             companyComboBox.DataSource = _itemManager.LoadCompany();

        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.ItemName = itemNameTextBox.Text;
            item.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
            item.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
            item.ReorderLevel = Int32.Parse(reorderLevelTextBox.Text);

            string message = _itemManager.SaveItem(item);

            MessageBox.Show(message);
        }

        private void ItemSetup_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadCompany();
        }
    }
}
