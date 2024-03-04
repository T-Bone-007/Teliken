namespace Pravis_Teliken.Pages
{
    partial class Inlog
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
            this.btnInlog = new System.Windows.Forms.Button();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.tlpMainInlog = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNaam = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlPass.SuspendLayout();
            this.tlpMainInlog.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInlog
            // 
            this.btnInlog.BackColor = System.Drawing.Color.Black;
            this.btnInlog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInlog.ForeColor = System.Drawing.Color.White;
            this.btnInlog.Location = new System.Drawing.Point(275, 310);
            this.btnInlog.Name = "btnInlog";
            this.btnInlog.Size = new System.Drawing.Size(266, 53);
            this.btnInlog.TabIndex = 0;
            this.btnInlog.Text = "Inlog";
            this.btnInlog.UseVisualStyleBackColor = false;
            this.btnInlog.Click += new System.EventHandler(this.btnInlog_Click);
            // 
            // pnlPass
            // 
            this.pnlPass.BackColor = System.Drawing.Color.Black;
            this.pnlPass.Controls.Add(this.label1);
            this.pnlPass.Controls.Add(this.lblPass);
            this.pnlPass.Controls.Add(this.txtPass);
            this.pnlPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPass.ForeColor = System.Drawing.Color.White;
            this.pnlPass.Location = new System.Drawing.Point(275, 230);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(266, 74);
            this.pnlPass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wachtwoord:";
            // 
            // lblPass
            // 
            this.lblPass.BackColor = System.Drawing.Color.SeaGreen;
            this.lblPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPass.Location = new System.Drawing.Point(0, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(266, 37);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Wachtwoord:";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(0, 37);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(266, 37);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // tlpMainInlog
            // 
            this.tlpMainInlog.BackColor = System.Drawing.Color.White;
            this.tlpMainInlog.ColumnCount = 3;
            this.tlpMainInlog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlpMainInlog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpMainInlog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpMainInlog.Controls.Add(this.pnlPass, 1, 3);
            this.tlpMainInlog.Controls.Add(this.btnInlog, 1, 4);
            this.tlpMainInlog.Controls.Add(this.panel2, 1, 2);
            this.tlpMainInlog.Controls.Add(this.label3, 1, 1);
            this.tlpMainInlog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainInlog.Location = new System.Drawing.Point(0, 0);
            this.tlpMainInlog.Name = "tlpMainInlog";
            this.tlpMainInlog.RowCount = 6;
            this.tlpMainInlog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainInlog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMainInlog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMainInlog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMainInlog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMainInlog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainInlog.Size = new System.Drawing.Size(817, 455);
            this.tlpMainInlog.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNaam);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(275, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 74);
            this.panel2.TabIndex = 15;
            // 
            // lblNaam
            // 
            this.lblNaam.BackColor = System.Drawing.Color.SeaGreen;
            this.lblNaam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNaam.ForeColor = System.Drawing.Color.White;
            this.lblNaam.Location = new System.Drawing.Point(0, 0);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(266, 37);
            this.lblNaam.TabIndex = 18;
            this.lblNaam.Text = "Naam";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(0, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(266, 37);
            this.txtName.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(275, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 80);
            this.label3.TabIndex = 16;
            this.label3.Text = "Inloggen";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Inlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMainInlog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Inlog";
            this.Size = new System.Drawing.Size(817, 455);
            this.Load += new System.EventHandler(this.Inlog_Load);
            this.pnlPass.ResumeLayout(false);
            this.pnlPass.PerformLayout();
            this.tlpMainInlog.ResumeLayout(false);
            this.tlpMainInlog.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInlog;
        private System.Windows.Forms.Panel pnlPass;
        private System.Windows.Forms.TableLayoutPanel tlpMainInlog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
    }
}
