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
    class StockInRepository
    {
        string connectionString = @"Server=DESKTOP-5E35PUL\SQLEXPRESS;Database=StockManagementDB;Integrated Security=true;";
        private SqlConnection sqlConnection;
        public DataTable LoadItem()
        {
            sqlConnection = new SqlConnection(connectionString);

            string query = @"Select * From Items";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;
        }

        public int LoadReorderLevel(int item)
        {
            int reorderQty=0;
            sqlConnection = new SqlConnection(connectionString);

            string query = @"Select ReorderLevel From Items WHERE ItemId='" + item + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
     
            sqlConnection.Open();

            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    reorderQty = Int32.Parse(reader["ReorderLevel"].ToString());

                }
          
            }
            sqlConnection.Close();
            return reorderQty;
        }
        public string LoadAvailableQty(int item)
        {

            sqlConnection = new SqlConnection(connectionString);

            string query = @"Select SUM(StockInQty) From StockInItems WHERE ItemId='" + item + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();

           object sumAvailable = sqlCommand.ExecuteScalar();
           sqlConnection.Close();
            return Convert.ToString(sumAvailable);
        }

        public Boolean Save(StockInItem itemIn)
        {
            string query = @"INSERT INTO StockInItems(ItemId,StockInQty,StockInDate) values('" + itemIn.ItemId + "','" + itemIn.StockInQty + "','" + itemIn.StockInDate + "')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
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
        public DataTable LoadStockItem()
        {

            string query = @"Select * From StockInItems";
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
