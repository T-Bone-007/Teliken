using Pravis_Teliken.Handler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pravis_Teliken.Pages
{
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
        }

        public static Admin instance;
        private void Admin_Load(object sender, EventArgs e)
        {
            instance = this;
            this.Controls.Add(Menubar.instance);

            dc.upLoadData(dtgvArtsen, "select * from arts");
            dc.upLoadData(dtgvPatienten, "select * from patient");
            dc.upLoadData(dtgvWachtlijst, "select * from wachtlijst");

            ReLoadList(cmbArtsen, dtgvArtsen);      
            LoadUser(cmbArtsen, dtgvArtsen);
            ReLoadList(cmbPatienten, dtgvPatienten);
            LoadUser(cmbPatienten, dtgvPatienten);
        }

        public void HideArtsen()
        {
            if (tbcAdmin.TabPages.Contains(tbpArtsen))
            {
                tbcAdmin.TabPages.Remove(tbpArtsen);
            }
        }


        private void LoadUser(ComboBox comboBox, DataGridView d)
        {
            int id = comboBox.SelectedIndex;
            if (id >= 0 && id < d.RowCount - 1)
            {
                string[] values = new string[2];
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = d.Rows[id].Cells[i + 1].Value.ToString();
                }
                if(comboBox == cmbArtsen)
                {
                    txtFunctie.Text = values[1];
                }
                else
                {
                    cmbStatus.Text = values[1];
                }        
            }
        }

        private void ReLoadList(ComboBox comboBox, DataGridView d)
        {
            comboBox.Items.Clear();
            for (int j = 0; j < d.RowCount - 1; j++)
            {
                string user = d.Rows[j].Cells[1].Value.ToString();
                comboBox.Items.Add(user);
            }
        }

        DatabaseHandler dc = new DatabaseHandler();
        private void button1_Click(object sender, EventArgs e)
        {
            string role = cmbRol.Text;
            try
            {
                dc.SaveData("INSERT INTO `gebruiker` (`gebruiker_id`,`naam`, `wachtwoord`, `rol`) VALUES (NULL,'" + txtName.Text + "', '" + txtWachtwoord.Text + "', '" + cmbRol.Text  + "')");
                int gebruikerId = dc.GetLastInsertedId();
                if (role == "1")
                {
                    dc.SaveData("INSERT INTO `arts` (`arts_id`, `naam`) VALUES (" + gebruikerId + ", '" + txtName.Text + "')");
                    MessageBox.Show("arts toegevoegd");
                }
                else if (role == "2")
                {
                    dc.SaveData("INSERT INTO `patient` (`patient_id`, `naam`) VALUES (" + gebruikerId + ", '" + txtName.Text + "')");
                    MessageBox.Show("patient toegevoegd");
                }
                else
                {
                    MessageBox.Show("gebruiker toegevoegd");
                }             
            }
            catch
            {
                MessageBox.Show("error");
            }

        }

        private void cmbArtsen_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cmbArtsen.Items.Count; i++)
            {
                if (cmbArtsen.Text == cmbArtsen.Items[i].ToString())
                {
                    cmbArtsen.Tag = i;
                    break;
                }
            }
            LoadUser(cmbArtsen, dtgvArtsen);
        }

        private void btnAanpassenArts_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(cmbArtsen.Tag.ToString());
            dc.SaveData("UPDATE `arts` SET `naam` = '" + cmbArtsen.Text + "',`functie` = '" + txtFunctie.Text + "' WHERE `arts`.`arts_id` = " + id + ";");
            dc.upLoadData(dtgvArtsen, "select * from arts");
            LoadUser(cmbArtsen, dtgvArtsen);
        }

        private void cmbPatienten_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cmbPatienten.Items.Count; i++)
            {
                if (cmbPatienten.Text == cmbPatienten.Items[i].ToString())
                {
                    cmbPatienten.Tag = i;  
                    break;
                }
            }
            LoadUser(cmbPatienten, dtgvPatienten);
        }

        private void btnAanpassenPatient_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(cmbPatienten.Tag.ToString());
            dc.SaveData("UPDATE `patient` SET `naam` = '" + cmbPatienten.Text + "',`status` = '" + cmbStatus.Text + "' WHERE `patient`.`patient_id` = " + id + ";");
            dc.upLoadData(dtgvPatienten, "select * from patient");
            LoadUser(cmbPatienten, dtgvPatienten);
        }
    }
}
