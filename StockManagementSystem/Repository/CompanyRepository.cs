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
    class CompanyRepository
    {
        string connectionString = @"Server=DESKTOP-5E35PUL\SQLEXPRESS; Database=StockManagementDB; Integrated Security=true;";
        public SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private string commandString;

        public DataTable GetCompanies()
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Companies";
            sqlCommand = new SqlCommand(commandString,sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public int CountCompany(Company company)
        {
            
            commandString = @"SELECT COUNT(Name) FROM Companies WHERE Name='"+company.Name+"'";
            sqlCommand = new SqlCommand(commandString,sqlConnection);
            sqlConnection.Open();

            int isExecuted;
            isExecuted = (Int32)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
           
            return isExecuted;
        }
        public int Insert(Company company)
        {
         
            commandString = @"INSERT INTO Companies(Name) values('" + company.Name + "')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            return isExecuted;
        }
    }
}
