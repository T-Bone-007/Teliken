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
    public partial class AfspraakMaken : UserControl
    {
        public AfspraakMaken(int day, int month, int year)
        {
            InitializeComponent();
            this.day = day;
            this.month = month;
            this.year = year;
        }
        int day, month, year;

        private void AfspraakMaken_Load(object sender, EventArgs e)
        {
            lblDatum.Text = $"{day}-{month}-{year}";
        }

        private void btnMaken_Click(object sender, EventArgs e)
        {
            //Save afspraak todo
            Form1.instance.TakeDownMessage();
        }
    }
}
