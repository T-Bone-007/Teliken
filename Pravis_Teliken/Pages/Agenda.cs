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
        public static TableLayoutPanel tlpAgenda;
        private void Agenda_Load(object sender, EventArgs e)
        {
            instance = this;
            this.Controls.Add(new Menubar() { Dock = DockStyle.Top });
            if (tlpAgenda == null) 
            {
                tlpAgenda = tlpAgendaGrid;
                CreateAgenda();
            }
            else
            {
                tlpAgendaGrid = tlpAgenda;
            }
        }
        public void CreateAgenda()
        {
            tlpAgenda.RowCount = 5;
            tlpAgenda.ColumnCount = 7;
            for (int i = 0; i < tlpAgenda.RowCount; i++)
            {
                tlpAgenda.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            }
            for (int i = 0; i < tlpAgenda.ColumnCount; i++)
            {
                tlpAgenda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            }
            for (int i = 0; i < tlpAgenda.RowCount* tlpAgenda.ColumnCount; i++)
            {
                tlpAgenda.Controls.Add(new Label() { Text = i.ToString() },i%tlpAgenda.ColumnCount,i/tlpAgenda.ColumnCount);
            }
        }
    }
}
