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
        public DataTable LoadReorderLevel(int item)
        {
            return _stockInRepository.LoadReorderLevel(item);
        }
    }
}
