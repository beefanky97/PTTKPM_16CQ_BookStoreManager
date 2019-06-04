using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAO
{
    class DataProvider
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=W:\DeadLine\WPF\BookStoreManager\BookStoreDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public static DataTable ExecuteQuerry(string querry)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataTable table = new DataTable();
            using (connection)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(querry, connection);
                adapter.Fill(table);
            }
            connection.Close();
            return table;
        }

        public static int ExecuteNonQuerry(string querry)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            int result = 0;
            using (connection)
            {
                SqlCommand command = new SqlCommand(querry, connection);
                result = command.ExecuteNonQuery();
            }
            connection.Close();
            return result;
        }
    }
}
