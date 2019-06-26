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
    public partial class CategorySetupUi : Form
    {
        CategoryManager _categoryMgr = new CategoryManager();
        Category category = new Category();
        public CategorySetupUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            category.CategoryName = CategoryNameTextBox.Text;
           string message= _categoryMgr.SaveCategory(category);
           MessageBox.Show(message);
           LoadCategoryList();
        }

        private void CategorySetupUi_Load(object sender, EventArgs e)
        {
            LoadCategoryList();
           
        }
        private void LoadCategoryList()
        {
            ShowCategoryDataGridView.DataSource = _categoryMgr.LoadCategories();
        }

    }
}
