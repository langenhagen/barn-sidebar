namespace Sidebar
{
    partial class FrmSideBar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnHide = new System.Windows.Forms.Button();
            this.split1 = new System.Windows.Forms.SplitContainer();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.split2 = new System.Windows.Forms.SplitContainer();
            this.pnlExplorer1BG = new System.Windows.Forms.Panel();
            this.split3 = new System.Windows.Forms.SplitContainer();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.tmrHideWait = new System.Windows.Forms.Timer(this.components);
            this.tmrHideAnim = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateCursorPos = new System.Windows.Forms.Timer(this.components);
            this.tmrDummySetter = new System.Windows.Forms.Timer(this.components);
            this.expExplorer1 = new Sidebar.NewExplorer();
            this.expExplorer2 = new Sidebar.NewExplorer();
            ((System.ComponentModel.ISupportInitialize)(this.split1)).BeginInit();
            this.split1.Panel1.SuspendLayout();
            this.split1.Panel2.SuspendLayout();
            this.split1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split2)).BeginInit();
            this.split2.Panel1.SuspendLayout();
            this.split2.Panel2.SuspendLayout();
            this.split2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split3)).BeginInit();
            this.split3.Panel1.SuspendLayout();
            this.split3.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.Location = new System.Drawing.Point(151, 569);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 6;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // split1
            // 
            this.split1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.split1.BackColor = System.Drawing.SystemColors.Control;
            this.split1.Location = new System.Drawing.Point(0, 0);
            this.split1.Name = "split1";
            this.split1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split1.Panel1
            // 
            this.split1.Panel1.Controls.Add(this.txtNote);
            // 
            // split1.Panel2
            // 
            this.split1.Panel2.Controls.Add(this.split2);
            this.split1.Size = new System.Drawing.Size(229, 563);
            this.split1.SplitterDistance = 169;
            this.split1.SplitterWidth = 8;
            this.split1.TabIndex = 7;
            this.split1.TabStop = false;
            this.split1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.split1_SplitterMoved);
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.SystemColors.Window;
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.ForeColor = System.Drawing.Color.White;
            this.txtNote.Location = new System.Drawing.Point(0, 0);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(229, 169);
            this.txtNote.TabIndex = 6;
            this.txtNote.Leave += new System.EventHandler(this.txtNote_SaveText);
            // 
            // split2
            // 
            this.split2.BackColor = System.Drawing.SystemColors.Control;
            this.split2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split2.Location = new System.Drawing.Point(0, 0);
            this.split2.Name = "split2";
            this.split2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split2.Panel1
            // 
            this.split2.Panel1.Controls.Add(this.expExplorer1);
            this.split2.Panel1.Controls.Add(this.pnlExplorer1BG);
            // 
            // split2.Panel2
            // 
            this.split2.Panel2.Controls.Add(this.split3);
            this.split2.Size = new System.Drawing.Size(229, 386);
            this.split2.SplitterDistance = 111;
            this.split2.SplitterWidth = 8;
            this.split2.TabIndex = 0;
            this.split2.TabStop = false;
            this.split2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.split2_SplitterMoved);
            // 
            // pnlExplorer1BG
            // 
            this.pnlExplorer1BG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.pnlExplorer1BG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExplorer1BG.Location = new System.Drawing.Point(0, 0);
            this.pnlExplorer1BG.Name = "pnlExplorer1BG";
            this.pnlExplorer1BG.Size = new System.Drawing.Size(229, 111);
            this.pnlExplorer1BG.TabIndex = 4;
            // 
            // split3
            // 
            this.split3.BackColor = System.Drawing.SystemColors.Control;
            this.split3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split3.Location = new System.Drawing.Point(0, 0);
            this.split3.Name = "split3";
            this.split3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split3.Panel1
            // 
            this.split3.Panel1.Controls.Add(this.expExplorer2);
            // 
            // split3.Panel2
            // 
            this.split3.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.split3.Panel2MinSize = 0;
            this.split3.Size = new System.Drawing.Size(229, 267);
            this.split3.SplitterDistance = 159;
            this.split3.SplitterWidth = 8;
            this.split3.TabIndex = 1;
            this.split3.TabStop = false;
            this.split3.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.split3_SplitterMoved);
            // 
            // pnlBackground
            // 
            this.pnlBackground.Controls.Add(this.btnHide);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(229, 604);
            this.pnlBackground.TabIndex = 8;
            // 
            // tmrHideWait
            // 
            this.tmrHideWait.Interval = 1000;
            this.tmrHideWait.Tick += new System.EventHandler(this.tmrHideWait_Tick);
            // 
            // tmrHideAnim
            // 
            this.tmrHideAnim.Interval = 1;
            this.tmrHideAnim.Tick += new System.EventHandler(this.tmrHideAnim_Tick);
            // 
            // tmrUpdateCursorPos
            // 
            this.tmrUpdateCursorPos.Tick += new System.EventHandler(this.tmrUpdateCursorPos_Tick);
            // 
            // tmrDummySetter
            // 
            this.tmrDummySetter.Enabled = true;
            this.tmrDummySetter.Tick += new System.EventHandler(this.tmrDummySetter_Tick);
            // 
            // expExplorer1
            // 
            this.expExplorer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expExplorer1.Location = new System.Drawing.Point(0, 0);
            this.expExplorer1.MinimumSize = new System.Drawing.Size(20, 20);
            this.expExplorer1.Name = "expExplorer1";
            this.expExplorer1.Size = new System.Drawing.Size(229, 111);
            this.expExplorer1.TabIndex = 3;
            this.expExplorer1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.expExplorer1_DocumentCompleted);
            // 
            // expExplorer2
            // 
            this.expExplorer2.AllowWebBrowserDrop = false;
            this.expExplorer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expExplorer2.Location = new System.Drawing.Point(0, 0);
            this.expExplorer2.MinimumSize = new System.Drawing.Size(20, 20);
            this.expExplorer2.Name = "expExplorer2";
            this.expExplorer2.Size = new System.Drawing.Size(229, 159);
            this.expExplorer2.TabIndex = 6;
            this.expExplorer2.Url = new System.Uri("", System.UriKind.Relative);
            this.expExplorer2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.expExplorer2_DocumentCompleted);
            // 
            // FrmSideBar
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(229, 604);
            this.ControlBox = false;
            this.Controls.Add(this.split1);
            this.Controls.Add(this.pnlBackground);
            this.Name = "FrmSideBar";
            this.Deactivate += new System.EventHandler(this.txtNote_SaveText);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAeroSideBar_FormClosing);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResizeBegin += new System.EventHandler(this.FrmAeroSideBar_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.FrmAeroSideBar_ResizeEnd);
            this.split1.Panel1.ResumeLayout(false);
            this.split1.Panel1.PerformLayout();
            this.split1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split1)).EndInit();
            this.split1.ResumeLayout(false);
            this.split2.Panel1.ResumeLayout(false);
            this.split2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split2)).EndInit();
            this.split2.ResumeLayout(false);
            this.split3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split3)).EndInit();
            this.split3.ResumeLayout(false);
            this.pnlBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.SplitContainer split1;
        private System.Windows.Forms.SplitContainer split2;
        private System.Windows.Forms.TextBox txtNote;
        private NewExplorer expExplorer1;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlExplorer1BG;
        private System.Windows.Forms.SplitContainer split3;
        private NewExplorer expExplorer2;
        private System.Windows.Forms.Timer tmrUpdateCursorPos;
        private System.Windows.Forms.Timer tmrHideWait;
        private System.Windows.Forms.Timer tmrHideAnim;
        private System.Windows.Forms.Timer tmrDummySetter;
        
    }
}