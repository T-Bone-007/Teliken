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
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            pbHomeMain.Image = FileHandler.Instance.GetImage("Main.png");
            pbHomeLogo.Image = FileHandler.Instance.GetImage("Logo.png");
        }

        private void lblInlog_Click(object sender, EventArgs e)
        {
            Form1.instance.SwitchPageTo(new Inlog());
        }

        private void lblAgenda_Click(object sender, EventArgs e)
        {
            Form1.instance.SwitchPageTo(new Agenda());
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            Form1.instance.SwitchPageTo(new Admin());
        }
    }
}
