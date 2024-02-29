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
            this.pbHomeMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHomeMain
            // 
            this.pbHomeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbHomeMain.Location = new System.Drawing.Point(0, 0);
            this.pbHomeMain.Name = "pbHomeMain";
            this.pbHomeMain.Size = new System.Drawing.Size(796, 575);
            this.pbHomeMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHomeMain.TabIndex = 1;
            this.pbHomeMain.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbHomeMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(796, 575);
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHomeMain;
    }
}
