using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;

namespace Rental_car
{

    public static class DBConnection
    {

        static private string connectionString = @"Database = car_rental; Data Source = localhost; UserID = root; Password = 1234";
        static private MySqlConnection msConnection;
        static private MySqlCommand msCommand;
        static private MySqlDataAdapter msDataAdapter;

        public static void Connect()
        {
            msConnection = new MySqlConnection(connectionString);
            msCommand = new MySqlCommand();
            msConnection.Open();
            msCommand.Connection = msConnection;
            msDataAdapter = new MySqlDataAdapter(msCommand);
        }

        public static void RunQuery(string query)
        {
            query = query.Replace("\r\n", "");
            msCommand.CommandText = query;
            msCommand.ExecuteNonQuery();
        }

        public static string GetResultQueryString(string query)
        {
            query = query.Replace("\r\n", "");
            msCommand.CommandText = query;
            return msCommand.ExecuteScalar().ToString();
        }

        public static DataTable GetResultQueryDataTable(string query)
        {
            var dataTable = new DataTable();
            query = query.Replace("\r\n", "");

            msCommand.CommandText = query;
            msDataAdapter.Fill(dataTable);

            return dataTable;
        }
    }
}
