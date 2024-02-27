using Pravis_Teliken.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pravis_Teliken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Form1 instance;
        UserControl currentControl;
        private void Form1_Load(object sender, EventArgs e)
        {
            instance = this;
            SwitchPageTo(new HomePage());
            currentControl.Size = this.ClientSize;
        }
        public void SwitchPageTo(UserControl page) 
        {
            this.Controls.Clear();
            this.Controls.Add(page);
            currentControl = page;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            currentControl.Size = this.ClientSize;
        }
    }
}
