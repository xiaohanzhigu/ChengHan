using ChengHan.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChengHan.DLL
{
    internal class SqlHelper
    {
        public static DataTable GetTable(string sql)
        {
            MySqlConnection conn = new MySqlConnection(DB.GetConstr());
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table= new DataTable();
            try
            {
                conn.Open();
                command.Connection = conn;
                adapter.SelectCommand = command;
                command.CommandText = sql;
                adapter.Fill(table);
            }
            catch 
            {
                table = null;
            }
            finally
            { 
                conn.Close(); 
            }
            return table;
        }

        public static int ExeSql(string sql)
        {
            MySqlConnection conn = new MySqlConnection(DB.GetConstr());
            MySqlCommand command = new MySqlCommand();
            conn.Open();
            command.Connection= conn;
            int row = 0;
            try
            {
                command.CommandText = sql;
                row = command.ExecuteNonQuery();
            } catch
            {
                row = 0;
            }
            finally
            {
                conn.Close();
            }
            return row;
        }
    }

}
