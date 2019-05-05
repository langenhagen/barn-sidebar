using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

using Microsoft.Win32;

using Shell32;

using Native;

using rrw = RegistryReaderWriter.RegistryReaderWriter;

namespace Sidebar
{
    public partial class FrmSideBar : Form
    {
        // INSTANCE VARS //////////////////////////////////////////////////////////////////////////

        // defines how far we are extending the Glass margins
        private Win32.MARGINS margins;
        // Path to the .note-file
        private String notePath;
        // specifies if the auto-hide-behaviour is enabled
        private bool hideEnabled;
        // specifies the auto-hide animation speed
        private int hideSpeed;
        // the location of the hidden sidebar when autohide is enabled
        private Point hiddenLoc;
        // the location of the unhidden sidebar
        private Point unHiddenLoc;
        // if the bar is hidden, this form will be shown
        private FrmSideBarHidden hiddenBar;

        // specifies, if this form is initialized successfully;
        private bool isInit;
        // indicates whether the window is hidden or not
        private bool hidden;

        // CONSTRUCTOR ////////////////////////////////////////////////////////////////////////////
        
        /// <summary>
        /// Constructor.
        /// </summary>
        public FrmSideBar()
        {
            isInit = false;

            InitializeComponent();

            // create 'hidden' bar
            this.hiddenBar = new FrmSideBarHidden();
            hiddenBar.SideBar = this;
        }

        // PUBLIC METHODS /////////////////////////////////////////////////////////////////////////

        #region public methods
        
        #endregion

        // EVENT HANDLERS /////////////////////////////////////////////////////////////////////////

        #region EventHandlers & standard shmoo

        /// <summary>
        /// Overrides the onload, and defines our Glass margins
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // sets up the glass power - if possible
            setGlassRegion();

            // sets the height appropriate to the bounds
            this.Size = new Size(10, Screen.GetWorkingArea(this.Bounds).Height);

            // initialize variables
            loadSettings();

            // set locations
            this.hiddenLoc = new Point(Screen.GetBounds(this.Bounds).Width, Screen.GetBounds(this.Bounds).Y);
            this.unHiddenLoc = new Point(Screen.GetBounds(this.Bounds).Width - this.Width, Screen.GetBounds(this.Bounds).Y);

            if (hideEnabled)
            {
                this.Location = hiddenLoc;
                hiddenBar.Show();
            }
            else
            {
                this.Location = unHiddenLoc;
                RegisterBar(true);
            }

            // read note-file ...
            if (!File.Exists(notePath))
                return;

            try
            {
                StringBuilder sb = new StringBuilder();
                StreamReader sr = new StreamReader(notePath);

                txtNote.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Barn's SideBar: ERROR: Couldn't read .note-file at: " + notePath);
            }
        }

        /// <summary>
        /// Override the OnPaintBackground method, to draw the desired
        /// Glass regions black and display as Glass
        /// </summary>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaint(e);

            // if vista ir win7 & aero enabled
            if (Win32.DwmIsCompositionEnabled())
            {
                e.Graphics.Clear(Color.Black);
            }
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            // if aero is on, set back colors to black
            if (!Win32.DwmIsCompositionEnabled())
                return;

