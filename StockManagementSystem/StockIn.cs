using StockManagementSystem.BLL;
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
    public partial class StockIn : Form
    {
        ItemManager _itemManager = new ItemManager();
        StockInManager _stockInManager = new StockInManager();
        public StockIn()
        {
            InitializeComponent();
        }
        private void LoadItem()
        {
            itemComboBox.DataSource = _stockInManager.LoadItem();
            //itemComboBox.SelectedIndexChanged += new System.EventHandler(LoadPreorderLevel);

        }
        private void LoadCategory()
        {
            categoryComboBox.DataSource = _itemManager.LoadCategory();

        }
        private void LoadCompany()
        {
            companyComboBox.DataSource = _itemManager.LoadCompany();

        }
        private void StockIn_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadCompany();
            LoadItem();
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int item = itemComboBox.SelectedIndex;
            LoadReorderLevel(item);
        }
        private void LoadReorderLevel(int item)
        {
            reorderLevelTextBox.Text=_stockInManager.LoadReorderLevel(item).ToString();

        }
    }
}
