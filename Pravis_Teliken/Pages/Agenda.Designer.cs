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
            this.tbcAgenda = new System.Windows.Forms.TabControl();
            this.tbpAgenda = new System.Windows.Forms.TabPage();
            this.tbpAfspraken = new System.Windows.Forms.TabPage();
            this.tlpAgendaMain.SuspendLayout();
            this.tbcAgenda.SuspendLayout();
            this.tbpAgenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAgendaMain
            // 
            this.tlpAgendaMain.ColumnCount = 2;
            this.tlpAgendaMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgendaMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgendaMain.Controls.Add(this.tlpAgendaGrid, 0, 1);
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
            this.tbpAfspraken.Location = new System.Drawing.Point(4, 34);
            this.tbpAfspraken.Name = "tbpAfspraken";
            this.tbpAfspraken.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAfspraken.Size = new System.Drawing.Size(616, 437);
            this.tbpAfspraken.TabIndex = 1;
            this.tbpAfspraken.Text = "Afspraken";
            this.tbpAfspraken.UseVisualStyleBackColor = true;
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
            this.tbcAgenda.ResumeLayout(false);
            this.tbpAgenda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAgendaMain;
        private System.Windows.Forms.TableLayoutPanel tlpAgendaGrid;
        private System.Windows.Forms.TabControl tbcAgenda;
        private System.Windows.Forms.TabPage tbpAgenda;
        private System.Windows.Forms.TabPage tbpAfspraken;
    }
}
