namespace Sidebar
{
    partial class frmAbout
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblAbout = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpLicence = new System.Windows.Forms.GroupBox();
            this.txtLicence = new System.Windows.Forms.TextBox();
            this.lblAssembly = new System.Windows.Forms.Label();
            this.lblNoteRegistryKey = new System.Windows.Forms.Label();
            this.grpLicence.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(168, 9);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(178, 13);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "<assemblyname> v<versionnumber>";
            // 
            // pnlLogo
            // 
            this.pnlLogo.AutoSize = true;
            this.pnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogo.BackgroundImage")));
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlLogo.Location = new System.Drawing.Point(12, 9);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(150, 150);
            this.pnlLogo.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Location = new System.Drawing.Point(562, 289);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grpLicence
            // 
            this.grpLicence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLicence.Controls.Add(this.txtLicence);
            this.grpLicence.Location = new System.Drawing.Point(168, 45);
            this.grpLicence.Name = "grpLicence";
            this.grpLicence.Size = new System.Drawing.Size(469, 223);
            this.grpLicence.TabIndex = 4;
            this.grpLicence.TabStop = false;
            this.grpLicence.Text = "MIT Licence";
            // 
            // txtLicence
            // 
            this.txtLicence.BackColor = System.Drawing.SystemColors.Control;
            this.txtLicence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLicence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLicence.Location = new System.Drawing.Point(3, 16);
            this.txtLicence.Multiline = true;
            this.txtLicence.Name = "txtLicence";
            this.txtLicence.ReadOnly = true;
            this.txtLicence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLicence.Size = new System.Drawing.Size(463, 204);
            this.txtLicence.TabIndex = 0;
            this.txtLicence.Text = "<MIT-Licence>";
            // 
            // lblAssembly
            // 
            this.lblAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssembly.AutoEllipsis = true;
            this.lblAssembly.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblAssembly.Location = new System.Drawing.Point(12, 302);
            this.lblAssembly.Name = "lblAssembly";
            this.lblAssembly.Size = new System.Drawing.Size(544, 13);
            this.lblAssembly.TabIndex = 2;
            this.lblAssembly.Text = "<full assembly string>";
            // 
            // lblNoteRegistryKey
            // 
            this.lblNoteRegistryKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoteRegistryKey.AutoSize = true;
            this.lblNoteRegistryKey.Location = new System.Drawing.Point(12, 271);
            this.lblNoteRegistryKey.Name = "lblNoteRegistryKey";
            this.lblNoteRegistryKey.Size = new System.Drawing.Size(373, 13);
            this.lblNoteRegistryKey.TabIndex = 16;
            this.lblNoteRegistryKey.Text = "Note: This program stores a registry key at HKLM\\SOFTWARE\\Barn\\SideBar";
            // 
            // frmAbout
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOk;
            this.ClientSize = new System.Drawing.Size(649, 324);
            this.Controls.Add(this.lblNoteRegistryKey);
            this.Controls.Add(this.grpLicence);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblAssembly);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.lblAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(180, 250);
            this.Name = "frmAbout";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "<assemblyname> - About";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.grpLicence.ResumeLayout(false);
            this.grpLicence.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox grpLicence;
        private System.Windows.Forms.TextBox txtLicence;
        private System.Windows.Forms.Label lblAssembly;
        private System.Windows.Forms.Label lblNoteRegistryKey;

    }
}
