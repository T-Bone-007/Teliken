namespace Pravis_Teliken.Pages
{
    partial class Admin
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
            this.tbpWachtlijst = new System.Windows.Forms.TabPage();
            this.tbpPatienten = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbPatienten = new System.Windows.Forms.ComboBox();
            this.btnAanpassenPatient = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbpArtsen = new System.Windows.Forms.TabPage();
            this.tbpGebruiker = new System.Windows.Forms.TabPage();
            this.tlpAgendaMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAgendaGrid = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcAdmin = new System.Windows.Forms.TabControl();
            this.cmbArtsen = new System.Windows.Forms.ComboBox();
            this.btnAanpassenArts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFunctie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgvWachtlijst = new System.Windows.Forms.DataGridView();
            this.dtgvArtsen = new System.Windows.Forms.DataGridView();
            this.dtgvPatienten = new System.Windows.Forms.DataGridView();
            this.tbpWachtlijst.SuspendLayout();
            this.tbpPatienten.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tbpArtsen.SuspendLayout();
            this.tbpGebruiker.SuspendLayout();
            this.tlpAgendaMain.SuspendLayout();
            this.tlpAgendaGrid.SuspendLayout();
            this.tbcAdmin.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWachtlijst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvArtsen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatienten)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpWachtlijst
            // 
            this.tbpWachtlijst.Controls.Add(this.dtgvWachtlijst);
            this.tbpWachtlijst.Location = new System.Drawing.Point(4, 39);
            this.tbpWachtlijst.Name = "tbpWachtlijst";
            this.tbpWachtlijst.Padding = new System.Windows.Forms.Padding(3);
            this.tbpWachtlijst.Size = new System.Drawing.Size(742, 425);
            this.tbpWachtlijst.TabIndex = 3;
            this.tbpWachtlijst.Text = "Wachtlijst";
            this.tbpWachtlijst.UseVisualStyleBackColor = true;
            // 
            // tbpPatienten
            // 
            this.tbpPatienten.Controls.Add(this.tableLayoutPanel2);
            this.tbpPatienten.Location = new System.Drawing.Point(4, 39);
            this.tbpPatienten.Name = "tbpPatienten";
            this.tbpPatienten.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPatienten.Size = new System.Drawing.Size(742, 425);
            this.tbpPatienten.TabIndex = 2;
            this.tbpPatienten.Text = "Patienten";
            this.tbpPatienten.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbStatus, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnAanpassenPatient, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtgvPatienten, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmbPatienten, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(736, 419);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cmbStatus.Location = new System.Drawing.Point(181, 169);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(172, 38);
            this.cmbStatus.TabIndex = 45;
            // 
            // cmbPatienten
            // 
            this.cmbPatienten.FormattingEnabled = true;
            this.cmbPatienten.Location = new System.Drawing.Point(181, 86);
            this.cmbPatienten.Name = "cmbPatienten";
            this.cmbPatienten.Size = new System.Drawing.Size(172, 38);
            this.cmbPatienten.TabIndex = 46;
            this.cmbPatienten.Text = "Select Patient";
            // 
            // btnAanpassenPatient
            // 
            this.btnAanpassenPatient.BackColor = System.Drawing.Color.Black;
            this.btnAanpassenPatient.ForeColor = System.Drawing.Color.White;
            this.btnAanpassenPatient.Location = new System.Drawing.Point(181, 252);
            this.btnAanpassenPatient.Name = "btnAanpassenPatient";
            this.btnAanpassenPatient.Size = new System.Drawing.Size(170, 41);
            this.btnAanpassenPatient.TabIndex = 0;
            this.btnAanpassenPatient.Text = "Aanpassen";
            this.btnAanpassenPatient.UseVisualStyleBackColor = false;
            this.btnAanpassenPatient.Click += new System.EventHandler(this.btnAanpassenPatient_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Patient";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Status";
            // 
            // tbpArtsen
            // 
            this.tbpArtsen.Controls.Add(this.tableLayoutPanel1);
            this.tbpArtsen.Location = new System.Drawing.Point(4, 39);
            this.tbpArtsen.Name = "tbpArtsen";
            this.tbpArtsen.Padding = new System.Windows.Forms.Padding(3);
            this.tbpArtsen.Size = new System.Drawing.Size(742, 425);
            this.tbpArtsen.TabIndex = 1;
            this.tbpArtsen.Text = "Artsen";
            this.tbpArtsen.UseVisualStyleBackColor = true;
            // 
            // tbpGebruiker
            // 
            this.tbpGebruiker.Controls.Add(this.tlpAgendaMain);
            this.tbpGebruiker.Location = new System.Drawing.Point(4, 39);
            this.tbpGebruiker.Name = "tbpGebruiker";
            this.tbpGebruiker.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGebruiker.Size = new System.Drawing.Size(742, 425);
            this.tbpGebruiker.TabIndex = 0;
            this.tbpGebruiker.Text = "Gebruiker+";
            this.tbpGebruiker.UseVisualStyleBackColor = true;
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
            this.tlpAgendaMain.Size = new System.Drawing.Size(736, 419);
            this.tlpAgendaMain.TabIndex = 0;
            // 
            // tlpAgendaGrid
            // 
            this.tlpAgendaGrid.BackColor = System.Drawing.Color.Transparent;
            this.tlpAgendaGrid.ColumnCount = 4;
            this.tlpAgendaMain.SetColumnSpan(this.tlpAgendaGrid, 2);
            this.tlpAgendaGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAgendaGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpAgendaGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpAgendaGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpAgendaGrid.Controls.Add(this.label2, 1, 0);
            this.tlpAgendaGrid.Controls.Add(this.txtName, 2, 0);
            this.tlpAgendaGrid.Controls.Add(this.label3, 1, 1);
            this.tlpAgendaGrid.Controls.Add(this.txtWachtwoord, 2, 1);
            this.tlpAgendaGrid.Controls.Add(this.label4, 1, 2);
            this.tlpAgendaGrid.Controls.Add(this.cmbRol, 2, 2);
            this.tlpAgendaGrid.Controls.Add(this.button1, 2, 3);
            this.tlpAgendaGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAgendaGrid.Location = new System.Drawing.Point(3, 44);
            this.tlpAgendaGrid.Name = "tlpAgendaGrid";
            this.tlpAgendaGrid.RowCount = 5;
            this.tlpAgendaGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAgendaGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAgendaGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAgendaGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAgendaGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAgendaGrid.Size = new System.Drawing.Size(730, 372);
            this.tlpAgendaGrid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(379, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Voeg toe";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cmbRol.Location = new System.Drawing.Point(379, 151);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(170, 38);
            this.cmbRol.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rol";
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Location = new System.Drawing.Point(379, 77);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.Size = new System.Drawing.Size(170, 37);
            this.txtWachtwoord.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wachtwoord";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(379, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 37);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naam";
            // 
            // tbcAdmin
            // 
            this.tbcAdmin.Controls.Add(this.tbpGebruiker);
            this.tbcAdmin.Controls.Add(this.tbpArtsen);
            this.tbcAdmin.Controls.Add(this.tbpPatienten);
            this.tbcAdmin.Controls.Add(this.tbpWachtlijst);
            this.tbcAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcAdmin.Location = new System.Drawing.Point(0, 0);
            this.tbcAdmin.Name = "tbcAdmin";
            this.tbcAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbcAdmin.SelectedIndex = 0;
            this.tbcAdmin.Size = new System.Drawing.Size(750, 468);
            this.tbcAdmin.TabIndex = 2;
            // 
            // cmbArtsen
            // 
            this.cmbArtsen.DisplayMember = "(none)";
            this.cmbArtsen.FormattingEnabled = true;
            this.cmbArtsen.Location = new System.Drawing.Point(181, 86);
            this.cmbArtsen.Name = "cmbArtsen";
            this.cmbArtsen.Size = new System.Drawing.Size(172, 38);
            this.cmbArtsen.TabIndex = 45;
            this.cmbArtsen.Text = "Select Arts";
            this.cmbArtsen.SelectedIndexChanged += new System.EventHandler(this.cmbArtsen_SelectedIndexChanged);
            // 
            // btnAanpassenArts
            // 
            this.btnAanpassenArts.BackColor = System.Drawing.Color.Black;
            this.btnAanpassenArts.ForeColor = System.Drawing.Color.White;
            this.btnAanpassenArts.Location = new System.Drawing.Point(181, 252);
            this.btnAanpassenArts.Name = "btnAanpassenArts";
            this.btnAanpassenArts.Size = new System.Drawing.Size(170, 41);
            this.btnAanpassenArts.TabIndex = 0;
            this.btnAanpassenArts.Text = "Aanpassen";
            this.btnAanpassenArts.UseVisualStyleBackColor = false;
            this.btnAanpassenArts.Click += new System.EventHandler(this.btnAanpassenArts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arts";
            // 
            // txtFunctie
            // 
            this.txtFunctie.Location = new System.Drawing.Point(181, 169);
            this.txtFunctie.Name = "txtFunctie";
            this.txtFunctie.Size = new System.Drawing.Size(170, 37);
            this.txtFunctie.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Functie";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbArtsen, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFunctie, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAanpassenArts, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtgvArtsen, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(736, 419);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dtgvWachtlijst
            // 
            this.dtgvWachtlijst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvWachtlijst.Location = new System.Drawing.Point(52, 80);
            this.dtgvWachtlijst.Name = "dtgvWachtlijst";
            this.dtgvWachtlijst.RowHeadersWidth = 51;
            this.dtgvWachtlijst.RowTemplate.Height = 24;
            this.dtgvWachtlijst.Size = new System.Drawing.Size(618, 306);
            this.dtgvWachtlijst.TabIndex = 0;
            // 
            // dtgvArtsen
            // 
            this.dtgvArtsen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvArtsen.Location = new System.Drawing.Point(559, 86);
            this.dtgvArtsen.Name = "dtgvArtsen";
            this.dtgvArtsen.RowHeadersWidth = 51;
            this.dtgvArtsen.RowTemplate.Height = 24;
            this.dtgvArtsen.Size = new System.Drawing.Size(174, 77);
            this.dtgvArtsen.TabIndex = 46;
            // 
            // dtgvPatienten
            // 
            this.dtgvPatienten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPatienten.Location = new System.Drawing.Point(559, 86);
            this.dtgvPatienten.Name = "dtgvPatienten";
            this.dtgvPatienten.RowHeadersWidth = 51;
            this.dtgvPatienten.RowTemplate.Height = 24;
            this.dtgvPatienten.Size = new System.Drawing.Size(174, 77);
            this.dtgvPatienten.TabIndex = 47;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcAdmin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(750, 468);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tbpWachtlijst.ResumeLayout(false);
            this.tbpPatienten.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tbpArtsen.ResumeLayout(false);
            this.tbpGebruiker.ResumeLayout(false);
            this.tlpAgendaMain.ResumeLayout(false);
            this.tlpAgendaGrid.ResumeLayout(false);
            this.tlpAgendaGrid.PerformLayout();
            this.tbcAdmin.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWachtlijst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvArtsen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatienten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpWachtlijst;
        private System.Windows.Forms.TabPage tbpPatienten;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAanpassenPatient;
        private System.Windows.Forms.ComboBox cmbPatienten;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TabPage tbpArtsen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFunctie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAanpassenArts;
        private System.Windows.Forms.ComboBox cmbArtsen;
        private System.Windows.Forms.TabPage tbpGebruiker;
        private System.Windows.Forms.TableLayoutPanel tlpAgendaMain;
        private System.Windows.Forms.TableLayoutPanel tlpAgendaGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tbcAdmin;
        private System.Windows.Forms.DataGridView dtgvWachtlijst;
        private System.Windows.Forms.DataGridView dtgvArtsen;
        private System.Windows.Forms.DataGridView dtgvPatienten;
    }
}
