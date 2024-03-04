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
        string[] dayNameNed = { "Maandag", "Dinsdag", "Woensdag", "Donderdag", "Vrijdag", "Zaterdag", "Zondag" };
        string[] monthNameNed = { "Januari", "Februari", "Maart", "April", "Mei", "Juni", "Juli","Augustus","September","Oktober","November","December" };
        int dayIndex, monthIndex, yearIndex;
        private void Agenda_Load(object sender, EventArgs e)
        {
            instance = this;
            this.Controls.Add(Menubar.instance);
            if (tlpAgenda == null) 
            {
                tlpAgenda = tlpAgendaGrid;
                monthIndex = DateTime.Now.Month;
                yearIndex = DateTime.Now.Year;
                CreateAgenda();
            }
            else
            {
                tlpAgendaGrid = tlpAgenda;
            }
        }
        public void CreateAgenda()
        {
            tlpAgenda.Controls.Clear();
            tlpAgenda.RowCount = 6;
            tlpAgenda.ColumnCount = 7;
            for (int i = 0; i < tlpAgenda.RowCount; i++)
            {
                tlpAgenda.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            }
            for (int i = 0; i < tlpAgenda.ColumnCount; i++)
            {
                tlpAgenda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            }
            for (int i = 0; i < dayNameNed.Count(); i++)
            {
                tlpAgenda.Controls.Add(new Label() { Text = dayNameNed[i], Dock = DockStyle.Fill }, i, 0);
            }
            int beginOfMonthIndex = GetBeginIndex();
            for (int i = 6 + beginOfMonthIndex; i < tlpAgenda.RowCount * tlpAgenda.ColumnCount; i++)
            {
                Label lbl = new Label() { Text = (i - 6 - beginOfMonthIndex).ToString(), Visible = false };
                lbl.Click += lbl_Click;
                tlpAgenda.Controls.Add(lbl, i % tlpAgenda.ColumnCount, i / tlpAgenda.ColumnCount);
            }
            ShowDaysOfMonth();
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            dayIndex = Int32.Parse(((Label)sender).Text);
            //Maak Afspraak
            Form1.instance.PutUpMessage(new AfspraakMaken(dayIndex,monthIndex,yearIndex));
        }
        private void btnMonthBackwards_Click(object sender, EventArgs e)
        {
            monthIndex--;
            if (monthIndex < 1)
            {
                monthIndex = 12;
                yearIndex--;
            }
            CreateAgenda();
        }
        private void btnMonthForward_Click(object sender, EventArgs e)
        {
            monthIndex++;
            if (monthIndex > 12)
            {
                monthIndex = 1;
                yearIndex++;
            }
            CreateAgenda();
        }

        //Het is vandaag zondag 3-> 3%7=3->(zondag)=6+5 =11%7=4 dus begint de maand bij vrijdag
        public int GetBeginIndex()
        {
            int index = 0;
            int CurrentDay = DateTime.Now.Day;
            switch (CurrentDay % 7)
            {
                case 0:
                    index = GetIndexOfDay() + 1;
                    break;
                case 1:
                    index = GetIndexOfDay();
                    break;
                case 2:
                    index = GetIndexOfDay() + 6;
                    break;
                case 3:
                    index = GetIndexOfDay() + 5;
                    break;
                case 4:
                    index = GetIndexOfDay() + 4;
                    break;
                case 5:
                    index = GetIndexOfDay() + 3;
                    break;
                case 6:
                    index = GetIndexOfDay() + 2;
                    break;
            }
            return index%7;
        }
        string[] dayName = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public int GetIndexOfDay()
        {
            for (int i = 0; i < dayName.Count(); i++)
            {
                var day = DateTime.Now.AddMonths(monthIndex - DateTime.Now.Month).AddYears(yearIndex - DateTime.Now.Year);
                if (dayName[i] == day.DayOfWeek.ToString())
                {
                    return i;
                }
            }
            return -1;
        }

        public void ShowDaysOfMonth()
        {
            int days = DateTime.DaysInMonth(yearIndex, monthIndex);
            for (int i = 7; i < tlpAgenda.Controls.Count; i++)
            {
                if (i != 7 && i <= days + 7)
                {
                    tlpAgenda.Controls[i].Visible = true;
                }
            }
            lblMonth.Text = $"{monthNameNed[monthIndex-1]} {yearIndex}";
        }
    }
}
