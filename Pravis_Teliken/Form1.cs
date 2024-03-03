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
        UserControl messageControl;
        private void Form1_Load(object sender, EventArgs e)
        {
            instance = this;
            SwitchPageTo(new HomePage());           
        }
        public void SwitchPageTo(UserControl page) 
        {
            this.Controls.Clear();
            this.Controls.Add(page);
            currentControl = page;
            currentControl.Size = this.ClientSize;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            currentControl.Size = this.ClientSize;
        }
        public void PutUpMessage(UserControl userControl) 
        {
            messageControl = userControl;
            this.Controls.Add(userControl);
            userControl.BringToFront();
            userControl.Dock = DockStyle.Fill;
        }
        public void TakeDownMessage() 
        {
            this.Controls.Remove(messageControl);
        }
    }
}
