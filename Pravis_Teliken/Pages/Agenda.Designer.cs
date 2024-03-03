namespace Pravis_Teliken.Pages
{
    partial class Agenda
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpAgendaMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAgendaGrid = new System.Windows.Forms.TableLayoutPanel();
            this.lblMonth = new System.Windows.Forms.Label();
            this.tlpChangeMonth = new System.Windows.Forms.TableLayoutPanel();
            this.btnMonthBackwards = new System.Windows.Forms.Button();
            this.btnMonthForward = new System.Windows.Forms.Button();
            this.tbcAgenda = new System.Windows.Forms.TabControl();
            this.tbpAgenda = new System.Windows.Forms.TabPage();
            this.tbpAfspraken = new System.Windows.Forms.TabPage();
            this.tlpAfspraken = new System.Windows.Forms.TableLayoutPanel();
            this.lstAfspraken = new System.Windows.Forms.ListBox();
            this.lblAfspraken = new System.Windows.Forms.Label();
            this.tlpData = new System.Windows.Forms.TableLayoutPanel();
            this.lblData = new System.Windows.Forms.Label();
            this.tlpAgendaMain.SuspendLayout();
            this.tlpChangeMonth.SuspendLayout();
            this.tbcAgenda.SuspendLayout();
            this.tbpAgenda.SuspendLayout();
            this.tbpAfspraken.SuspendLayout();
            this.tlpAfspraken.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAgendaMain
            // 
            this.tlpAgendaMain.ColumnCount = 2;
            this.tlpAgendaMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgendaMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgendaMain.Controls.Add(this.tlpAgendaGrid, 0, 1);
            this.tlpAgendaMain.Controls.Add(this.lblMonth, 0, 0);
            this.tlpAgendaMain.Controls.Add(this.tlpChangeMonth, 1, 0);
            this.tlpAgendaMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAgendaMain.Location = new System.Drawing.Point(3, 3);
            this.tlpAgendaMain.Name = "tlpAgendaMain";
            this.tlpAgendaMain.RowCount = 2;
            this.tlpAgendaMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpAgendaMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpAgendaMain.Size = new System.Drawing.Size(610, 431);
            this.tlpAgendaMain.TabIndex = 0;
            // 
            // tlpAgendaGrid
            // 
            this.tlpAgendaGrid.BackColor = System.Drawing.Color.Transparent;
            this.tlpAgendaGrid.ColumnCount = 2;
            this.tlpAgendaMain.SetColumnSpan(this.tlpAgendaGrid, 2);
            this.tlpAgendaGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgendaGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgendaGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAgendaGrid.Location = new System.Drawing.Point(3, 46);
            this.tlpAgendaGrid.Name = "tlpAgendaGrid";
            this.tlpAgendaGrid.RowCount = 2;
            this.tlpAgendaGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgendaGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgendaGrid.Size = new System.Drawing.Size(604, 382);
            this.tlpAgendaGrid.TabIndex = 0;
            // 
            // lblMonth
            // 
            this.lblMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonth.Location = new System.Drawing.Point(3, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(299, 43);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "Month";
            // 
            // tlpChangeMonth
            // 
            this.tlpChangeMonth.ColumnCount = 2;
            this.tlpChangeMonth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpChangeMonth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpChangeMonth.Controls.Add(this.btnMonthBackwards, 0, 0);
            this.tlpChangeMonth.Controls.Add(this.btnMonthForward, 1, 0);
            this.tlpChangeMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpChangeMonth.Location = new System.Drawing.Point(308, 3);
            this.tlpChangeMonth.Name = "tlpChangeMonth";
            this.tlpChangeMonth.RowCount = 1;
            this.tlpChangeMonth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpChangeMonth.Size = new System.Drawing.Size(299, 37);
            this.tlpChangeMonth.TabIndex = 2;
            // 
            // btnMonthBackwards
            // 
            this.btnMonthBackwards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMonthBackwards.Location = new System.Drawing.Point(3, 3);
            this.btnMonthBackwards.Name = "btnMonthBackwards";
            this.btnMonthBackwards.Size = new System.Drawing.Size(143, 31);
            this.btnMonthBackwards.TabIndex = 0;
            this.btnMonthBackwards.Text = "<";
            this.btnMonthBackwards.UseVisualStyleBackColor = true;
            this.btnMonthBackwards.Click += new System.EventHandler(this.btnMonthBackwards_Click);
            // 
            // btnMonthForward
            // 
            this.btnMonthForward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMonthForward.Location = new System.Drawing.Point(152, 3);
            this.btnMonthForward.Name = "btnMonthForward";
            this.btnMonthForward.Size = new System.Drawing.Size(144, 31);
            this.btnMonthForward.TabIndex = 1;
            this.btnMonthForward.Text = ">";
            this.btnMonthForward.UseVisualStyleBackColor = true;
            this.btnMonthForward.Click += new System.EventHandler(this.btnMonthForward_Click);
            // 
            // tbcAgenda
            // 
            this.tbcAgenda.Controls.Add(this.tbpAgenda);
            this.tbcAgenda.Controls.Add(this.tbpAfspraken);
            this.tbcAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcAgenda.Location = new System.Drawing.Point(0, 0);
            this.tbcAgenda.Name = "tbcAgenda";
            this.tbcAgenda.SelectedIndex = 0;
            this.tbcAgenda.Size = new System.Drawing.Size(624, 475);
            this.tbcAgenda.TabIndex = 1;
            // 
            // tbpAgenda
            // 
            this.tbpAgenda.Controls.Add(this.tlpAgendaMain);
            this.tbpAgenda.Location = new System.Drawing.Point(4, 34);
            this.tbpAgenda.Name = "tbpAgenda";
            this.tbpAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAgenda.Size = new System.Drawing.Size(616, 437);
            this.tbpAgenda.TabIndex = 0;
            this.tbpAgenda.Text = "Agenda";
            this.tbpAgenda.UseVisualStyleBackColor = true;
            // 
            // tbpAfspraken
            // 
            this.tbpAfspraken.Controls.Add(this.tlpAfspraken);
            this.tbpAfspraken.Location = new System.Drawing.Point(4, 34);
            this.tbpAfspraken.Name = "tbpAfspraken";
            this.tbpAfspraken.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAfspraken.Size = new System.Drawing.Size(616, 437);
            this.tbpAfspraken.TabIndex = 1;
            this.tbpAfspraken.Text = "Afspraken";
            this.tbpAfspraken.UseVisualStyleBackColor = true;
            // 
            // tlpAfspraken
            // 
            this.tlpAfspraken.ColumnCount = 2;
            this.tlpAfspraken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAfspraken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAfspraken.Controls.Add(this.lstAfspraken, 0, 1);
            this.tlpAfspraken.Controls.Add(this.lblAfspraken, 0, 0);
            this.tlpAfspraken.Controls.Add(this.tlpData, 1, 1);
            this.tlpAfspraken.Controls.Add(this.lblData, 1, 0);
            this.tlpAfspraken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAfspraken.Location = new System.Drawing.Point(3, 3);
            this.tlpAfspraken.Name = "tlpAfspraken";
            this.tlpAfspraken.RowCount = 2;
            this.tlpAfspraken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpAfspraken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpAfspraken.Size = new System.Drawing.Size(610, 431);
            this.tlpAfspraken.TabIndex = 0;
            // 
            // lstAfspraken
            // 
            this.lstAfspraken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAfspraken.FormattingEnabled = true;
            this.lstAfspraken.ItemHeight = 25;
            this.lstAfspraken.Location = new System.Drawing.Point(3, 46);
            this.lstAfspraken.Name = "lstAfspraken";
            this.lstAfspraken.Size = new System.Drawing.Size(299, 382);
            this.lstAfspraken.TabIndex = 0;
            // 
            // lblAfspraken
            // 
            this.lblAfspraken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAfspraken.Location = new System.Drawing.Point(3, 0);
            this.lblAfspraken.Name = "lblAfspraken";
            this.lblAfspraken.Size = new System.Drawing.Size(299, 43);
            this.lblAfspraken.TabIndex = 1;
            this.lblAfspraken.Text = "Afspraken:";
            // 
            // tlpData
            // 
            this.tlpData.ColumnCount = 2;
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpData.Location = new System.Drawing.Point(308, 46);
            this.tlpData.Name = "tlpData";
            this.tlpData.RowCount = 2;
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpData.Size = new System.Drawing.Size(299, 382);
            this.tlpData.TabIndex = 2;
            // 
            // lblData
            // 
            this.lblData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblData.Location = new System.Drawing.Point(308, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(299, 43);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data:";
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcAgenda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Agenda";
            this.Size = new System.Drawing.Size(624, 475);
            this.Load += new System.EventHandler(this.Agenda_Load);
            this.tlpAgendaMain.ResumeLayout(false);
            this.tlpChangeMonth.ResumeLayout(false);
            this.tbcAgenda.ResumeLayout(false);
            this.tbpAgenda.ResumeLayout(false);
            this.tbpAfspraken.ResumeLayout(false);
            this.tlpAfspraken.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAgendaMain;
        private System.Windows.Forms.TableLayoutPanel tlpAgendaGrid;
        private System.Windows.Forms.TabControl tbcAgenda;
        private System.Windows.Forms.TabPage tbpAgenda;
        private System.Windows.Forms.TabPage tbpAfspraken;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TableLayoutPanel tlpChangeMonth;
        private System.Windows.Forms.Button btnMonthBackwards;
        private System.Windows.Forms.Button btnMonthForward;
        private System.Windows.Forms.TableLayoutPanel tlpAfspraken;
        private System.Windows.Forms.ListBox lstAfspraken;
        private System.Windows.Forms.Label lblAfspraken;
        private System.Windows.Forms.TableLayoutPanel tlpData;
        private System.Windows.Forms.Label lblData;
    }
}
