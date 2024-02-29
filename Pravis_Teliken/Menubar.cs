using Pravis_Teliken.Handler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pravis_Teliken.Pages
{
    public partial class Menubar : UserControl
    {
        public Menubar()
        {
            InitializeComponent();
        }

        private void Menubar_Load(object sender, EventArgs e)
        {
            pbHomeLogo.Image = FileHandler.Instance.GetImage("Logo.png");
        }

        private void pbHomeLogo_Click(object sender, EventArgs e)
        {
            if (HomePage.instance == null)
            {
                Form1.instance.SwitchPageTo(new HomePage());
            }
            else
            {
                Form1.instance.SwitchPageTo(HomePage.instance);
            }
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            if (Admin.instance == null)
            {
                Form1.instance.SwitchPageTo(new Admin());
            }
            else
            {
                Form1.instance.SwitchPageTo(Admin.instance);
            }
        }

        private void lblAgenda_Click(object sender, EventArgs e)
        {
            if (Agenda.instance == null)
            {
                Form1.instance.SwitchPageTo(new Agenda());
            }
            else
            {
                Form1.instance.SwitchPageTo(Agenda.instance);
            }
        }

        private void lblInlog_Click(object sender, EventArgs e)
        {
            if (Inlog.instance == null)
            {
                Form1.instance.SwitchPageTo(new Inlog());
            }
            else
            {
                Form1.instance.SwitchPageTo(Inlog.instance);
            }
        }
    }
}
