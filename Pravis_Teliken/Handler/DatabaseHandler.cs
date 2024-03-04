using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Pravis_Teliken.Handler
{
    public class DatabaseHandler
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=pravis;Uid=root;pwd='';");
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public void upLoadData(DataGridView d, string comm)
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter(comm, conn);
            adapter.Fill(dt);
            d.DataSource = dt;
            conn.Close();
        }
        public void SaveData(string comm)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(comm, conn);
            MySqlDataReader result = cmd.ExecuteReader();
            conn.Close();
        }
        public MySqlConnection GetConnection()
        {
            return conn;
        }
        public int GetLastInsertedId()
        {
            using (MySqlCommand command = new MySqlCommand("SELECT LAST_INSERT_ID()", conn))
            {
                conn.Open();
                int lastInsertedId = Convert.ToInt32(command.ExecuteScalar());
                conn.Close();
                return lastInsertedId;
            }
        }
    }
}
