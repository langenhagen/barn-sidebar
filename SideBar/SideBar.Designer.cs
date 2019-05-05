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
            this.tabHigh = new System.Windows.Forms.TabControl();
            this.tabHigh1 = new System.Windows.Forms.TabPage();
            this.tabHigh2 = new System.Windows.Forms.TabPage();
            this.tabHigh3 = new System.Windows.Forms.TabPage();
            this.split3 = new System.Windows.Forms.SplitContainer();
            this.tabLow = new System.Windows.Forms.TabControl();
            this.tabLow1 = new System.Windows.Forms.TabPage();
            this.tabLow2 = new System.Windows.Forms.TabPage();
            this.tabLow3 = new System.Windows.Forms.TabPage();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.tmrHideWait = new System.Windows.Forms.Timer(this.components);
            this.tmrHideAnim = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateCursorPos = new System.Windows.Forms.Timer(this.components);
            this.tmrDummySetter = new System.Windows.Forms.Timer(this.components);
            this.expHigh1 = new Sidebar.NewExplorer();
            this.expHigh2 = new Sidebar.NewExplorer();
            this.expHigh3 = new Sidebar.NewExplorer();
            this.expLow1 = new Sidebar.NewExplorer();
            this.expLow2 = new Sidebar.NewExplorer();
            this.expLow3 = new Sidebar.NewExplorer();
            ((System.ComponentModel.ISupportInitialize)(this.split1)).BeginInit();
            this.split1.Panel1.SuspendLayout();
            this.split1.Panel2.SuspendLayout();
            this.split1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split2)).BeginInit();
            this.split2.Panel1.SuspendLayout();
            this.split2.Panel2.SuspendLayout();
            this.split2.SuspendLayout();
            this.tabHigh.SuspendLayout();
            this.tabHigh1.SuspendLayout();
            this.tabHigh2.SuspendLayout();
            this.tabHigh3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split3)).BeginInit();
            this.split3.Panel1.SuspendLayout();
            this.split3.SuspendLayout();
            this.tabLow.SuspendLayout();
            this.tabLow1.SuspendLayout();
            this.tabLow2.SuspendLayout();
            this.tabLow3.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.Location = new System.Drawing.Point(184, 560);
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
            this.split1.Size = new System.Drawing.Size(262, 554);
            this.split1.SplitterDistance = 87;
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
            this.txtNote.Size = new System.Drawing.Size(262, 87);
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
            this.split2.Panel1.Controls.Add(this.tabHigh);
            // 
            // split2.Panel2
            // 
            this.split2.Panel2.Controls.Add(this.split3);
            this.split2.Size = new System.Drawing.Size(262, 459);
            this.split2.SplitterDistance = 199;
            this.split2.SplitterWidth = 8;
            this.split2.TabIndex = 0;
            this.split2.TabStop = false;
            this.split2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.split2_SplitterMoved);
            // 
            // tabHigh
            // 
            this.tabHigh.Controls.Add(this.tabHigh1);
            this.tabHigh.Controls.Add(this.tabHigh2);
            this.tabHigh.Controls.Add(this.tabHigh3);
            this.tabHigh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHigh.Location = new System.Drawing.Point(0, 0);
            this.tabHigh.Name = "tabHigh";
            this.tabHigh.SelectedIndex = 0;
            this.tabHigh.Size = new System.Drawing.Size(262, 199);
            this.tabHigh.TabIndex = 5;
            this.tabHigh.Click += new System.EventHandler(this.tabHigh_Click);
            this.tabHigh.DoubleClick += new System.EventHandler(this.tabHigh_DoubleClick);
            this.tabHigh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabHigh_MouseDown);
            // 
            // tabHigh1
            // 
            this.tabHigh1.Controls.Add(this.expHigh1);
            this.tabHigh1.Location = new System.Drawing.Point(4, 22);
            this.tabHigh1.Name = "tabHigh1";
            this.tabHigh1.Padding = new System.Windows.Forms.Padding(3);
            this.tabHigh1.Size = new System.Drawing.Size(254, 173);
            this.tabHigh1.TabIndex = 0;
            this.tabHigh1.Text = "Dropbox";
            this.tabHigh1.UseVisualStyleBackColor = true;
            // 
            // tabHigh2
            // 
            this.tabHigh2.Controls.Add(this.expHigh2);
            this.tabHigh2.Location = new System.Drawing.Point(4, 22);
            this.tabHigh2.Name = "tabHigh2";
            this.tabHigh2.Padding = new System.Windows.Forms.Padding(3);
            this.tabHigh2.Size = new System.Drawing.Size(254, 173);
            this.tabHigh2.TabIndex = 1;
            this.tabHigh2.Text = "Music";
            this.tabHigh2.UseVisualStyleBackColor = true;
            // 
            // tabHigh3
            // 
            this.tabHigh3.Controls.Add(this.expHigh3);
            this.tabHigh3.Location = new System.Drawing.Point(4, 22);
            this.tabHigh3.Name = "tabHigh3";
            this.tabHigh3.Padding = new System.Windows.Forms.Padding(3);
            this.tabHigh3.Size = new System.Drawing.Size(254, 173);
            this.tabHigh3.TabIndex = 2;
            this.tabHigh3.Text = "Software";
            this.tabHigh3.UseVisualStyleBackColor = true;
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
            this.split3.Panel1.Controls.Add(this.tabLow);
            // 
            // split3.Panel2
            // 
            this.split3.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.split3.Panel2MinSize = 0;
            this.split3.Size = new System.Drawing.Size(262, 252);
            this.split3.SplitterDistance = 192;
            this.split3.SplitterWidth = 8;
            this.split3.TabIndex = 1;
            this.split3.TabStop = false;
            this.split3.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.split3_SplitterMoved);
            // 
            // tabLow
            // 
            this.tabLow.Controls.Add(this.tabLow1);
            this.tabLow.Controls.Add(this.tabLow2);
            this.tabLow.Controls.Add(this.tabLow3);
            this.tabLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLow.Location = new System.Drawing.Point(0, 0);
            this.tabLow.Name = "tabLow";
            this.tabLow.SelectedIndex = 0;
            this.tabLow.Size = new System.Drawing.Size(262, 192);
            this.tabLow.TabIndex = 7;
            this.tabLow.Click += new System.EventHandler(this.tabLow_Click);
            this.tabLow.DoubleClick += new System.EventHandler(this.tabLow_DoubleClick);
            this.tabLow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabLow_MouseDown);
            // 
            // tabLow1
            // 
            this.tabLow1.Controls.Add(this.expLow1);
            this.tabLow1.Location = new System.Drawing.Point(4, 22);
            this.tabLow1.Name = "tabLow1";
            this.tabLow1.Padding = new System.Windows.Forms.Padding(3);
            this.tabLow1.Size = new System.Drawing.Size(254, 166);
            this.tabLow1.TabIndex = 0;
            this.tabLow1.Text = "System";
            this.tabLow1.UseVisualStyleBackColor = true;
            // 
            // tabLow2
            // 
            this.tabLow2.Controls.Add(this.expLow2);
            this.tabLow2.Location = new System.Drawing.Point(4, 22);
            this.tabLow2.Name = "tabLow2";
            this.tabLow2.Padding = new System.Windows.Forms.Padding(3);
            this.tabLow2.Size = new System.Drawing.Size(254, 166);
            this.tabLow2.TabIndex = 1;
            this.tabLow2.Text = "Dev";
            this.tabLow2.UseVisualStyleBackColor = true;
            // 
            // tabLow3
            // 
            this.tabLow3.Controls.Add(this.expLow3);
            this.tabLow3.Location = new System.Drawing.Point(4, 22);
            this.tabLow3.Name = "tabLow3";
            this.tabLow3.Padding = new System.Windows.Forms.Padding(3);
            this.tabLow3.Size = new System.Drawing.Size(254, 166);
            this.tabLow3.TabIndex = 2;
            this.tabLow3.Text = "Uni";
            this.tabLow3.UseVisualStyleBackColor = true;
            // 
            // pnlBackground
            // 
            this.pnlBackground.Controls.Add(this.btnHide);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(262, 595);
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
            // expHigh1
            // 
            this.expHigh1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expHigh1.FolderViewMode = Sidebar.FolderviewMode.Invalid;
            this.expHigh1.Location = new System.Drawing.Point(3, 3);
            this.expHigh1.MinimumSize = new System.Drawing.Size(20, 20);
            this.expHigh1.Name = "expHigh1";
            this.expHigh1.Size = new System.Drawing.Size(248, 167);
            this.expHigh1.TabIndex = 5;
            this.expHigh1.Url = new System.Uri("C:\\Users\\Barn\\Dropbox", System.UriKind.Absolute);
            this.expHigh1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.expHigh1_DocumentCompleted);
            this.expHigh1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.expHigh1_Navigated);
            this.expHigh1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.expHigh1_PreviewKeyDown);
            // 
            // expHigh2
            // 
            this.expHigh2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expHigh2.FolderViewMode = Sidebar.FolderviewMode.Invalid;
            this.expHigh2.Location = new System.Drawing.Point(3, 3);
            this.expHigh2.MinimumSize = new System.Drawing.Size(20, 20);
            this.expHigh2.Name = "expHigh2";
            this.expHigh2.Size = new System.Drawing.Size(248, 167);
            this.expHigh2.TabIndex = 5;
            this.expHigh2.Url = new System.Uri("E:\\Musik", System.UriKind.Absolute);
            this.expHigh2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.expHigh2_DocumentCompleted);
            this.expHigh2.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.expHigh2_Navigated);
            this.expHigh2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.expHigh2_PreviewKeyDown);
            // 
            // expHigh3
            // 
            this.expHigh3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expHigh3.FolderViewMode = Sidebar.FolderviewMode.Invalid;
            this.expHigh3.Location = new System.Drawing.Point(3, 3);
            this.expHigh3.MinimumSize = new System.Drawing.Size(20, 20);
            this.expHigh3.Name = "expHigh3";
            this.expHigh3.Size = new System.Drawing.Size(248, 167);
            this.expHigh3.TabIndex = 6;
            this.expHigh3.Url = new System.Uri("H:\\", System.UriKind.Absolute);
            this.expHigh3.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.expHigh3_DocumentCompleted);
            this.expHigh3.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.expHigh3_Navigated);
            this.expHigh3.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.expHigh3_PreviewKeyDown);
            // 
            // expLow1
            // 
            this.expLow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expLow1.FolderViewMode = Sidebar.FolderviewMode.Invalid;
            this.expLow1.Location = new System.Drawing.Point(3, 3);
            this.expLow1.MinimumSize = new System.Drawing.Size(20, 20);
            this.expLow1.Name = "expLow1";
            this.expLow1.Size = new System.Drawing.Size(248, 160);
            this.expLow1.TabIndex = 4;
            this.expLow1.Url = new System.Uri("shell:::{20d04fe0-3aea-1069-a2d8-08002b30309d}\"", System.UriKind.Absolute);
            this.expLow1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.expLow1_DocumentCompleted);
            this.expLow1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.expLow1_Navigated);
            this.expLow1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.expLow1_PreviewKeyDown);
            // 
            // expLow2
            // 
            this.expLow2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expLow2.FolderViewMode = Sidebar.FolderviewMode.Invalid;
            this.expLow2.Location = new System.Drawing.Point(3, 3);
            this.expLow2.MinimumSize = new System.Drawing.Size(20, 20);
            this.expLow2.Name = "expLow2";
            this.expLow2.Size = new System.Drawing.Size(248, 160);
            this.expLow2.TabIndex = 5;
            this.expLow2.Url = new System.Uri("G:\\", System.UriKind.Absolute);
            this.expLow2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.expLow2_DocumentCompleted);
            this.expLow2.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.expLow2_Navigated);
            this.expLow2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.expLow2_PreviewKeyDown);
            // 
            // expLow3
            // 
            this.expLow3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expLow3.FolderViewMode = Sidebar.FolderviewMode.Invalid;
            this.expLow3.Location = new System.Drawing.Point(3, 3);
            this.expLow3.MinimumSize = new System.Drawing.Size(20, 20);
            this.expLow3.Name = "expLow3";
            this.expLow3.Size = new System.Drawing.Size(248, 160);
            this.expLow3.TabIndex = 6;
            this.expLow3.Url = new System.Uri("F:\\", System.UriKind.Absolute);
            this.expLow3.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.expLow3_DocumentCompleted);
            this.expLow3.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.expLow3_Navigated);
            this.expLow3.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.expLow3_PreviewKeyDown);
            // 
            // FrmSideBar
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(262, 595);
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
            this.tabHigh.ResumeLayout(false);
            this.tabHigh1.ResumeLayout(false);
            this.tabHigh2.ResumeLayout(false);
            this.tabHigh3.ResumeLayout(false);
            this.split3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split3)).EndInit();
            this.split3.ResumeLayout(false);
            this.tabLow.ResumeLayout(false);
            this.tabLow1.ResumeLayout(false);
            this.tabLow2.ResumeLayout(false);
            this.tabLow3.ResumeLayout(false);
            this.pnlBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.SplitContainer split1;
        private System.Windows.Forms.SplitContainer split2;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.SplitContainer split3;
        private System.Windows.Forms.Timer tmrUpdateCursorPos;
        private System.Windows.Forms.Timer tmrHideWait;
        private System.Windows.Forms.Timer tmrHideAnim;
        private System.Windows.Forms.Timer tmrDummySetter;
        private System.Windows.Forms.TabControl tabLow;
        private System.Windows.Forms.TabPage tabLow1;
        private NewExplorer expLow1;
        private System.Windows.Forms.TabPage tabLow2;
        private NewExplorer expLow2;
        private System.Windows.Forms.TabPage tabLow3;
        private NewExplorer expLow3;
        private System.Windows.Forms.TabControl tabHigh;
        private System.Windows.Forms.TabPage tabHigh1;
        private NewExplorer expHigh1;
        private System.Windows.Forms.TabPage tabHigh2;
        private NewExplorer expHigh2;
        private System.Windows.Forms.TabPage tabHigh3;
        private NewExplorer expHigh3;
        
    }
}