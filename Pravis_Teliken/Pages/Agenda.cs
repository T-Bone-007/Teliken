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
    public partial class Agenda : UserControl
    {
        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            pbHomeLogo.Image = FileHandler.Instance.GetImage("Logo.png");
        }

        private void pbHomeLogo_Click(object sender, EventArgs e)
        {
            Form1.instance.SwitchPageTo(new HomePage());
        }
    }
}
