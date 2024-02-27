namespace Pravis_Teliken.Pages
{
    partial class HomePage
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
            this.pbHomeMain = new System.Windows.Forms.PictureBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblAgenda = new System.Windows.Forms.Label();
            this.lblInlog = new System.Windows.Forms.Label();
            this.pbHomeLogo = new System.Windows.Forms.PictureBox();
            this.tlpHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeMain)).BeginInit();
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
            this.tlpHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHome.Location = new System.Drawing.Point(0, 0);
            this.tlpHome.Name = "tlpHome";
            this.tlpHome.RowCount = 1;
            this.tlpHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHome.Size = new System.Drawing.Size(796, 100);
            this.tlpHome.TabIndex = 0;
            // 
            // pbHomeMain
            // 
            this.pbHomeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbHomeMain.Location = new System.Drawing.Point(0, 100);
            this.pbHomeMain.Name = "pbHomeMain";
            this.pbHomeMain.Size = new System.Drawing.Size(796, 475);
            this.pbHomeMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHomeMain.TabIndex = 1;
            this.pbHomeMain.TabStop = false;
            // 
            // lblAdmin
            // 
            this.lblAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdmin.Location = new System.Drawing.Point(372, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(136, 100);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            // 
            // lblAgenda
            // 
            this.lblAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAgenda.Location = new System.Drawing.Point(514, 0);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(136, 100);
            this.lblAgenda.TabIndex = 1;
            this.lblAgenda.Text = "Agenda";
            this.lblAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAgenda.Click += new System.EventHandler(this.lblAgenda_Click);
            // 
            // lblInlog
            // 
            this.lblInlog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInlog.Location = new System.Drawing.Point(656, 0);
            this.lblInlog.Name = "lblInlog";
            this.lblInlog.Size = new System.Drawing.Size(137, 100);
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
            this.pbHomeLogo.Size = new System.Drawing.Size(79, 94);
            this.pbHomeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHomeLogo.TabIndex = 3;
            this.pbHomeLogo.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbHomeMain);
            this.Controls.Add(this.tlpHome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(796, 575);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.tlpHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpHome;
        private System.Windows.Forms.PictureBox pbHomeMain;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblAgenda;
        private System.Windows.Forms.Label lblInlog;
        private System.Windows.Forms.PictureBox pbHomeLogo;
    }
}
