﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int CategoryId { get; set; }
        public int CompanyId { get; set; }
        public int ReorderLevel { get; set; }

    }
}
