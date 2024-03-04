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

        public static HomePage instance;

        private void HomePage_Load(object sender, EventArgs e)
        {
            instance = this;
            this.Controls.Add(new Menubar() { Dock = DockStyle.Top});
            pbHomeMain.Image = FileHandler.Instance.GetImage("Main.png");
        }
        public void GetMenubar() 
        {
            this.Controls.Add(Menubar.instance);
        }

    }
}
