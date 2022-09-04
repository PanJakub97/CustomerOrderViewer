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
    internal class ItemCommand
    {
         private string _connectionSting;

        public ItemCommand(string connectionSting)
        {
            _connectionSting = connectionSting;
        }

        public IList<ItemModel> GetList()
        {
            List<ItemModel> items = new List<ItemModel>();

            var sql = "Item_GetList";

            using (SqlConnection connection = new SqlConnection(_connectionSting))
            {
                items = connection.Query<ItemModel>(sql).ToList();
            }

            return items;
        }
    }
}
