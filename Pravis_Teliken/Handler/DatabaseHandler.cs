using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Pravis_Teliken.Handler
{
    public class DatabaseHandler
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=rent_a_car;Uid=root;pwd='';");
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
    }
}
