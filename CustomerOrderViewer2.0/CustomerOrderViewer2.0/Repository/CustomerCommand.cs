using CustomerOrderViewer2._0.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderViewer2._0.Repository
{
    internal class CustomerCommand
    {
         private string _connectionSting;

        public CustomerCommand(string connectionSting)
        {
            _connectionSting = connectionSting;
        }

        public IList<CustomerModel> GetList()
        {
            List<CustomerModel> customers = new List<CustomerModel>();

            var sql = "Customer_GetList";

            using (SqlConnection connection = new SqlConnection(_connectionSting))
            {
                customers = connection.Query<CustomerModel>(sql).ToList();
            }

            return customers;
        }
    }
}