            txtNote.BackColor = Color.Black;
            split1.BackColor = Color.Black;
            split2.BackColor = Color.Black;
            split3.BackColor = Color.Black;
            split3.Panel2.BackColor = Color.Black;
            pnlBackground.BackColor = Color.Black;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
            hiddenBar.Hide();
            RegisterBar(false);
        }


        private void txtNote_SaveText(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outfile = new StreamWriter(notePath);
                outfile.Write(txtNote.Text);
                outfile.Close();
            }
            catch { }
        }

        private void FrmAeroSideBar_FormClosing(object sender, FormClosingEventArgs e)
        {
            hiddenBar.Close();
            try
            {
                StreamWriter outfile = new StreamWriter(notePath);
                outfile.Write(txtNote.Text);
                outfile.Close();
            }
            catch
            {
                MessageBox.Show("Barn's SideBar: ERROR: Couldn't write note to file: " + notePath);
            }
        }

        private void split1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if( isInit)
                rrw.setValue( "splitDist1", split1.SplitterDistance);
        }

        private void split2_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if( isInit)
                rrw.setValue("splitDist2", split2.SplitterDistance);
        }

        private void split3_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if( isInit)
                rrw.setValue("splitDist3", split3.SplitterDistance);
        }

        /// <summary>
        /// Unregisters SideBar when resizing begins
        /// </summary>
        private void FrmAeroSideBar_ResizeBegin(object sender, EventArgs e)
        {
            if( !hideEnabled)
            RegisterBar( false);
        }

        /// <summary>
        /// Registers SideBar again when resizing ends
        /// </summary>
        private void FrmAeroSideBar_ResizeEnd(object sender, EventArgs e)
        {
            if ( !hideEnabled)
                RegisterBar( true);

            rrw.setValue("barWidth", this.Width);
        }

        private void tmrHideWait_Tick(object sender, EventArgs e)
        {
            tmrHideAnim.Enabled = true;
            tmrHideWait.Enabled = false;
        }

        private void tmrHideAnim_Tick(object sender, EventArgs e)
        {
            if (this.IsDisposed)
            {
                tmrHideAnim.Enabled = false;
                return;
            }

            if (this.Location.X + hideSpeed * tmrHideAnim.Interval < Screen.GetBounds(this.Bounds).Width)
            {
                this.Location = new Point(this.Location.X + hideSpeed * tmrHideAnim.Interval, this.Location.Y);
            }
            else
            {
                hidden = true;
                this.Location = hiddenLoc;
                hiddenBar.Location = hiddenBar.LocationOnBorder;
                tmrHideAnim.Enabled = false;
                if(hideEnabled)
                    hiddenBar.Show();
                this.Hide();
            }
        }

        private void tmrUpdateCursorPos_Tick(object sender, EventArgs e)
        {
            int curPosX = Cursor.Position.X;
            int curPosY = Cursor.Position.Y;


            if (hidden)     // if hidden
            {
                if (
                    curPosX < hiddenBar.Location.X
                    || Cursor.Position.Y < hiddenBar.Location.Y
                    || curPosX > hiddenBar.Location.X + hiddenBar.Width
                    || Cursor.Position.Y > hiddenBar.Location.Y + hiddenBar.Height
                    )
                { 
                    // outside
                    if (hiddenBar.TmrAutoShow.Enabled == true)
                        hiddenBar.TmrAutoShow.Enabled = false;
                }
                else
                {
                    // inside
                    if (hiddenBar.TmrAutoShow.Enabled == false && MouseButtons == MouseButtons.None)
                        hiddenBar.TmrAutoShow.Enabled = true;
                }
            }
            else            // if visible
            {
                if (
                    curPosX < this.Location.X
                    || curPosY < this.Location.Y
                    || curPosX > this.Location.X + this.Width
                    || curPosY > this.Location.Y + this.Height
                    )
                {
                    // outside the window
                    if ( tmrHideWait.Enabled == false)
                        tmrHideWait.Enabled = true;
                }
                else
                {
                    // inside the window
                    if (tmrHideWait.Enabled == true)
                        tmrHideWait.Enabled = false;
                }
            }
        }

        private void expExplorer1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            expExplorer1.setViewToListView();
        }

        private void expExplorer2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            expExplorer2.setViewToListView();
        }

        /// <summary>
        /// This timer is necessary for setting the explorer-views after loading the gui
        /// If you find a better way, let me know!
        /// </summary>
        private void tmrDummySetter_Tick(object sender, EventArgs e)
        {
            if (expExplorer1.setViewToListView() && expExplorer2.setViewToListView())
            {
                tmrDummySetter.Enabled = false;
                tmrDummySetter.Dispose();
            }     
        }

        #endregion

        // PRIVATE HELPERS ////////////////////////////////////////////////////////////////////////

        #region private helpers

        /// <summary>
        /// Loads the settings from a registry file or creates the standard-values
        /// </summary>
        public void loadSettings()
        {
            if ( ! rrw.createKey( Program.keyAddr, OnKeyOpenFailure))
                return;

            NotePath = rrw.getValueString("notePath", "C:\\.note");
            Explorer1Path = rrw.getValueString("explorer1Path", "shell:::{20d04fe0-3aea-1069-a2d8-08002b30309d}");
            Explorer2Path = rrw.getValueString("explorer2Path", "shell:::{20d04fe0-3aea-1069-a2d8-08002b30309d}");

            TextColor = Color.FromArgb(rrw.getValueInt("textColor", Color.Black.ToArgb()));
            
            this.Width = rrw.getValueInt("barWidth", 250);
            this.split1.SplitterDistance = rrw.getValueInt("splitDist1", 100);
            this.split2.SplitterDistance = rrw.getValueInt("splitDist2", 100);
            this.split3.SplitterDistance = rrw.getValueInt("splitDist3", 100);
            this.tmrHideWait.Interval = rrw.getValueInt("hideWaitTime", 500);

            AutoHideEnabled = rrw.getValueBool("autoHide", false);
            AutoHideSpeed = rrw.getValueInt("hideTime", 30);

            rrw.closeKey();

            isInit = true;
        }

        /// <summary>
        /// Use the form padding values to define a Glass margin
        /// </summary>
        private void setGlassRegion()
        {
            // Set up the glass effect using padding as the defining glass region
            // -1 margins indicate glass everywhere
            if (!Win32.DwmIsCompositionEnabled())
                return;

            margins = new Win32.MARGINS();
            margins.Top = -1;
            margins.Left = -1;
            margins.Bottom = -1;
            margins.Right = -1;
            Win32.DwmExtendFrameIntoClientArea(this.Handle, ref margins);
        }

        /// <summary>
        /// Forbids the window to be shown in the "Alt+Tab"-window and more
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= (~0x00C00000); // WS_CAPTION
                cp.Style &= (~0x00800000); // WS_BORDER
                cp.ExStyle = 0x00000080 | 0x00000008; // WS_EX_TOOLWINDOW | WS_EX_TOPMOST
                return cp;
            }
        }

        #endregion

        // APPBAR SHMOO ///////////////////////////////////////////////////////////////////////////

        #region APPBAR SHMOO

        [StructLayout(LayoutKind.Sequential)]
        struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct APPBARDATA
        {
            public int cbSize;
            public IntPtr hWnd;
            public int uCallbackMessage;
            public int uEdge;
            public RECT rc;
            public IntPtr lParam;
        }

        enum ABMsg : int
        {
            ABM_NEW = 0,
            ABM_REMOVE = 1,
            ABM_QUERYPOS = 2,
            ABM_SETPOS = 3,
            ABM_GETSTATE = 4,
            ABM_GETTASKBARPOS = 5,
            ABM_ACTIVATE = 6,
            ABM_GETAUTOHIDEBAR = 7,
            ABM_SETAUTOHIDEBAR = 8,
            ABM_WINDOWPOSCHANGED = 9,
            ABM_SETSTATE = 10
        }

        enum ABNotify : int
        {
            ABN_STATECHANGE = 0,
            ABN_POSCHANGED,
            ABN_FULLSCREENAPP,
            ABN_WINDOWARRANGE
        }

        enum ABEdge : int
        {
            ABE_LEFT = 0,
            ABE_TOP,
            ABE_RIGHT,
            ABE_BOTTOM
        }

        [DllImport("SHELL32", CallingConvention = CallingConvention.StdCall)]
        static extern uint SHAppBarMessage(int dwMessage, ref APPBARDATA pData);
        [DllImport("USER32")]
        static extern int GetSystemMetrics(int Index);
        [DllImport("User32.dll", ExactSpelling = true,
            CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern bool MoveWindow
            (IntPtr hWnd, int x, int y, int cx, int cy, bool repaint);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern int RegisterWindowMessage(string msg);
        private int uCallBack;

        /// <summary>
        /// Registers or respectively unregisters the sidebar as a docked bar
        /// </summary>
        /// <param name="b"></param>
        public void RegisterBar( bool b)
        {
            if (this.IsDisposed)
                return;

            APPBARDATA abd = new APPBARDATA();
            abd.cbSize = Marshal.SizeOf(abd);
            abd.hWnd = this.Handle;

            if (b)
            {
                uCallBack = RegisterWindowMessage("AppBarMessage");
                abd.uCallbackMessage = uCallBack;
                uint ret = SHAppBarMessage((int)ABMsg.ABM_NEW, ref abd);
                ABSetPos();
            }
            else
            {
                SHAppBarMessage((int)ABMsg.ABM_REMOVE, ref abd);
            }
        }

        private void ABSetPos()
        {
            APPBARDATA abd = new APPBARDATA();
            abd.cbSize = Marshal.SizeOf(abd);
            abd.hWnd = this.Handle;
            abd.uEdge = (int)ABEdge.ABE_RIGHT;

            if (abd.uEdge == (int)ABEdge.ABE_LEFT || abd.uEdge == (int)ABEdge.ABE_RIGHT)
            {
                abd.rc.top = 0;
                abd.rc.bottom = SystemInformation.PrimaryMonitorSize.Height;
                if (abd.uEdge == (int)ABEdge.ABE_LEFT)
                {
                    abd.rc.left = 0;
                    abd.rc.right = Size.Width;
                }
                else
                {
                    abd.rc.right = SystemInformation.PrimaryMonitorSize.Width;
                    abd.rc.left = abd.rc.right - Size.Width;
                }
            }
            else
            {
                abd.rc.left = 0;
                abd.rc.right = SystemInformation.PrimaryMonitorSize.Width;
                if (abd.uEdge == (int)ABEdge.ABE_TOP)
                {
                    abd.rc.top = 0;
                    abd.rc.bottom = Size.Height;
                }
                else
                {
                    abd.rc.bottom = SystemInformation.PrimaryMonitorSize.Height;
                    abd.rc.top = abd.rc.bottom - Size.Height;
                }
            }

            // Query the system for an approved size and position. 
            SHAppBarMessage((int)ABMsg.ABM_QUERYPOS, ref abd);

            // Adjust the rectangle, depending on the edge to which the 
            // appbar is anchored. 
            switch (abd.uEdge)
            {
                case (int)ABEdge.ABE_LEFT:
                    abd.rc.right = abd.rc.left + Size.Width;
                    break;
                case (int)ABEdge.ABE_RIGHT:
                    abd.rc.left = abd.rc.right - Size.Width;
                    break;
                case (int)ABEdge.ABE_TOP:
                    abd.rc.bottom = abd.rc.top + Size.Height;
                    break;
                case (int)ABEdge.ABE_BOTTOM:
                    abd.rc.top = abd.rc.bottom - Size.Height;
                    break;
            }

            // Pass the final bounding rectangle to the system. 
            SHAppBarMessage((int)ABMsg.ABM_SETPOS, ref abd);

            // Move and size the appbar so that it conforms to the 
            // bounding rectangle passed to the system. 
            MoveWindow(abd.hWnd, abd.rc.left, abd.rc.top,
                abd.rc.right - abd.rc.left, abd.rc.bottom - abd.rc.top, true);
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == uCallBack)
            {
                switch (m.WParam.ToInt32())
                {
                    case (int)ABNotify.ABN_POSCHANGED:
                        ABSetPos();
                        break;
                }
            }
            base.WndProc(ref m);
        }

        #endregion

        // GETTERS & SETTERS //////////////////////////////////////////////////////////////////////

        #region getters & setters

        public FrmSideBarHidden HiddenBar
        {
            get { return hiddenBar; }
            set { hiddenBar = value; }
        }

        public Timer TmrHideWait
        {
            get { return tmrHideWait; }
            set { tmrHideWait = value; }
        }

        public bool AutoHideEnabled
        {
            get { return hideEnabled; }
            set
            {
                this.hideEnabled = value;
                this.tmrUpdateCursorPos.Enabled = value;

                if (value)
                {
                    tmrHideAnim.Enabled = true;
                }
                else
                {
                    this.Location = unHiddenLoc;
                    this.Show();
                    this.HiddenBar.Hide();
                }
            }
        }

        public int AutoHideSpeed
        {
            get { return hideSpeed; }
            set { hideSpeed = value; }
        }

        public Color TextColor
        {
            get { return txtNote.ForeColor; }
            set { txtNote.ForeColor = value; }
        }

        public string NotePath
        {
            get { return notePath; }
            set { notePath = value; }
        }

        public string Explorer1Path
        {
            get 
            {
                return expExplorer1.Url.ToString();
            }

            set
            {
                try
                {
                    expExplorer1.Url = new Uri(value);
                }
                catch { }
            }
        }

        public string Explorer2Path
        {
            get
            {
                return expExplorer2.Url.ToString();
            }
            set
            {
                try
                {
                    expExplorer2.Url = new Uri(value);
                }
                catch { }
            }
        }

        public int SplitVal1
        {
            get { return this.split1.SplitterDistance; }
            set { this.split1.SplitterDistance = value; }
        }

        public int SplitVal2
        {
            get { return this.split2.SplitterDistance; }
            set { this.split2.SplitterDistance = value; }
        }

        public int SplitVal3
        {
            get { return this.split3.SplitterDistance; }
            set { this.split3.SplitterDistance = value; }
        }

        public Point HiddenLoc
        {
            get { return hiddenLoc; }
            set { hiddenLoc = value; }
        }

        public Point UnHiddenLoc
        {
            get { return unHiddenLoc; }
            set { unHiddenLoc = value; }
        }

        public bool Hidden
        {
            get { return hidden; }
            set { hidden = value; }
        }


        #endregion

        // DELEGATES //////////////////////////////////////////////////////////////////////////////

        #region delegates

        /// <summary>
        /// Happens when opening the key fails
        /// </summary>
        private void OnKeyOpenFailure()
        {
            MessageBox.Show("Bar-ERROR: Opening registry key failed! Using standard values.");

            NotePath = "C:\\.note";
            Explorer1Path = "C:\\";
            Explorer2Path = "shell:::{20d04fe0-3aea-1069-a2d8-08002b30309d}";
            TextColor = Color.Red;
            this.Width =  100;
            this.split1.SplitterDistance = 100;
            this.split2.SplitterDistance = 100;
            this.split3.SplitterDistance = 100;
            AutoHideEnabled = false;
            AutoHideSpeed = 30;
        }

        #endregion
       
    } // END Class AeroBar
}