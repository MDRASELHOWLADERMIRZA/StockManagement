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
    class ItemRepository
    {
        string connectionString = @"Server=DESKTOP-5E35PUL\SQLEXPRESS;Database=StockManagementDB;Integrated Security=true;";
        private SqlConnection sqlConnection;
        public Boolean InsertItem(Item item)
        {
            string query = @"INSERT INTO Items(ItemName,CategoryId,CompanyId,ReorderLevel) values('"+item.ItemName+"','"+item.CategoryId+"','"+item.CompanyId+"','"+item.ReorderLevel+"')";
            SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);
            sqlConnection.Open();
            int isExecuted = sqlCommand.ExecuteNonQuery();
       
            sqlConnection.Close();
            if (isExecuted > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int CheckItem(Item item)
        {
            string query = @"Select COUNT(ItemName) From Items WHERE ItemName='"+item.ItemName+"'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();

            int isExecuted = (Int32) sqlCommand.ExecuteScalar();

            sqlConnection.Close();
            return isExecuted;
        }
        public DataTable GetRepository()
        {
            sqlConnection = new SqlConnection(connectionString);
         
            string query = @"Select * From Categories";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;
        }

        public DataTable LoadCompany()
        {
            sqlConnection = new SqlConnection(connectionString);
            string query = @"Select * From Companies";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;
        }
    }
}
