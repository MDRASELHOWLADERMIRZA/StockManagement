﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Index());
            //Application.Run(new CategorySetupUi());
            //Application.Run(new CompanySetupUi());
            //Application.Run(new ItemSetup());
            //Application.Run(new StockIn());
        }
    }
}
