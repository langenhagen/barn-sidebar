using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.Win32;

using rrw = RegistryReaderWriter.RegistryReaderWriter;

/*
 * This class has the only purpose to maintain the Icon PLUS it will be used to display a customization form for preferences
 * When hiding the app-bar, the appbar vanishes in fact, but it doesn't free the screen space so that other windows could use it
 * So i have to close the app-bar, which then could not maintain an icon, because it woulb be also disposed, whatever.
 * Therefore i need a manager form, which is invisible all the time but maintains the icon.
 */

namespace Sidebar
{
    public partial class FrmPreferences : Form
    {

        // INSTANCE VARS //////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// the sidebar
        /// </summary>
        private FrmSideBar bar;

        // CONSTRUCTOR ////////////////////////////////////////////////////////////////////////////

        public FrmPreferences()
        {
            InitializeComponent();

            bar = new FrmSideBar();
            bar.Show();
        }

        // PRIVATE HELPERS ////////////////////////////////////////////////////////////////////////

        // GETTERS & SETTERS //////////////////////////////////////////////////////////////////////

        #region getters & setters

        #endregion

        // EVENT HANDLERS /////////////////////////////////////////////////////////////////////////

        #region event handlers

        private void FrmPreferences_Load(object sender, EventArgs e)
        {
            // adapt GUI to settings
            txtNotePath.Text = bar.NotePath;
            txtDir1Path.Text = bar.Explorer1Path;
            txtDir2Path.Text = bar.Explorer2Path;
            pnlTextColor.BackColor = bar.TextColor;
            nudAutoHideSpeed.Value = bar.AutoHideSpeed;
            nudAutoHideWaitTime.Value = bar.TmrHideWait.Interval;
            nudAutoShowWaitTime.Value = bar.HiddenBar.TmrAutoShow.Interval;
            pnlHiddenBarColor.BackColor = bar.HiddenBar.BackColor;

            if (bar.AutoHideEnabled)
            {
                chkAutoHide.Checked = true;
            }
            else
            {
                chkAutoHide.Checked = false;
            }
        }

        private void mnuHide_Click(object sender, EventArgs e)
        {
            bar.Hide();
            bar.HiddenBar.Hide();
            bar.RegisterBar(false);
        }

        private void mnuShow_Click(object sender, EventArgs e)
        {
            bar.Show();
            if (bar.AutoHideEnabled)
            {
                bar.HiddenBar.Show();
            }
            else
            {
                bar.HiddenBar.Hide();
                bar.RegisterBar(true);
            }
        }

        private void mnuContext_Opening(object sender, CancelEventArgs e)
        {
            if (bar.Visible)
            {
                mnuHide.Visible = true;
                mnuShow.Visible = false;
            }
            else
            {
                mnuHide.Visible = false;
                mnuShow.Visible = true;
            }
        }

        private void icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (bar.Visible)
                mnuHide_Click(sender, e);
            else
                mnuShow_Click(sender, e);
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( this.Opacity != 1)
                this.Opacity = 1;
            this.Show();
        }

        private void btnTextColor_Click(object sender, EventArgs e)
        {
            dlgTextColor.ShowDialog();

            Color color = dlgTextColor.Color;
            if (color == null)
                return;

            bar.TextColor = color;
            pnlTextColor.BackColor = color;

            rrw.setValue("textColor", bar.TextColor.ToArgb());
        }

        private void btnNotePath_Click(object sender, EventArgs e)
        {
            dlgFolderNote.ShowDialog();
            if (dlgFolderNote.SelectedPath == "")
                return;

            string path = dlgFolderNote.SelectedPath + "\\.note";
            bar.NotePath = path;
            txtNotePath.Text = path;;

            rrw.setValue("notePath", path);
        }

        private void btnDir1Path_Click(object sender, EventArgs e)
        {
            dlgFolderDir1.ShowDialog();
            string path = dlgFolderDir1.SelectedPath;
            if (path == "")
                return;
            
            bar.Explorer1Path = path;
            txtDir1Path.Text = path;

            rrw.setValue("explorer1Path", path);
        }

        private void btnDir2Path_Click(object sender, EventArgs e)
        {
            dlgFolderDir2.ShowDialog();
            string path = dlgFolderDir2.SelectedPath;
            if (path == "")
                return;

            bar.Explorer2Path = path;
            txtDir2Path.Text = path;

            rrw.setValue("explorer2Path", path);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void chkAutoHide_CheckedChanged(object sender, EventArgs e)
        {
            bool b = this.chkAutoHide.Checked;

            rrw.setValue("autoHide", b);

            if (bar != null && !bar.IsDisposed)
            {
                bar.AutoHideEnabled = b;
                bar.RegisterBar( !b);
            }            
        }

        private void nudAutoHideTime_ValueChange(object sender, EventArgs e)
        {
            if (bar != null)
                bar.AutoHideSpeed = (int)nudAutoHideSpeed.Value;

            rrw.setValue("hideTime", bar.AutoHideSpeed);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAbout().Show();
        }

        private void nudAutoHideWaitTime_ValueChanged(object sender, EventArgs e)
        {
            int time = (int)nudAutoHideWaitTime.Value;
            bar.TmrHideWait.Interval = time;

            rrw.setValue("hideWaitTime", time);
        }

        private void nudAutoShowWaitTime_ValueChanged(object sender, EventArgs e)
        {
            int time = (int)nudAutoShowWaitTime.Value;
            bar.HiddenBar.TmrAutoShow.Interval = time;

            rrw.setValue("showWaitTime", time);
        }

        private void btnHiddenBarColor_Click(object sender, EventArgs e)
        {
            dlgHiddenBarColor.ShowDialog();
            Color color = Color.FromArgb( dlgHiddenBarColor.Color.ToArgb());

            pnlHiddenBarColor.BackColor = color;
            bar.HiddenBar.BackColor = color;

            rrw.setValue("hiddenBarColor", color.ToArgb());
        }

        #endregion

        private void btnUseComputerDir1_Click(object sender, EventArgs e)
        {
            string path = "shell:::{20d04fe0-3aea-1069-a2d8-08002b30309d}";
            
            bar.Explorer1Path = path;
            txtDir1Path.Text = path;

            rrw.setValue("explorer1Path", path);
        }

        private void btnUseComputerDir2_Click(object sender, EventArgs e)
        {
            string path = "shell:::{20d04fe0-3aea-1069-a2d8-08002b30309d}";

            bar.Explorer2Path = path;
            txtDir2Path.Text = path;

            rrw.setValue("explorer2Path", path);
        }

        private void cmbDir2View_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDir2View_Click(object sender, EventArgs e)
        {

        }

        // DELEGATES //////////////////////////////////////////////////////////////////////////////

        #region delegates 


        #endregion


    } // END FORM
} // END NAMESPACE