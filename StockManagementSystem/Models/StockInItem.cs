using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class StockInItem
    {
        public int StockInId { get; set; }
        public int ItemId { get; set; }
        public int StockInQty { get; set; }
        public string StockInDate { get; set; }
        //
        public string ItemName { get; set; }
    }
}
