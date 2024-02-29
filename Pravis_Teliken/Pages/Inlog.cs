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
            this.Controls.Add(new Menubar() { Dock = DockStyle.Top });
        }

        private void btnInlog_Click(object sender, EventArgs e)
        {

        }
    }
}
