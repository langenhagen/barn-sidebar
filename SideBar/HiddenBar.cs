using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using rrw = RegistryReaderWriter;

namespace Sidebar
{
    /// <summary>
    /// The small bar marking a hidden sidebar
    /// </summary>
    public partial class FrmSideBarHidden : Form
    {
        // INSTANCE VARS //////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// the corresponding sidebar
        /// </summary>
        private FrmSideBar sidebar;

        /// <summary>
        /// the location of the hidden location
        /// </summary>
        private Point location;

        // CONSTRUCTOR ////////////////////////////////////////////////////////////////////////////

        public FrmSideBarHidden()
        {
            InitializeComponent();
        }

        // PRIVATE HELPERS ////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Loads the settings from a registry file or creates the standard-values
        /// </summary>
        private void loadSettings()
        {
            if ( !rrw.openKey(OnKeyOpenFailure))
                return;

            BackColor = Color.FromArgb(rrw.getValueInt("hiddenBarColor", Color.Black.ToArgb()));
            TmrAutoShow.Interval = rrw.getValueInt("showWaitTime", 500);

            rrw.closeKey();
        }


        /// <summary>
        /// Forbids the window to be shown in the "Alt+Tab"-Window
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle &= ~0x10000; // WS_EX_CONTROLPARENT - hide in Alt+Tab - window
                return param;
            }
        }

        // EVENT HANDLERS /////////////////////////////////////////////////////////////////////////

        private void frmSideBarHidden_Load(object sender, EventArgs e)
        {
            loadSettings();

            Rectangle bounds = Screen.GetBounds(this.Bounds);
            this.Size = new Size(2, bounds.Height * 3 / 4);
            location = new Point(bounds.Width - this.Width, bounds.Height / 8);
            this.Location = location;
        }

        private void tmrAutoShow_Tick(object sender, EventArgs e)
        {
            sidebar.Location = sidebar.UnHiddenLoc;
            tmrAutoShow.Enabled = false;
            sidebar.Hidden = false;
            sidebar.Show();
            this.Hide();
        }

        // GETTERS & SETTERS //////////////////////////////////////////////////////////////////////

        #region getters & setters

        public FrmSideBar SideBar
        {
            get { return sidebar; }
            set { sidebar = value; }
        }

        public Timer TmrAutoShow
        {
            get { return tmrAutoShow; }
            set { tmrAutoShow = value; }
        }

        public Point LocationOnBorder
        {
            get { return location; }
        }

        #endregion

        // DELEGATES //////////////////////////////////////////////////////////////////////////////

        #region delegates

        /// <summary>
        /// Happens when opening the key fails
        /// </summary>
        private void OnKeyOpenFailure()
        {
            MessageBox.Show("Hidden Bar-error: Opening registry key failed! Using standard values.", "Error while loading setting", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            BackColor = Color.Black;
            TmrAutoShow.Interval = 500;
        }

        #endregion

    }
}
