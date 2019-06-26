using StockManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Repository
{
    class CategoryRepository
    {
        string connectionString = @"Server=DESKTOP-5E35PUL\SQLEXPRESS; Database=StockManagementDB; Integrated Security=true;";
        private SqlConnection sqlconnection;

        private string command;
        private SqlCommand sqlCommand;
        public DataTable LoadCategories()
        {
            sqlconnection = new SqlConnection(connectionString);

            command = @"SELECT * FROM Categories";
            sqlCommand = new SqlCommand(command, sqlconnection);
            sqlconnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlconnection.Close();
            return dataTable;
        }
        public int CountCategory(Category category)
        {      
           
                       
            command = @"SELECT COUNT(CategoryName) FROM Categories WHERE CategoryName='"+category.CategoryName+"'";
            sqlCommand = new SqlCommand(command, sqlconnection);

            sqlconnection.Open();

            int isExecuted = 0;
            isExecuted=(Int32)sqlCommand.ExecuteScalar();

            sqlconnection.Close();

            return isExecuted;
        }
        public int Insert(Category category)
        {
            command = @"INSERT INTO Categories(CategoryName) values('" + category.CategoryName + "');";
            sqlCommand = new SqlCommand(command,sqlconnection);
            sqlconnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlconnection.Close();
            return isExecuted;
        }

        
    }
}
