using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

/*
    Author: Furkan Ay
*/

namespace kutuphaneOtomasyon
{
    class DataBase
    {
        private string server = "localhost";
        private string user = "root";
        private string password = "1234";
        private string database = "kutuphane";

        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        private MySqlDataAdapter adapter;

        public void Open()
        {
            conn = new MySqlConnection("server=" + this.server + ";uid=" + this.user
                + ";pwd=" + this.password + ";database=" + this.database);
            try
            {
                conn.Open();
            }
            catch (MySqlException myEx)
            {

                throw myEx;
            }

        }

        public void Close()
        {
            try
            {
                conn.Close();
            }
            catch (MySqlException myEx)
            {

                throw myEx;
            }
        }

        public MySqlCommand Command()
        {
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            return cmd;
        }

        public MySqlDataReader Reader()
        {
            return reader;
        }

        public MySqlDataAdapter Adapter(string command)
        {
            adapter = new MySqlDataAdapter(command,conn);
            return adapter;
        }

        //public MySqlDataReader Select(string column, string table)
        //{
        //    cmd = new MySqlCommand();
        //    cmd.Connection = conn;
        //    cmd.CommandText = "select " + column + " from" + table;
        //    reader = cmd.ExecuteReader();
        //    return reader;
        //}


    }
}
