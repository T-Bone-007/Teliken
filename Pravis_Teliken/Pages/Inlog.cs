using Pravis_Teliken.Handler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pravis_Teliken.Pages
{
    public partial class Inlog : UserControl
    {
        public Inlog()
        {
            InitializeComponent();
        }

        public static Inlog instance;
        private void Inlog_Load(object sender, EventArgs e)
        {
            instance = this;
            this.Controls.Add(Menubar.instance);
        }

        DatabaseHandler dc = new DatabaseHandler();
        private void btnInlog_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string passwd = txtPass.Text;

            try
            {
                string query = "SELECT rol FROM gebruiker WHERE naam = @username AND wachtwoord = @password";

                using (MySqlCommand cmd = new MySqlCommand(query, dc.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", passwd);

                    dc.GetConnection().Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int rol = Convert.ToInt32(result);

                        username = txtName.Text;
                        passwd = txtPass.Text;

                        Form1.instance.SwitchPageTo(HomePage.instance);
                        HomePage.instance.GetMenubar();
                        Menubar.instance.ChangelblName();

                        if (rol == 0 || rol == 1)
                        {
                            MessageBox.Show("Je bent admin");
                            Menubar.instance.showadmin();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ongeldige inloggegevens", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtName.Clear();
                        txtPass.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij inloggen: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dc.GetConnection().Close();
            }
        }
    }
}
