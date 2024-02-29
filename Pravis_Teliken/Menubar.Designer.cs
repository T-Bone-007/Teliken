namespace Pravis_Teliken.Pages
{
    partial class Menubar
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
            this.tlpHome = new System.Windows.Forms.TableLayoutPanel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblAgenda = new System.Windows.Forms.Label();
            this.lblInlog = new System.Windows.Forms.Label();
            this.pbHomeLogo = new System.Windows.Forms.PictureBox();
            this.lblPravis = new System.Windows.Forms.Label();
            this.tlpHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpHome
            // 
            this.tlpHome.BackColor = System.Drawing.Color.SeaGreen;
            this.tlpHome.ColumnCount = 6;
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tlpHome.Controls.Add(this.lblAdmin, 3, 0);
            this.tlpHome.Controls.Add(this.lblAgenda, 4, 0);
            this.tlpHome.Controls.Add(this.lblInlog, 5, 0);
            this.tlpHome.Controls.Add(this.pbHomeLogo, 0, 0);
            this.tlpHome.Controls.Add(this.lblPravis, 1, 0);
            this.tlpHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHome.Location = new System.Drawing.Point(0, 0);
            this.tlpHome.Name = "tlpHome";
            this.tlpHome.RowCount = 1;
            this.tlpHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHome.Size = new System.Drawing.Size(794, 116);
            this.tlpHome.TabIndex = 4;
            // 
            // lblAdmin
            // 
            this.lblAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdmin.Location = new System.Drawing.Point(370, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(135, 116);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            // 
            // lblAgenda
            // 
            this.lblAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAgenda.Location = new System.Drawing.Point(511, 0);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(135, 116);
            this.lblAgenda.TabIndex = 1;
            this.lblAgenda.Text = "Agenda";
            this.lblAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAgenda.Click += new System.EventHandler(this.lblAgenda_Click);
            // 
            // lblInlog
            // 
            this.lblInlog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInlog.Location = new System.Drawing.Point(652, 0);
            this.lblInlog.Name = "lblInlog";
            this.lblInlog.Size = new System.Drawing.Size(139, 116);
            this.lblInlog.TabIndex = 2;
            this.lblInlog.Text = "Inlog";
            this.lblInlog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInlog.Click += new System.EventHandler(this.lblInlog_Click);
            // 
            // pbHomeLogo
            // 
            this.pbHomeLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbHomeLogo.Location = new System.Drawing.Point(3, 3);
            this.pbHomeLogo.Name = "pbHomeLogo";
            this.pbHomeLogo.Size = new System.Drawing.Size(79, 110);
            this.pbHomeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHomeLogo.TabIndex = 3;
            this.pbHomeLogo.TabStop = false;
            this.pbHomeLogo.Click += new System.EventHandler(this.pbHomeLogo_Click);
            // 
            // lblPravis
            // 
            this.lblPravis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPravis.Location = new System.Drawing.Point(88, 0);
            this.lblPravis.Name = "lblPravis";
            this.lblPravis.Size = new System.Drawing.Size(135, 116);
            this.lblPravis.TabIndex = 4;
            this.lblPravis.Text = "Pravis";
            this.lblPravis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menubar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpHome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Menubar";
            this.Size = new System.Drawing.Size(794, 116);
            this.Load += new System.EventHandler(this.Menubar_Load);
            this.tlpHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpHome;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblAgenda;
        private System.Windows.Forms.Label lblInlog;
        private System.Windows.Forms.PictureBox pbHomeLogo;
        private System.Windows.Forms.Label lblPravis;
    }
}
