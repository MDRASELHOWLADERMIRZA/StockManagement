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
    class ItemManager
    {
        ItemRepository _itemRepository = new ItemRepository();
        public DataTable LoadCategory()
        {
            return _itemRepository.GetRepository();
        }
        public DataTable LoadCompany()
        {
            return _itemRepository.LoadCompany();
        }
        public string SaveItem(Item item)
        {
            string message;
            int countItem = _itemRepository.CheckItem(item);
            if (countItem>0)
            {
                return message = "Already Exist !";
            }
            else
            {
                Boolean result=_itemRepository.InsertItem(item);
                if (result=true)
                {
                    return message = "Save Successfully";
                }
                else
                {
                    return message = "Not Save !";
                }
            }
        }


    }
}
