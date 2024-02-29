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
            this.Controls.Add(new Menubar() { Dock = DockStyle.Top });
        }
    }
}
