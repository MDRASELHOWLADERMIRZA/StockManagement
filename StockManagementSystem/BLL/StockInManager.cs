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
    class StockInManager
    {
        StockInRepository _stockInRepository = new StockInRepository(); 
        public DataTable LoadItem()
        {
            return _stockInRepository.LoadItem();
        }
        public int LoadReorderLevel(int item)
        {
            return _stockInRepository.LoadReorderLevel(item);
        }
        public string LoadAvailableQty(int item)
        {
            return _stockInRepository.LoadAvailableQty(item);
        }
        public Boolean Save(StockInItem inItem)
        {
            return _stockInRepository.Save(inItem);
        }

        public DataTable LoadStockItem()
        {
            return _stockInRepository.LoadStockItem();
        }
    }
}
