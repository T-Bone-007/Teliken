namespace Pravis_Teliken
{
    partial class AfspraakMaken
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
            this.lblAfspraakMaken = new System.Windows.Forms.Label();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.btnMaken = new System.Windows.Forms.Button();
            this.lblInfoDatum = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.cmbPatienten = new System.Windows.Forms.ComboBox();
            this.tlpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAfspraakMaken
            // 
            this.lblAfspraakMaken.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAfspraakMaken.Location = new System.Drawing.Point(0, 0);
            this.lblAfspraakMaken.Name = "lblAfspraakMaken";
            this.lblAfspraakMaken.Size = new System.Drawing.Size(410, 25);
            this.lblAfspraakMaken.TabIndex = 0;
            this.lblAfspraakMaken.Text = "Afspraak Maken";
            this.lblAfspraakMaken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpInfo
            // 
            this.tlpInfo.ColumnCount = 3;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInfo.Controls.Add(this.btnMaken, 2, 3);
            this.tlpInfo.Controls.Add(this.lblInfoDatum, 0, 0);
            this.tlpInfo.Controls.Add(this.lblDatum, 1, 0);
            this.tlpInfo.Controls.Add(this.lblPatient, 0, 1);
            this.tlpInfo.Controls.Add(this.cmbPatienten, 1, 1);
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfo.Location = new System.Drawing.Point(0, 25);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 4;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpInfo.Size = new System.Drawing.Size(410, 385);
            this.tlpInfo.TabIndex = 1;
            // 
            // btnMaken
            // 
            this.btnMaken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaken.Location = new System.Drawing.Point(275, 291);
            this.btnMaken.Name = "btnMaken";
            this.btnMaken.Size = new System.Drawing.Size(132, 91);
            this.btnMaken.TabIndex = 0;
            this.btnMaken.Text = "Maak afspraak";
            this.btnMaken.UseVisualStyleBackColor = true;
            this.btnMaken.Click += new System.EventHandler(this.btnMaken_Click);
            // 
            // lblInfoDatum
            // 
            this.lblInfoDatum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoDatum.Location = new System.Drawing.Point(3, 0);
            this.lblInfoDatum.Name = "lblInfoDatum";
            this.lblInfoDatum.Size = new System.Drawing.Size(130, 96);
            this.lblInfoDatum.TabIndex = 1;
            this.lblInfoDatum.Text = "Datum:";
            // 
            // lblDatum
            // 
            this.lblDatum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatum.Location = new System.Drawing.Point(139, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(130, 96);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "dedatum";
            // 
            // lblPatient
            // 
            this.lblPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPatient.Location = new System.Drawing.Point(3, 96);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(130, 96);
            this.lblPatient.TabIndex = 3;
            this.lblPatient.Text = "Patient:";
            // 
            // cmbPatienten
            // 
            this.cmbPatienten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPatienten.FormattingEnabled = true;
            this.cmbPatienten.Location = new System.Drawing.Point(139, 99);
            this.cmbPatienten.Name = "cmbPatienten";
            this.cmbPatienten.Size = new System.Drawing.Size(130, 33);
            this.cmbPatienten.TabIndex = 4;
            // 
            // AfspraakMaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpInfo);
            this.Controls.Add(this.lblAfspraakMaken);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AfspraakMaken";
            this.Size = new System.Drawing.Size(410, 410);
            this.Load += new System.EventHandler(this.AfspraakMaken_Load);
            this.tlpInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAfspraakMaken;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.Button btnMaken;
        private System.Windows.Forms.Label lblInfoDatum;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ComboBox cmbPatienten;
    }
}
