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

        public DataTable LoadReorderLevel(int item)
        {
            sqlConnection = new SqlConnection(connectionString);

            string query = @"Select ReorderLevel From Items WHERE ItemId='" + item + "'";
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
