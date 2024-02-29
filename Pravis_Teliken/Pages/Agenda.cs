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

        public static Agenda instance;
        private void Agenda_Load(object sender, EventArgs e)
        {
            instance = this;
            this.Controls.Add(new Menubar() { Dock = DockStyle.Top });
        }
    }
}
