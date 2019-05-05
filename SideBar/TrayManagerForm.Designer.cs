namespace Sidebar
{
    partial class FrmPreferences
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblOr2;
            System.Windows.Forms.Label lblNote;
            System.Windows.Forms.Label lblAutoShowWaitTime;
            System.Windows.Forms.Label lblAutoHideTime;
            System.Windows.Forms.Label lblAutoHideSpeed;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreferences));
            System.Windows.Forms.GroupBox grpNote;
            System.Windows.Forms.GroupBox grpAutoHide;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label lblDir2View;
            System.Windows.Forms.Label lblDir1View;
            System.Windows.Forms.Label lblOr1;
            System.Windows.Forms.GroupBox grpDir1;
            this.icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuHide = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUseComputerDir2 = new System.Windows.Forms.Button();
            this.btnDir2Path = new System.Windows.Forms.Button();
            this.txtDir2Path = new System.Windows.Forms.TextBox();
            this.btnNotePath = new System.Windows.Forms.Button();
            this.txtNotePath = new System.Windows.Forms.TextBox();
            this.dlgFolderNote = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgFolderDir1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgFolderDir2 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlTextColor = new System.Windows.Forms.Panel();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.dlgTextColor = new System.Windows.Forms.ColorDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.nudAutoShowWaitTime = new System.Windows.Forms.NumericUpDown();
            this.nudAutoHideWaitTime = new System.Windows.Forms.NumericUpDown();
            this.pnlHiddenBarColor = new System.Windows.Forms.Panel();
            this.btnHiddenBarColor = new System.Windows.Forms.Button();
            this.chkAutoHide = new System.Windows.Forms.CheckBox();
            this.nudAutoHideSpeed = new System.Windows.Forms.NumericUpDown();
            this.dlgHiddenBarColor = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbDir2View = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbDir1View = new System.Windows.Forms.ComboBox();
            this.btnUseComputerDir1 = new System.Windows.Forms.Button();
            this.btnDir1Path = new System.Windows.Forms.Button();
            this.txtDir1Path = new System.Windows.Forms.TextBox();
            lblOr2 = new System.Windows.Forms.Label();
            lblNote = new System.Windows.Forms.Label();
            lblAutoShowWaitTime = new System.Windows.Forms.Label();
            lblAutoHideTime = new System.Windows.Forms.Label();
            lblAutoHideSpeed = new System.Windows.Forms.Label();
            grpNote = new System.Windows.Forms.GroupBox();
            grpAutoHide = new System.Windows.Forms.GroupBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            lblDir2View = new System.Windows.Forms.Label();
            lblDir1View = new System.Windows.Forms.Label();
            lblOr1 = new System.Windows.Forms.Label();
            grpDir1 = new System.Windows.Forms.GroupBox();
            this.mnuTrayMenu.SuspendLayout();
            grpNote.SuspendLayout();
            grpAutoHide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoShowWaitTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoHideWaitTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoHideSpeed)).BeginInit();
            groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            grpDir1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOr2
            // 
            lblOr2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblOr2.AutoSize = true;
            lblOr2.Location = new System.Drawing.Point(330, 25);
            lblOr2.Name = "lblOr2";
            lblOr2.Size = new System.Drawing.Size(16, 13);
            lblOr2.TabIndex = 22;
            lblOr2.Text = "or";
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new System.Drawing.Point(6, 16);
            lblNote.Name = "lblNote";
            lblNote.Size = new System.Drawing.Size(49, 13);
            lblNote.TabIndex = 10;
            lblNote.Text = "Note-file:";
            // 
            // lblAutoShowWaitTime
            // 
            lblAutoShowWaitTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblAutoShowWaitTime.AutoSize = true;
            lblAutoShowWaitTime.Location = new System.Drawing.Point(261, 75);
            lblAutoShowWaitTime.Name = "lblAutoShowWaitTime";
            lblAutoShowWaitTime.Size = new System.Drawing.Size(122, 13);
            lblAutoShowWaitTime.TabIndex = 23;
            lblAutoShowWaitTime.Text = "Auto open wait time (ms)";
            // 
            // lblAutoHideTime
            // 
            lblAutoHideTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblAutoHideTime.AutoSize = true;
            lblAutoHideTime.Location = new System.Drawing.Point(265, 46);
            lblAutoHideTime.Name = "lblAutoHideTime";
            lblAutoHideTime.Size = new System.Drawing.Size(118, 13);
            lblAutoHideTime.TabIndex = 21;
            lblAutoHideTime.Text = "Auto hide wait time (ms)";
            // 
            // lblAutoHideSpeed
            // 
            lblAutoHideSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblAutoHideSpeed.AutoSize = true;
            lblAutoHideSpeed.Location = new System.Drawing.Point(222, 23);
            lblAutoHideSpeed.Name = "lblAutoHideSpeed";
            lblAutoHideSpeed.Size = new System.Drawing.Size(161, 13);
            lblAutoHideSpeed.TabIndex = 17;
            lblAutoHideSpeed.Text = "Auto hide/open speed( pixel/ms)";
            // 
            // icon
            // 
            this.icon.ContextMenuStrip = this.mnuTrayMenu;
            this.icon.Icon = ((System.Drawing.Icon)(resources.GetObject("icon.Icon")));
            this.icon.Text = "Barn's SideBar";
            this.icon.Visible = true;
            this.icon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.icon_MouseDoubleClick);
            // 
            // mnuTrayMenu
            // 
            this.mnuTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHide,
            this.mnuShow,
            this.customizeToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.mnuClose});
            this.mnuTrayMenu.Name = "mnuContext";
            this.mnuTrayMenu.Size = new System.Drawing.Size(151, 114);
            this.mnuTrayMenu.Opening += new System.ComponentModel.CancelEventHandler(this.mnuContext_Opening);
            // 
            // mnuHide
            // 
            this.mnuHide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuHide.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHide.Name = "mnuHide";
            this.mnuHide.Size = new System.Drawing.Size(150, 22);
            this.mnuHide.Text = "Hide SideBar";
            this.mnuHide.Click += new System.EventHandler(this.mnuHide_Click);
            // 
            // mnuShow
            // 
            this.mnuShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuShow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuShow.Name = "mnuShow";
            this.mnuShow.Size = new System.Drawing.Size(150, 22);
            this.mnuShow.Text = "Show SideBar";
            this.mnuShow.Visible = false;
            this.mnuShow.Click += new System.EventHandler(this.mnuShow_Click);
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.customizeToolStripMenuItem.Text = "Customize...";
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(150, 22);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // grpNote
            // 
            grpNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            grpNote.Controls.Add(this.button1);
            grpNote.Controls.Add(this.pnlTextColor);
            grpNote.Controls.Add(this.btnTextColor);
            grpNote.Controls.Add(this.btnNotePath);
            grpNote.Controls.Add(this.txtNotePath);
            grpNote.Controls.Add(lblNote);
            grpNote.Dock = System.Windows.Forms.DockStyle.Fill;
            grpNote.Location = new System.Drawing.Point(6, 6);
            grpNote.Margin = new System.Windows.Forms.Padding(6);
            grpNote.Name = "grpNote";
            grpNote.Size = new System.Drawing.Size(468, 112);
            grpNote.TabIndex = 13;
            grpNote.TabStop = false;
            grpNote.Text = "Note field";
            // 
            // btnUseComputerDir2
            // 
            this.btnUseComputerDir2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseComputerDir2.Location = new System.Drawing.Point(352, 20);
            this.btnUseComputerDir2.Name = "btnUseComputerDir2";
            this.btnUseComputerDir2.Size = new System.Drawing.Size(111, 23);
            this.btnUseComputerDir2.TabIndex = 20;
            this.btnUseComputerDir2.Text = "Use \"Computer\"-Dir";
            this.btnUseComputerDir2.UseVisualStyleBackColor = true;
            this.btnUseComputerDir2.Click += new System.EventHandler(this.btnUseComputerDir2_Click);
            // 
            // btnDir2Path
            // 
            this.btnDir2Path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDir2Path.Location = new System.Drawing.Point(249, 20);
            this.btnDir2Path.Name = "btnDir2Path";
            this.btnDir2Path.Size = new System.Drawing.Size(75, 23);
            this.btnDir2Path.TabIndex = 18;
            this.btnDir2Path.Text = "Browse...";
            this.btnDir2Path.UseVisualStyleBackColor = true;
            this.btnDir2Path.Click += new System.EventHandler(this.btnDir2Path_Click);
            // 
            // txtDir2Path
            // 
            this.txtDir2Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDir2Path.Location = new System.Drawing.Point(9, 20);
            this.txtDir2Path.Name = "txtDir2Path";
            this.txtDir2Path.ReadOnly = true;
            this.txtDir2Path.Size = new System.Drawing.Size(234, 20);
            this.txtDir2Path.TabIndex = 17;
            this.txtDir2Path.Text = "<path to dir2>";
            // 
            // btnNotePath
            // 
            this.btnNotePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotePath.Location = new System.Drawing.Point(387, 30);
            this.btnNotePath.Name = "btnNotePath";
            this.btnNotePath.Size = new System.Drawing.Size(75, 23);
            this.btnNotePath.TabIndex = 12;
            this.btnNotePath.Text = "Browse...";
            this.btnNotePath.UseVisualStyleBackColor = true;
            this.btnNotePath.Click += new System.EventHandler(this.btnNotePath_Click);
            // 
            // txtNotePath
            // 
            this.txtNotePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotePath.Location = new System.Drawing.Point(9, 32);
            this.txtNotePath.Name = "txtNotePath";
            this.txtNotePath.ReadOnly = true;
            this.txtNotePath.Size = new System.Drawing.Size(372, 20);
            this.txtNotePath.TabIndex = 11;
            this.txtNotePath.Text = "<path to notefile>";
            // 
            // pnlTextColor
            // 
            this.pnlTextColor.BackColor = System.Drawing.Color.Fuchsia;
            this.pnlTextColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTextColor.Location = new System.Drawing.Point(113, 65);
            this.pnlTextColor.Name = "pnlTextColor";
            this.pnlTextColor.Size = new System.Drawing.Size(30, 22);
            this.pnlTextColor.TabIndex = 14;
            this.pnlTextColor.Click += new System.EventHandler(this.btnTextColor_Click);
            // 
            // btnTextColor
            // 
            this.btnTextColor.Location = new System.Drawing.Point(9, 58);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(143, 34);
            this.btnTextColor.TabIndex = 13;
            this.btnTextColor.Text = "Font color...";
            this.btnTextColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTextColor.UseVisualStyleBackColor = true;
            this.btnTextColor.Click += new System.EventHandler(this.btnTextColor_Click);
            // 
            // dlgTextColor
            // 
            this.dlgTextColor.Color = System.Drawing.Color.White;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(842, 255);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 33);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpAutoHide
            // 
            grpAutoHide.Controls.Add(lblAutoShowWaitTime);
            grpAutoHide.Controls.Add(this.nudAutoShowWaitTime);
            grpAutoHide.Controls.Add(lblAutoHideTime);
            grpAutoHide.Controls.Add(this.nudAutoHideWaitTime);
            grpAutoHide.Controls.Add(this.pnlHiddenBarColor);
            grpAutoHide.Controls.Add(this.btnHiddenBarColor);
            grpAutoHide.Controls.Add(lblAutoHideSpeed);
            grpAutoHide.Controls.Add(this.chkAutoHide);
            grpAutoHide.Controls.Add(this.nudAutoHideSpeed);
            grpAutoHide.Dock = System.Windows.Forms.DockStyle.Fill;
            grpAutoHide.Location = new System.Drawing.Point(486, 6);
            grpAutoHide.Margin = new System.Windows.Forms.Padding(6);
            grpAutoHide.Name = "grpAutoHide";
            grpAutoHide.Size = new System.Drawing.Size(469, 112);
            grpAutoHide.TabIndex = 16;
            grpAutoHide.TabStop = false;
            grpAutoHide.Text = "Auto hide";
            // 
            // nudAutoShowWaitTime
            // 
            this.nudAutoShowWaitTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAutoShowWaitTime.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAutoShowWaitTime.Location = new System.Drawing.Point(405, 73);
            this.nudAutoShowWaitTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudAutoShowWaitTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAutoShowWaitTime.Name = "nudAutoShowWaitTime";
            this.nudAutoShowWaitTime.Size = new System.Drawing.Size(58, 20);
            this.nudAutoShowWaitTime.TabIndex = 22;
            this.nudAutoShowWaitTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAutoShowWaitTime.ValueChanged += new System.EventHandler(this.nudAutoShowWaitTime_ValueChanged);
            // 
            // nudAutoHideWaitTime
            // 
            this.nudAutoHideWaitTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAutoHideWaitTime.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAutoHideWaitTime.Location = new System.Drawing.Point(405, 47);
            this.nudAutoHideWaitTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudAutoHideWaitTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAutoHideWaitTime.Name = "nudAutoHideWaitTime";
            this.nudAutoHideWaitTime.Size = new System.Drawing.Size(58, 20);
            this.nudAutoHideWaitTime.TabIndex = 20;
            this.nudAutoHideWaitTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAutoHideWaitTime.ValueChanged += new System.EventHandler(this.nudAutoHideWaitTime_ValueChanged);
            // 
            // pnlHiddenBarColor
            // 
            this.pnlHiddenBarColor.BackColor = System.Drawing.Color.Fuchsia;
            this.pnlHiddenBarColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHiddenBarColor.Location = new System.Drawing.Point(113, 53);
            this.pnlHiddenBarColor.Name = "pnlHiddenBarColor";
            this.pnlHiddenBarColor.Size = new System.Drawing.Size(30, 22);
            this.pnlHiddenBarColor.TabIndex = 19;
            this.pnlHiddenBarColor.Click += new System.EventHandler(this.btnHiddenBarColor_Click);
            // 
            // btnHiddenBarColor
            // 
            this.btnHiddenBarColor.Location = new System.Drawing.Point(7, 46);
            this.btnHiddenBarColor.Name = "btnHiddenBarColor";
            this.btnHiddenBarColor.Size = new System.Drawing.Size(145, 34);
            this.btnHiddenBarColor.TabIndex = 18;
            this.btnHiddenBarColor.Text = "Hidden bar color...";
            this.btnHiddenBarColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHiddenBarColor.UseVisualStyleBackColor = true;
            this.btnHiddenBarColor.Click += new System.EventHandler(this.btnHiddenBarColor_Click);
            // 
            // chkAutoHide
            // 
            this.chkAutoHide.AutoSize = true;
            this.chkAutoHide.Location = new System.Drawing.Point(10, 19);
            this.chkAutoHide.Name = "chkAutoHide";
            this.chkAutoHide.Size = new System.Drawing.Size(112, 17);
            this.chkAutoHide.TabIndex = 15;
            this.chkAutoHide.Text = "Activate auto hide";
            this.chkAutoHide.UseVisualStyleBackColor = true;
            this.chkAutoHide.CheckedChanged += new System.EventHandler(this.chkAutoHide_CheckedChanged);
            // 
            // nudAutoHideSpeed
            // 
            this.nudAutoHideSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAutoHideSpeed.Location = new System.Drawing.Point(405, 21);
            this.nudAutoHideSpeed.Name = "nudAutoHideSpeed";
            this.nudAutoHideSpeed.Size = new System.Drawing.Size(58, 20);
            this.nudAutoHideSpeed.TabIndex = 16;
            this.nudAutoHideSpeed.ValueChanged += new System.EventHandler(this.nudAutoHideTime_ValueChange);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 33);
            this.button1.TabIndex = 27;
            this.button1.Text = "Font...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDir2View);
            groupBox1.Controls.Add(this.cmbDir2View);
            groupBox1.Controls.Add(this.txtDir2Path);
            groupBox1.Controls.Add(this.btnDir2Path);
            groupBox1.Controls.Add(lblOr2);
            groupBox1.Controls.Add(this.btnUseComputerDir2);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(486, 130);
            groupBox1.Margin = new System.Windows.Forms.Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(469, 112);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lower Explorer window";
            // 
            // lblDir2View
            // 
            lblDir2View.AutoSize = true;
            lblDir2View.Location = new System.Drawing.Point(6, 69);
            lblDir2View.Name = "lblDir2View";
            lblDir2View.Size = new System.Drawing.Size(72, 13);
            lblDir2View.TabIndex = 25;
            lblDir2View.Text = "View settings:";
            // 
            // cmbDir2View
            // 
            this.cmbDir2View.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDir2View.Items.AddRange(new object[] {
            "Details",
            "Icon",
            "List",
            "Small Icon",
            "Thumbnail",
            "Thumbstrip",
            "Tile"});
            this.cmbDir2View.Location = new System.Drawing.Point(84, 66);
            this.cmbDir2View.Name = "cmbDir2View";
            this.cmbDir2View.Size = new System.Drawing.Size(137, 21);
            this.cmbDir2View.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(grpDir1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(grpNote, 0, 0);
            this.tableLayoutPanel1.Controls.Add(grpAutoHide, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(961, 248);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // cmbDir1View
            // 
            this.cmbDir1View.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDir1View.Items.AddRange(new object[] {
            "Details",
            "Icon",
            "List",
            "Small Icon",
            "Thumbnail",
            "Thumbstrip",
            "Tile"});
            this.cmbDir1View.Location = new System.Drawing.Point(82, 66);
            this.cmbDir1View.Name = "cmbDir1View";
            this.cmbDir1View.Size = new System.Drawing.Size(137, 21);
            this.cmbDir1View.TabIndex = 23;
            // 
            // lblDir1View
            // 
            lblDir1View.AutoSize = true;
            lblDir1View.Location = new System.Drawing.Point(6, 69);
            lblDir1View.Name = "lblDir1View";
            lblDir1View.Size = new System.Drawing.Size(72, 13);
            lblDir1View.TabIndex = 25;
            lblDir1View.Text = "View settings:";
            // 
            // lblOr1
            // 
            lblOr1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblOr1.AutoSize = true;
            lblOr1.Location = new System.Drawing.Point(327, 22);
            lblOr1.Name = "lblOr1";
            lblOr1.Size = new System.Drawing.Size(16, 13);
            lblOr1.TabIndex = 21;
            lblOr1.Text = "or";
            // 
            // btnUseComputerDir1
            // 
            this.btnUseComputerDir1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseComputerDir1.Location = new System.Drawing.Point(349, 17);
            this.btnUseComputerDir1.Name = "btnUseComputerDir1";
            this.btnUseComputerDir1.Size = new System.Drawing.Size(111, 23);
            this.btnUseComputerDir1.TabIndex = 19;
            this.btnUseComputerDir1.Text = "Use \"Computer\"-Dir";
            this.btnUseComputerDir1.UseVisualStyleBackColor = true;
            this.btnUseComputerDir1.Click += new System.EventHandler(this.btnUseComputerDir1_Click);
            // 
            // btnDir1Path
            // 
            this.btnDir1Path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDir1Path.Location = new System.Drawing.Point(246, 18);
            this.btnDir1Path.Name = "btnDir1Path";
            this.btnDir1Path.Size = new System.Drawing.Size(75, 23);
            this.btnDir1Path.TabIndex = 15;
            this.btnDir1Path.Text = "Browse...";
            this.btnDir1Path.UseVisualStyleBackColor = true;
            this.btnDir1Path.Click += new System.EventHandler(this.btnDir1Path_Click);
            // 
            // txtDir1Path
            // 
            this.txtDir1Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDir1Path.Location = new System.Drawing.Point(7, 19);
            this.txtDir1Path.Name = "txtDir1Path";
            this.txtDir1Path.ReadOnly = true;
            this.txtDir1Path.Size = new System.Drawing.Size(233, 20);
            this.txtDir1Path.TabIndex = 14;
            this.txtDir1Path.Text = "<path to dir1>";
            // 
            // grpDir1
            // 
            grpDir1.Controls.Add(this.txtDir1Path);
            grpDir1.Controls.Add(this.btnDir1Path);
            grpDir1.Controls.Add(this.btnUseComputerDir1);
            grpDir1.Controls.Add(lblOr1);
            grpDir1.Controls.Add(lblDir1View);
            grpDir1.Controls.Add(this.cmbDir1View);
            grpDir1.Dock = System.Windows.Forms.DockStyle.Fill;
            grpDir1.Location = new System.Drawing.Point(6, 130);
            grpDir1.Margin = new System.Windows.Forms.Padding(6);
            grpDir1.Name = "grpDir1";
            grpDir1.Size = new System.Drawing.Size(468, 112);
            grpDir1.TabIndex = 17;
            grpDir1.TabStop = false;
            grpDir1.Text = "Upper Explorer window";
            // 
            // FrmPreferences
            // 
            this.AcceptButton = this.btnClose;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(961, 300);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1, 1);
            this.Name = "FrmPreferences";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "Barn\'s SideBar - Preferences";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmPreferences_Load);
            this.mnuTrayMenu.ResumeLayout(false);
            grpNote.ResumeLayout(false);
            grpNote.PerformLayout();
            grpAutoHide.ResumeLayout(false);
            grpAutoHide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoShowWaitTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoHideWaitTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoHideSpeed)).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            grpDir1.ResumeLayout(false);
            grpDir1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon icon;
        private System.Windows.Forms.ContextMenuStrip mnuTrayMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHide;
        private System.Windows.Forms.ToolStripMenuItem mnuShow;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.Button btnDir2Path;
        private System.Windows.Forms.TextBox txtDir2Path;
        private System.Windows.Forms.Button btnNotePath;
        private System.Windows.Forms.TextBox txtNotePath;
        private System.Windows.Forms.FolderBrowserDialog dlgFolderNote;
        private System.Windows.Forms.FolderBrowserDialog dlgFolderDir1;
        private System.Windows.Forms.FolderBrowserDialog dlgFolderDir2;
        private System.Windows.Forms.Panel pnlTextColor;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.ColorDialog dlgTextColor;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudAutoShowWaitTime;
        private System.Windows.Forms.NumericUpDown nudAutoHideWaitTime;
        private System.Windows.Forms.Panel pnlHiddenBarColor;
        private System.Windows.Forms.Button btnHiddenBarColor;
        private System.Windows.Forms.CheckBox chkAutoHide;
        private System.Windows.Forms.NumericUpDown nudAutoHideSpeed;
        private System.Windows.Forms.ColorDialog dlgHiddenBarColor;
        private System.Windows.Forms.Button btnUseComputerDir2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbDir2View;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtDir1Path;
        private System.Windows.Forms.Button btnDir1Path;
        private System.Windows.Forms.Button btnUseComputerDir1;
        private System.Windows.Forms.ComboBox cmbDir1View;
    }
}