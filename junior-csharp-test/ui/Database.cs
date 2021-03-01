using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using ui.Properties;

namespace ui
{
    public class Database
    {
        private readonly string _ConnectionString = Settings.Default.DbConnectionString;

        public MySqlConnection GetConnection => new MySqlConnection(_ConnectionString);

        public IEnumerable<dynamic> FetchAllOrderNumbers()
        {
            var dbConnection = new Database().GetConnection;
            dbConnection.Open();

            var sql = "SELECT order_number FROM orders ORDER BY order_number";

            var result = dbConnection.Query(sql);

            dbConnection.Close();

            return result;
        }
        public IEnumerable<dynamic> FetchOrderNumbersByDate(DateTime startDate, DateTime endDate)
        {
            var dbConnection = new Database().GetConnection;
            dbConnection.Open();

            var sql = "SELECT o.order_number FROM orders o WHERE o.order_date BETWEEN '" + startDate.ToString("yyyy-MM-dd") + "' AND '" + endDate.ToString("yyyy-MM-dd") + "'";

            var result = dbConnection.Query(sql);

            dbConnection.Close();

            return result;
        }

        public IEnumerable<dynamic> FetchOrderDetails(int orderNumber)
        {
            var dbConnection = new Database().GetConnection;
            dbConnection.Open();

            var sql = @"SELECT o.order_number, o.order_date, o.sale_price, o.deposit, c.customer_number, c.forename, c.surname, c.telephone_number, b.branch_name, b.postcode
                        FROM(((orders o INNER JOIN customers c ON o.customer_number = c.customer_number)
                        INNER JOIN employees e ON o.employee_number = e.employee_number) 
                        INNER JOIN branches b ON e.branch_name = b.branch_name) WHERE o.order_number = " + orderNumber.ToString();

            dynamic result = dbConnection.Query(sql);

            dbConnection.Close();

            return result;
        }
    }
}
