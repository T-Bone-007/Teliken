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
            this.pbMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpHome
            // 
            this.tlpHome.ColumnCount = 6;
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tlpHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHome.Location = new System.Drawing.Point(0, 0);
            this.tlpHome.Name = "tlpHome";
            this.tlpHome.RowCount = 1;
            this.tlpHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHome.Size = new System.Drawing.Size(796, 100);
            this.tlpHome.TabIndex = 0;
            // 
            // pbMain
            // 
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMain.Location = new System.Drawing.Point(0, 100);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(796, 475);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMain.TabIndex = 1;
            this.pbMain.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.tlpHome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(796, 575);
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpHome;
        private System.Windows.Forms.PictureBox pbMain;
    }
}
