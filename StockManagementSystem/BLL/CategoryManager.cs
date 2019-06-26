using StockManagementSystem.Models;
using StockManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    class CategoryManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();
        public string SaveCategory(Category category)
        {
            string message;

            int countCategoryName = _categoryRepository.CountCategory(category);
            if (countCategoryName>0)
            {
                 message="Category Already Added !!";
                 return message;
            }
            else
            {
               _categoryRepository.Insert(category);
                return message="";
            }
        }

        public DataTable LoadCategories()
        {
            return _categoryRepository.LoadCategories();
        }

    }
}
